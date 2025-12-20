namespace backend.Tests
{
    public class LoginTests
    {
        [Fact]
        public async Task Login_ReturnsToken()
        {
            //Arrange
            var loginDto = new backend.DTOs.UserDtos.LoginDto
            {
                Login = "tester128",
                Password = "haslo128"
            }
    }
}