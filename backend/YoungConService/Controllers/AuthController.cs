using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.DTOs;
using YoungConService.DTOs.Users;
using YoungConService.Infrastructure.Auth;
using YoungConService.Infrastructure.Repositories;
using YoungConService.Infrastructure.Errors.Exceptions;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController(YoungConDbContext db, AuthService authService) : ControllerBase
{
    /// <summary>
    /// Авторизация пользователя по почте и паролю
    /// </summary>
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            throw new BadRequestException(string.Join(", ", errors.Select(e => e.ErrorMessage)));
        }
        
        var user = await db.Users.FirstOrDefaultAsync(x => x.Email == request.Email);
        if (user == null)
        {
            throw new BadRequestException("Пользователь с такой почтой не зарегистрирован");
        }

        if (!BCrypt.Net.BCrypt.Verify(request.Password, user.HashPassword))
        {
            throw new BadRequestException("Неверный пароль");
        }

        var token = authService.GenerateToken(user);
        return Ok(new { token });
    }

    /// <summary>
    /// Выход пользователя из системы и добавление токена в blacklist
    /// </summary>
    [HttpPost("logout")]
    [Authorize]
    public async Task<IActionResult> Logout()
    {
        var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
        if (string.IsNullOrEmpty(token))
        {
            throw new BadRequestException("Пользователь не был авторизован");
        }

        await db.BlackTokens.AddAsync(new BlackToken
        {
            Token = token,
            ExpiryDate = DateTime.UtcNow
        });

        await db.SaveChangesAsync();
        return NoContent();
    }
}