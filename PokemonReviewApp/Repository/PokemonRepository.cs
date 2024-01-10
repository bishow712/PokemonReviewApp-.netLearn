using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        { 
            _context = context;
        }

        public PokemonModel GetPokemonById(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public PokemonModel GetPokemonByName(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonAverageRating(int pokeId)
        {
            var review = _context.Reviews.Where(p => p.Pokemon.Id == pokeId);

            if(review.Count() <= 0) { return 0; }

            return ((decimal)review.Sum(p => p.Rating) / review.Count());
        }

        public ICollection<PokemonModel> GetPokemonsFromDatabase() {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokeId)
        {
            return _context.Pokemon.Any(p => p.Id == pokeId);
        }

        public bool CreatePokemon(int ownerId, int categoryId, PokemonModel pokemon)
        {
            var pokemonOwnerEntity = _context.Owners.Where(p => p.Id == ownerId).FirstOrDefault();
            var pokemonCategoryEntity = _context.Categories.Where(p => p.Id == categoryId).FirstOrDefault();

            var pokemonOwner = new PokemonOwnerModel()
            {
                Owner = pokemonOwnerEntity,
                Pokemon = pokemon,
            };

            _context.Add(pokemonOwner);

            var pokemonCategory = new PokemonCategoryModel()
            {
                Category = pokemonCategoryEntity,
                Pokemon = pokemon,
            };

            _context.Add(pokemonCategory);

            _context.Add(pokemon);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool UpdatePokemon(int ownerID, int categoryId, PokemonModel pokemon)
        {
            _context.Update(pokemon);
            return Save();
        }
    }
}
