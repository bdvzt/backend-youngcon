using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs;
using YoungConService.DTOs.Users;
using YoungConService.Services;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController(IUserService service) : ControllerBase
{
    /// <summary>
    /// Создать пользователя (доступно только сотруднику)
    /// </summary>
    [Authorize(Roles = "Employee")]
    [HttpPost]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<ActionResult<Guid>> Create([FromBody] CreateUserRequest dto)
    {
        var user = await service.CreateUserAsync(dto);
        return Ok(user.Id);
    }
    
    /// <summary>
    /// Получить информацию о пользователе
    /// </summary>
    [Authorize]
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(UserDto), 200)]
    public async Task<ActionResult<UserDto>> Get(Guid id)
    {
        var user = await service.GetById(id);
        return Ok(user);
    }

    /// <summary>
    /// Считать QR и получить пользователя (доступно только сотруднику)
    /// </summary>
    [Authorize(Roles = "Employee")]
    [HttpPost("qr/resolve")]
    [ProducesResponseType(typeof(UserQrLookupDto), 200)]
    public async Task<ActionResult<UserQrLookupDto>> ResolveByQr([FromBody] ResolveUserByQrRequest request)
    {
        var user = await service.ResolveUserByQrAsync(request.QrCode);
        return Ok(user);
    }

    /// <summary>
    /// Выдать ачивку пользователю по QR (доступно только сотруднику)
    /// </summary>
    [Authorize(Roles = "Employee")]
    [HttpPost("achievements/assign-by-qr")]
    [ProducesResponseType(typeof(AssignAchievmentByQrResultDto), 200)]
    public async Task<ActionResult<AssignAchievmentByQrResultDto>> AssignAchievementByQr([FromBody] AssignAchievmentByQrRequest request)
    {
        var result = await service.AssignAchievmentByQrAsync(request);
        return Ok(result);
    }

    /// <summary>
    /// Получить ачивки пользователя
    /// </summary>
    [Authorize]
    [HttpGet("{id}/achievements")]
    [ProducesResponseType(typeof(UserAchievmentsDto), 200)]
    public async Task<ActionResult<UserAchievmentsDto>> GetAchievements(Guid id)
    {
        var achievements = await service.GetAchievmentsByUserId(id);
        return Ok(achievements);
    }

    /// <summary>
    /// Получить лайкнутые события пользователя
    /// </summary>
    [Authorize]
    [HttpGet("{id}/liked-events")]
    [ProducesResponseType(typeof(UserLikedEventsDto), 200)]
    public async Task<ActionResult<UserLikedEventsDto>> GetLikedEvents(Guid id)
    {
        var likedEvents = await service.GetLikedEventsByUserId(id);
        return Ok(likedEvents);
    }
    
    /// <summary>
    /// Получить информацию о себе
    /// </summary>
    [Authorize]
    [HttpGet("myself")]
    [ProducesResponseType(typeof(UserDto), 200)]
    public async Task<ActionResult<UserDto>> GetMyself()
    {
        var user = await service.GetMyself();
        return Ok(user);
    }

    /// <summary>
    /// Получить QR строку текущего пользователя
    /// </summary>
    [Authorize]
    [HttpGet("myself/qr")]
    [ProducesResponseType(typeof(UserQrCodeDto), 200)]
    public async Task<ActionResult<UserQrCodeDto>> GetMyQrCode()
    {
        var result = await service.GetMyQrCodeAsync();
        return Ok(result);
    }

    /// <summary>
    /// Получить информацию о пользователях
    /// </summary>
    [Authorize(Roles = "Employee")]
    [HttpGet("list")]
    [ProducesResponseType(typeof(PagedResponse<UserDto>), 200)]
    public async Task<ActionResult<PagedResponse<UserDto>>> GetAll([FromQuery] PagedRequest request)
    {
        var result = await service.GetAllAsync(request);
        return Ok(result);
    }

    // Добавлено поле StreamURL
}