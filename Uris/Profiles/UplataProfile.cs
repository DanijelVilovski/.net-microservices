using AutoMapper;
using Uris.DTO;
using Uris.Models;

namespace Uris.Profiles
{
    public class UplataProfile : Profile
    {
        public UplataProfile()
        {
            CreateMap<Uplata, UplataDTO>();
            CreateMap<UplataDTO, Uplata>();
        }
    }
}
