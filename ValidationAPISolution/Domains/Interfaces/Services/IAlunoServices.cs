using Domains.Entites;
using Domains.Interfaces.Services.Bases;

namespace Domains.Interfaces.Services;

public interface IAlunoServices
{
    Task<IServiceResponseBase> Create(Aluno aluno);
}