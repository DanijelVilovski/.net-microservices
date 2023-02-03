using AutoMapper;
using Uris.DTO;
using Uris.Models;

namespace Uris.Profiles
{
    public class KursProfile : Profile
    {
        public KursProfile()
        {
            CreateMap<Kurs, KursDTO>();
            CreateMap<KursDTO, Kurs>();
        }
    }
}
