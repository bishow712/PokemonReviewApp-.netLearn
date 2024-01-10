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
        bool CreateCountry(CountryModel country);
        bool UpdateCountry(CountryModel country);
        bool Save();
    }
}
