using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using FitnessCenter.Service.ModelRequest;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCenter.Web.Controllers;

/// <summary>
/// Контроллер для управления занятиями (Class).
/// </summary>

public class ClassController : WebApiController
{
    private readonly IClassService _classService;
    private readonly ILogger<ClassController> _logger;

    public ClassController(IClassService classService, ILogger<ClassController> logger)
    {
        _classService = classService;
        _logger = logger;
    }

    /// <summary>
    /// Получить список всех занятий.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Class>), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 500)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var result = await _classService.GetAllAsync(cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Получить занятие по Id.
    /// </summary>
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(Class), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 404)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var result = await _classService.GetAsync(id, cancellationToken);
        if (result == null)
        {
            return NotFound(new ProblemDetails
            {
                Title = "Не найдено",
                Detail = $"Занятие с Id = {id} не найдено",
                Status = 404
            });
        }

        return Ok(result);
    }

    /// <summary>
    /// Создать занятие.
    /// </summary>
    [HttpPost]
    [ProducesResponseType(typeof(Guid), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<IActionResult> Create([FromBody] ClassesRequest request, CancellationToken cancellationToken)
    {
        var id = await _classService.CreateAsync(request, cancellationToken);
        return CreatedAtAction(nameof(GetById), new { id }, id);
    }

    /// <summary>
    /// Обновить занятие.
    /// </summary>
    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(Class), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<IActionResult> Update(Guid id, [FromBody] ClassesRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
        {
            return BadRequest(new ProblemDetails
            {
                Title = "Ошибка",
                Detail = "Id в теле и параметре не совпадают",
                Status = 400
            });
        }

        var updated = await _classService.UpdateAsync(request, cancellationToken);
        return Ok(updated);
    }

    /// <summary>
    /// Удалить занятие.
    /// </summary>
    [HttpDelete("{id:guid}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(typeof(ProblemDetails), 404)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var entity = await _classService.GetAsync(id, cancellationToken);
        if (entity == null)
        {
            return NotFound(new ProblemDetails
            {
                Title = "Не найдено",
                Detail = $"Занятие с Id = {id} не найдено",
                Status = 404
            });
        }

        await _classService.DeleteAsync(entity, cancellationToken);
        return NoContent();
    }
}
