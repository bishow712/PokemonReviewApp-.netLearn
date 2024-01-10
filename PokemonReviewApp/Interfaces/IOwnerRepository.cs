using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<OwnerModel> GetOwnersFromDatabase();
        OwnerModel GetOwnerFromId(int ownerId);
        ICollection<OwnerModel> GetOwnerOfPokemon(int pokeId);
        ICollection<PokemonModel> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);
        bool CreateOwner(OwnerModel owner);
        bool UpdateOwner(OwnerModel owner);
        bool DeleteOwner(OwnerModel owner);
        bool Save();
    }
}
