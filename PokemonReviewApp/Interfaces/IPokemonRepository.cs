using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        // Returning the list of Pokemons
        ICollection<PokemonModel> GetPokemonsFromDatabase();
        // Search by Pokemon Id
        PokemonModel GetPokemonById(int id);
        // Search by Pokemon Name
        PokemonModel GetPokemonByName(string name);
        // Calculate and get average rating given to that pokemon
        decimal GetPokemonAverageRating(int pokeId);
        // Check if that Pokemon exists
        bool PokemonExists(int pokeId);
        // Feeding a Pokemon to the database (POST)
        bool CreatePokemon(int ownerId, int categoryId, PokemonModel pokemon);
        bool UpdatePokemon(int ownerID, int categoryId, PokemonModel pokemon);
        bool Save();
    }
}
