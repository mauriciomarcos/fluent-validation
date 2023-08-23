using Application.Extension;
using Domains.Entites;
using Domains.Interfaces.Services;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace ValidationAPI.Controllers;

[ApiController]
[Route("api/aluno")]
public class AlunoController : ControllerBase
{
    private readonly IValidator<Aluno> _validator;
    private readonly IAlunoServices _alunoServices;

    public AlunoController(IValidator<Aluno> validator, IAlunoServices alunoServices)
    {
        _validator = validator;
        _alunoServices = alunoServices;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Aluno aluno)
    {
        var validation = await _validator.ValidateAsync(aluno);
        if (!validation.IsValid)
            return BadRequest(validation.GetErrors());

        var response = await _alunoServices.Create(aluno);
        if (response.HasNotifications)
            return BadRequest(response.GetErrors());

        return Ok(response);
    }
}