using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using System.Diagnostics.Metrics;

namespace PokemonReviewApp.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _context;

        public OwnerRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateOwner(OwnerModel owner)
        {
            _context.Add(owner);

            return Save();
        }

        public bool DeleteOwner(OwnerModel owner)
        {
            _context.Remove(owner);
            return Save();
        }

        public OwnerModel GetOwnerFromId(int ownerId)
        {
            return _context.Owners.Where(p => p.Id == ownerId).FirstOrDefault();
        }

        public ICollection<OwnerModel> GetOwnerOfPokemon(int pokeId)
        {
            return _context.PokemonOwners.Where(p => p.Pokemon.Id == pokeId).Select(o => o.Owner).ToList();
        }

        public ICollection<OwnerModel> GetOwnersFromDatabase()
        {
            return _context.Owners.ToList();
        }

        public ICollection<PokemonModel> GetPokemonByOwner(int ownerId)
        {
            return _context.PokemonOwners.Where(o => o.Owner.Id == ownerId).Select(p => p.Pokemon).ToList();
        }

        public bool OwnerExists(int ownerId)
        {
            return _context.Owners.Any(p => p.Id == ownerId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool UpdateOwner(OwnerModel owner)
        {
            _context.Update(owner);

            return Save();
        }
    }
}
