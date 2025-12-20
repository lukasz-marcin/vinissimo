using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using static backend.DTOs.TastingDtos;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // Cały kontroler wymaga zalogowania
    public class TastingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TastingController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/tasting
        // Zwraca lekką listę win zalogowanego użytkownika
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TastingListDto>>> GetAll()
        {
            var userId = GetUserId();

            var tastings = await _context.Tastings
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.TastingDate) 
                .Select(t => new TastingListDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    Producer = t.Producer,
                    Vintage = t.Vintage,
                    TastingDate = t.TastingDate,
                    Rating = t.Rating,
                    Type = t.Type.ToString() // Konwersja Enuma na tekst (np. "Red")
                })
                .ToListAsync();

            return Ok(tastings);
        }

        // GET: api/tasting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TastingDetailDto>> GetById(int id)
        {
            var userId = GetUserId();

            var tasting = await _context.Tastings
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId); // Sprawdzamy właściciela

            if (tasting == null)
            {
                return NotFound("Degustacja nie została znaleziona lub nie masz do niej dostępu.");
            }

            // Mapowanie ręczne na DTO szczegółowe
            // (W przyszłości możesz tu użyć AutoMapper, ale ręczne jest szybsze w MVP)
            var detailDto = new TastingDetailDto
            {
                Id = tasting.Id,
                TastingDate = tasting.TastingDate,
                Name = tasting.Name,
                Producer = tasting.Producer,
                Region = tasting.Region,
                Varietal = tasting.Varietal,
                Vintage = tasting.Vintage,
                Price = tasting.Price,
                Type = tasting.Type,

                EyeIntensity = tasting.EyeIntensity,
                EyeColor = tasting.EyeColor,
                EyeOther = tasting.EyeOther,

                NoseIntensity = tasting.NoseIntensity,
                AromasPrimary = tasting.AromasPrimary,
                AromasSecondary = tasting.AromasSecondary,
                AromasTertiary = tasting.AromasTertiary,

                Sweetness = tasting.Sweetness,
                Acidity = tasting.Acidity,
                Tannins = tasting.Tannins,
                Alcohol = tasting.Alcohol,
                Body = tasting.Body,
                FlavorIntensity = tasting.FlavorIntensity,
                Finish = tasting.Finish,

                Rating = tasting.Rating,
                QPrRatio = tasting.QPrRatio,
                Repurchase = tasting.Repurchase,
                Notes = tasting.Notes
            };

            return Ok(detailDto);
        }

        // POST: api/tasting
        // Dodaje nową degustację
        [HttpPost]
        public async Task<ActionResult<TastingListDto>> Create(CreateTastingDto dto)
        {
            var userId = GetUserId();

            var tasting = new Tasting
            {
                UserId = userId, // Przypisujemy do zalogowanego usera
                TastingDate = DateTime.Now,

                Name = dto.Name,
                Producer = dto.Producer,
                Region = dto.Region,
                Varietal = dto.Varietal,
                Vintage = dto.Vintage,
                Price = dto.Price,
                Type = dto.Type,

                EyeIntensity = dto.EyeIntensity,
                EyeColor = dto.EyeColor,
                EyeOther = dto.EyeOther,

                NoseIntensity = dto.NoseIntensity,
                AromasPrimary = dto.AromasPrimary,
                AromasSecondary = dto.AromasSecondary,
                AromasTertiary = dto.AromasTertiary,

                Sweetness = dto.Sweetness,
                Acidity = dto.Acidity,
                Tannins = dto.Tannins,
                Alcohol = dto.Alcohol,
                Body = dto.Body,
                FlavorIntensity = dto.FlavorIntensity,
                Finish = dto.Finish,

                Rating = dto.Rating,
                QPrRatio = dto.QPrRatio,
                Repurchase = dto.Repurchase,
                Notes = dto.Notes
            };

            _context.Tastings.Add(tasting);
            await _context.SaveChangesAsync();

            // Zwracamy 201 Created i link do szczegółów
            return CreatedAtAction(nameof(GetById), new { id = tasting.Id }, new TastingListDto
            {
                Id = tasting.Id,
                Name = tasting.Name,
                Rating = tasting.Rating
            });
        }

        // DELETE: api/tasting/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = GetUserId();

            var tasting = await _context.Tastings
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (tasting == null) return NotFound();

            _context.Tastings.Remove(tasting);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/tasting/5
        // Edycja
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CreateTastingDto dto)
        {
            var userId = GetUserId();
            var tasting = await _context.Tastings
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (tasting == null) return NotFound();

            // Aktualizacja pól
            tasting.Name = dto.Name;
            tasting.Producer = dto.Producer;
            tasting.Region = dto.Region;
            tasting.Varietal = dto.Varietal;
            tasting.Vintage = dto.Vintage;
            tasting.Price = dto.Price;
            tasting.Type = dto.Type;

            tasting.EyeIntensity = dto.EyeIntensity;
            tasting.EyeColor = dto.EyeColor;
            tasting.EyeOther = dto.EyeOther;

            tasting.NoseIntensity = dto.NoseIntensity;
            tasting.AromasPrimary = dto.AromasPrimary;
            tasting.AromasSecondary = dto.AromasSecondary;
            tasting.AromasTertiary = dto.AromasTertiary;

            tasting.Sweetness = dto.Sweetness;
            tasting.Acidity = dto.Acidity;
            tasting.Tannins = dto.Tannins;
            tasting.Alcohol = dto.Alcohol;
            tasting.Body = dto.Body;
            tasting.FlavorIntensity = dto.FlavorIntensity;
            tasting.Finish = dto.Finish;

            tasting.Rating = dto.Rating;
            tasting.QPrRatio = dto.QPrRatio;
            tasting.Repurchase = dto.Repurchase;
            tasting.Notes = dto.Notes;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Metoda pomocnicza do wyciągania ID z tokena JWT
        private int GetUserId()
        {
            var idClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(idClaim))
            {
                throw new Exception("Błąd tokena JWT: Brak Claimu NameIdentifier");
            }
            return int.Parse(idClaim);
        }
    }
}
