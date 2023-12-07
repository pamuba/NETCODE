using AutoMapper;
using CoreWEBAPIDemos.Models.Domain;
using CoreWEBAPIDemos.Models.DTO;

namespace CoreWEBAPIDemos.Mappings
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();
        }
    }
 
}


