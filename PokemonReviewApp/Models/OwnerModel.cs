namespace PokemonReviewApp.Models
{
    public class OwnerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }
        public CountryModel Country { get; set; }
        public ICollection<PokemonOwnerModel> PokemonOwners { get; set; }
    }
}
