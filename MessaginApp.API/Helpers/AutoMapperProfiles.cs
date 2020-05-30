using System.Linq;
using AutoMapper;
using MessaginApp.API.Dtos;
using MessaginApp.API.Models;

namespace MessaginApp.API.Helpers
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles(){

            CreateMap<User,UserForListDto>().
            ForMember(dest => dest.PhotoUrl, opt => 
                opt.MapFrom(src => src.Photos.FirstOrDefault(p=>p.IsMain).Url))
            .ForMember(dest =>dest.Age, opt =>opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User,UserForDetailedDto>().ForMember(dest => dest.PhotoUrl, opt => 
                opt.MapFrom(src => src.Photos.FirstOrDefault(p=>p.IsMain).Url))
            .ForMember(dest =>dest.Age, opt =>opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo,PhotoForDetailDto>();
            
        }
    }
}