using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _context;

        public ReviewerRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateReviewer(ReviewerModel reviewer)
        {
            _context.Reviewers.Add(reviewer);

            return Save();
        }

        // Include includes the navigation property (Include Reviews too)
        public ReviewerModel GetReviewerById(int reviewerId)
        {
            return _context.Reviewers.Where(r => r.Id == reviewerId).Include(e => e.Reviews).FirstOrDefault();
        }

        public ICollection<ReviewerModel> GetReviewersFromDatabase()
        {
            return _context.Reviewers.ToList();
        }

        public ICollection<ReviewModel> GetReviewsByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(p => p.Reviewer.Id == reviewerId).ToList();
        }

        public bool ReviewerExists(int reviewerId)
        {
            return _context.Reviewers.Any(p => p.Id == reviewerId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0 ? true : false;
        }

        public bool UpdateReviewer(ReviewerModel reviewer)
        {
            _context.Update(reviewer);

            return Save();
        }
    }
}
