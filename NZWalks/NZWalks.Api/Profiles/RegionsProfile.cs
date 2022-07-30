using AutoMapper;

namespace NZWalks.Api.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ReverseMap();
            //above syntax -- CreateMap<source,destination>();

            // Now if suppose the destination/source contains property name mismatch 
            // then you can specify like this: (assuming region Id in the source is named as RegionId
            //                                   and as Id in the destination)

            // CreateMap<Models.Domain.Region, Models.DTO.Region>()
            //   .ForMember(dest => dest.id, options => options.MapFrom(src => src.RegionId));

            // if in future you want to map from dest to source you can you as shown below:
            // CreateMap<Models.Domain.Region, Models.DTO.Region>()
            // .ReverseMap();
        }
    }
}
