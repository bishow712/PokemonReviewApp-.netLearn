namespace PokemonReviewApp.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public ReviewerModel Reviewer { get; set; }
        public PokemonModel Pokemon { get; set; }
    }
}
