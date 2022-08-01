using AutoMapper;

namespace NZWalks.Api.Profiles
{
    public class WalkProfile : Profile
    {
        public WalkProfile()
        {
            CreateMap<Models.Domain.Walk, Models.DTO.Walk>()
           .ReverseMap();

            //you can create it in different .cs as well
            CreateMap<Models.Domain.WalkDifficulty, Models.DTO.WalkDifficulty>()
                .ReverseMap();
        }
    }
}
