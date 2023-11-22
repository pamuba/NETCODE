using ServiceContract.DTO;

namespace ServiceContract
{
    /// <summary>
    /// Represents busssiness logic for implementing Country entity
    /// </summary>
    public interface ICountriesService
    {
        CountryResponse AddCountry(CountryAddRequest countryAddRequest);
        List<CountryResponse> GetAllCountries();

        CountryResponse? GetCountryByCountryID(Guid? countryID);
    }
}