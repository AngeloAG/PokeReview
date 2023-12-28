using AutoMapper;
using PokeReview.Dto;
using PokeReview.Models;

namespace PokeReview.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
