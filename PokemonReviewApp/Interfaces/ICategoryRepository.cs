using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<CategoryModel> GetCategoriesFromDatabase();
        CategoryModel GetCategory(int id);
        CategoryModel GetCategory(string name);
        ICollection<PokemonModel> GetPokemonsByCategory(int categoryId);
        bool CategoryExists(int id);
        bool CreateCategory(CategoryModel category);
        bool Save();
    }
}
