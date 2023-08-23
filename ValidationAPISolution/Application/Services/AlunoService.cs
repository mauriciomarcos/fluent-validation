using Domains.Entites;
using Domains.Interfaces.Services;

namespace Application.Services;

public class AlunoService : IAlunoServices
{
    public async Task<ServiceResponseBase> Create(Aluno aluno)
    {
        var response = new ServiceResponseBase();
        response.AddNotification("CPF", "O CPF informado não corresponde a um CFP válido.");

        response.SetResponseData(new Aluno { Nome = "Maurício Marcos", Email = "001.mmarcos@gmail.com", DataNascimento = DateTime.Now });

        return await Task.FromResult(response);
    }
}