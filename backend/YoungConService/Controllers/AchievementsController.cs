using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs.Achievments;
using YoungConService.Services.Achievments;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/achievements")]
public class AchievementsController(IAchievmentService service) : ControllerBase
{
    /// <summary>
    /// Получить список ачивок
    /// </summary>
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<AchievmentDTO>>> GetAll()
        => Ok(await service.GetAllAsync());

    /// <summary>
    /// Получить ачивку по идентификатору ,,
    /// </summary>
    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<AchievmentDTO>> GetById(Guid id)
    {
        var achievment = await service.GetByIdAsync(id);
        return achievment == null ? NotFound() : Ok(achievment);
    }

    /// <summary>
    /// Создать ачивку (доступно только сотруднику)
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<AchievmentDTO>> Create([FromBody] CreateAchievmentRequest request)
    {
        var created = await service.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    /// <summary>
    /// Обновить ачивку (доступно только сотруднику)
    /// </summary>
    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<AchievmentDTO>> Update(Guid id, [FromBody] UpdateAchievmentRequest request)
    {
        var updated = await service.UpdateAsync(id, request);
        return updated == null ? NotFound() : Ok(updated);
    }

    /// <summary>
    /// Удалить ачивку (доступно только сотруднику)
    /// </summary>
    [HttpDelete("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var deleted = await service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}

