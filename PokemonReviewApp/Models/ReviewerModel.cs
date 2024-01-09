namespace PokemonReviewApp.Models
{
    public class ReviewerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<ReviewModel> Reviews { get; set; }
    }
}
