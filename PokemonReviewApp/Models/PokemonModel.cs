// using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class PokemonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<ReviewModel> Reviews { get; set; }
        public ICollection<PokemonOwnerModel> PokemonOwners { get; set; }
        public ICollection<PokemonCategoryModel> PokemonCategories { get; set; }
    }
}
