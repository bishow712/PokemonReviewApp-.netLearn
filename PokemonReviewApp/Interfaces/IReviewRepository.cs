using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<ReviewModel> GetReviewsFromDatabase();
        ReviewModel GetReviewById(int reviewId);
        ICollection<ReviewModel> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);
        bool CreateReview(ReviewModel review);
        bool UpdateReview(ReviewModel review);
        bool Save();
    }
}
