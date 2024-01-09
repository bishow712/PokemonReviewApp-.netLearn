using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<CountryModel> GetCountriesFromDatabase();
        CountryModel GetCountryById(int id);
        CountryModel GetCountryByOwner(int ownerId);
        ICollection<OwnerModel> GetOwnersFromCountry(int countryId);
        bool CountryExists(int id);

    }
}
