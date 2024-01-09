using Microsoft.AspNetCore.Mvc;
using Moq;
using PokemonReviewApp.Controllers;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace pokemontest;

[TestClass]
public class PokemonControllerTests
{
    Mock<IPokemonRepository> mockPokemonRepo = new Mock<IPokemonRepository>();

    [TestMethod]
    public void GetPokemons_Returns_OkObjectResult_WhenDatabaseFetchSucceeds()
    {
        mockPokemonRepo.Setup(repo => repo.GetPokemonsFromDatabase())
               .Returns(new List<PokemonModel>());

         var pokemonController = new PokemonController(mockPokemonRepo.Object);

        Assert.IsInstanceOfType<OkObjectResult>(pokemonController.GetPokemons());
    }
}