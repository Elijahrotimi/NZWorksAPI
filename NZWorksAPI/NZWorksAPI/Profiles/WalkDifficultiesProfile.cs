using AutoMapper;

namespace NZWorksAPI.Profiles
{
    public class WalkDifficultiesProfile : Profile
    {
        public WalkDifficultiesProfile()
        {
            CreateMap<Models.Domain.WalkDifficulty, Models.DTO.WalkDifficulty>()
                    .ReverseMap();
        }
    }
}
