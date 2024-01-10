using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<ReviewerModel> GetReviewersFromDatabase();
        ReviewerModel GetReviewerById(int reviewerId);
        ICollection<ReviewModel> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);
        bool CreateReviewer(ReviewerModel reviewer);
        bool UpdateReviewer(ReviewerModel reviewer);
        bool Save();
    }
}
