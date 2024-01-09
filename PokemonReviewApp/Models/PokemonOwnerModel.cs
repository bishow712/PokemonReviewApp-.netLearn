namespace PokemonReviewApp.Models
{
    public class PokemonOwnerModel
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }
        public PokemonModel Pokemon { get; set; }
        public OwnerModel Owner { get; set; }
    }
}
