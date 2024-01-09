using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.PokemonOwners.Any())
            {
                var pokemonOwners = new List<PokemonOwnerModel>()
                {
                    new PokemonOwnerModel()
                    {
                        Pokemon = new PokemonModel()
                        {
                            Name = "Pikachu",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategoryModel>()
                            {
                                new PokemonCategoryModel { Category = new CategoryModel() { Name = "Electric"}}
                            },
                            Reviews = new List<ReviewModel>()
                            {
                                new ReviewModel { Title="Pikachu",Text = "Pickahu is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new ReviewerModel(){ FirstName = "Teddy", LastName = "Smith" } },
                                new ReviewModel { Title="Pikachu", Text = "Pickachu is the best a killing rocks", Rating = 5,
                                Reviewer = new ReviewerModel(){ FirstName = "Taylor", LastName = "Jones" } },
                                new ReviewModel { Title="Pikachu",Text = "Pickchu, pickachu, pikachu", Rating = 1,
                                Reviewer = new ReviewerModel(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new OwnerModel()
                        {
                            FirstName = "Jack",
                            LastName = "London",
                            Gym = "Brocks Gym",
                            Country = new CountryModel()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new PokemonOwnerModel()
                    {
                        Pokemon = new PokemonModel()
                        {
                            Name = "Squirtle",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategoryModel>()
                            {
                                new PokemonCategoryModel { Category = new CategoryModel() { Name = "Water"}}
                            },
                            Reviews = new List<ReviewModel>()
                            {
                                new ReviewModel { Title= "Squirtle", Text = "squirtle is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new ReviewerModel(){ FirstName = "Teddy", LastName = "Smith" } },
                                new ReviewModel { Title= "Squirtle",Text = "Squirtle is the best a killing rocks", Rating = 5,
                                Reviewer = new ReviewerModel(){ FirstName = "Taylor", LastName = "Jones" } },
                                new ReviewModel { Title= "Squirtle", Text = "squirtle, squirtle, squirtle", Rating = 1,
                                Reviewer = new ReviewerModel(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new OwnerModel()
                        {
                            FirstName = "Harry",
                            LastName = "Potter",
                            Gym = "Mistys Gym",
                            Country = new CountryModel()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                                    new PokemonOwnerModel()
                    {
                        Pokemon = new PokemonModel()
                        {
                            Name = "Venasuar",
                            BirthDate = new DateTime(1903,1,1),
                            PokemonCategories = new List<PokemonCategoryModel>()
                            {
                                new PokemonCategoryModel { Category = new CategoryModel() { Name = "Leaf"}}
                            },
                            Reviews = new List<ReviewModel>()
                            {
                                new ReviewModel { Title="Veasaur",Text = "Venasuar is the best pokemon, because it is electric", Rating = 5,
                                Reviewer = new ReviewerModel(){ FirstName = "Teddy", LastName = "Smith" } },
                                new ReviewModel { Title="Veasaur",Text = "Venasuar is the best a killing rocks", Rating = 5,
                                Reviewer = new ReviewerModel(){ FirstName = "Taylor", LastName = "Jones" } },
                                new ReviewModel { Title="Veasaur",Text = "Venasuar, Venasuar, Venasuar", Rating = 1,
                                Reviewer = new ReviewerModel(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new OwnerModel()
                        {
                            FirstName = "Ash",
                            LastName = "Ketchum",
                            Gym = "Ashs Gym",
                            Country = new CountryModel()
                            {
                                Name = "Millet Town"
                            }
                        }
                    }
                };
                dataContext.PokemonOwners.AddRange(pokemonOwners);
                dataContext.SaveChanges();
            }
        }
    }
}
