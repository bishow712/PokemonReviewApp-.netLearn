namespace PokemonReviewApp.Models
{
    public class PokemonCategoryModel
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public PokemonModel Pokemon { get; set; }
        public CategoryModel Category { get; set; }
    }
}
