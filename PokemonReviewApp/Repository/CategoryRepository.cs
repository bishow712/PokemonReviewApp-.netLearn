using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public bool CategoryExists(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public bool CreateCategory(CategoryModel category)
        {
            // Change tracker (Add, Updating, Modifying) (Connected(99%) or Disconnected State)
            // If disconnected, EntityState.Added
            _context.Add(category);
            //_context.SaveChanges();
            return Save();
        }

        public ICollection<CategoryModel> GetCategoriesFromDatabase()
        {
            return _context.Categories.ToList();
        }

        public CategoryModel GetCategory(int id)
        {
            return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
        }

        public CategoryModel GetCategory(string name)
        {
            return _context.Categories.Where(e => e.Name == name).FirstOrDefault();
        }

        public ICollection<PokemonModel> GetPokemonsByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
        }

        public bool Save()
        {
            // Convert to SQL and send to database what we gave to the context - SaveChanges
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }
    }
}
