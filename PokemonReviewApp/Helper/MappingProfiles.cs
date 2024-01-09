using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<PokemonModel, PokemonDto>();
            CreateMap<CategoryModel, CategoryDto>();
            CreateMap<CountryModel, CountryDto>();
            CreateMap<OwnerModel, OwnerDto>();
            CreateMap<ReviewModel, ReviewDto>();
            CreateMap<ReviewerModel, ReviewerDto>();

            CreateMap<CategoryDto, CategoryModel>();

        }
    }
}
