using System.Security.Cryptography.X509Certificates;
using MrClean.Domain.Entities;

namespace MrClean.Application.Common.Models;

public class LookupDto
{
    public int Id { get; init; }

    public string? Name { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<MrCleanExampleEntity, LookupDto>();
        }
    }
}
