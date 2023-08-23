using Application.Services.Bases;
using Domains.Entites;
using Domains.Interfaces.Services;
using Domains.Interfaces.Services.Bases;

namespace Application.Services;

public class AlunoService : IAlunoServices
{
    public async Task<IServiceResponseBase> Create(Aluno aluno)
    {
        var response = new ServiceResponseBase();
        response.AddNotification("CPF", "O CPF informado não corresponde a um CFP válido.");

        response.SetResponseData(new Aluno { Nome = "Maurício Marcos", Email = "001.mmarcos@gmail.com", DataNascimento = DateTime.Now });

        return await Task.FromResult(response);
    }
}