using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using static backend.DTOs.UserDtos;
using System.IdentityModel.Tokens.Jwt;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        // POST: api/auth/register
        [HttpPost("register")]
        public async Task<ActionResult<UserTokenResponseDto>> Register(RegisterDto request)
        {
            if (await _context.Users.AnyAsync(u => u.Login == request.Login))
            {
                return BadRequest("Użytkownik o takim adresie email już istnieje.");
            }
            if (request.BirthDate > DateTime.Now)
            {
                return BadRequest("Data urodzenia nie może być z przyszłości.");
            }

            if (request.BirthDate > DateTime.Now.AddYears(-18))
            {
                return BadRequest("Musisz mieć co najmniej 18 lat.");
            }


            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            var user = new User
            {
                Login = request.Login,
                BirthDate = request.BirthDate,
                PasswordHash = passwordHash
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            string token = CreateToken(user);
            UserTokenResponseDto userTokenResponseDto = new UserTokenResponseDto
            {
                Token = token,
                Id = user.Id,
                Login = user.Login,
                BirthDate = user.BirthDate
            };

            return Ok(userTokenResponseDto);
        }

        // POST: api/auth/login
        [HttpPost("login")]
        public async Task<ActionResult<UserTokenResponseDto>> Login(LoginDto request)
        {
            if (request.Login.Length == 0 || request.Password.Length == 0) // TODO: Walidacja do weryfikacji
            {
                return BadRequest("Brak podanego loginu lub hasła"); //TODO: umiędzynarodowienie wszelkich odpowiedzi
            }
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Login == request.Login);

            if (user == null)
            {
                return BadRequest("Nieprawidłowy login lub hasło.");
            }

            if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return BadRequest("Nieprawidłowy login lub hasło.");
            }

            string token = CreateToken(user);
            UserTokenResponseDto userTokenResponseDto = new UserTokenResponseDto
            {
                Token = token,
                Id = user.Id,
                Login = user.Login,
                BirthDate = user.BirthDate
            };

            return Ok(userTokenResponseDto);
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                //TODO dodać login i przemyslec ten nameidentifier
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("JwtSettings:SecretKey").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1), // Token ważny 1 dzień TODO: zmienic na refresh token
                signingCredentials: creds
            );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
