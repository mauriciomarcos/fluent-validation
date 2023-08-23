using Application.Services;
using Domains.Entites;

namespace Domains.Interfaces.Services;

public interface IAlunoServices
{
    Task<ServiceResponseBase> Create(Aluno aluno);
}