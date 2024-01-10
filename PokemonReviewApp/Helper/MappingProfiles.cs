using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // For GET
            CreateMap<PokemonModel, PokemonDto>();
            CreateMap<CategoryModel, CategoryDto>();
            CreateMap<CountryModel, CountryDto>();
            CreateMap<OwnerModel, OwnerDto>();
            CreateMap<ReviewModel, ReviewDto>();
            CreateMap<ReviewerModel, ReviewerDto>();

            // For POST
            CreateMap<CategoryDto, CategoryModel>();
            CreateMap<CountryDto, CountryModel>();
            CreateMap<OwnerDto, OwnerModel>();
            CreateMap<PokemonDto, PokemonModel>();
            CreateMap<ReviewDto, ReviewModel>();
            CreateMap<ReviewerDto, ReviewerModel>();
        }
    }
}
