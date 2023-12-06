using Entities;
using ServiceContract;
using ServiceContract.DTO;

namespace Service
{
    public class CountriesService : ICountriesService
    {
        //private readonly List<Country> _countries;
        private readonly PersonsDbContext _db;

        public CountriesService(PersonsDbContext personsDbContext) { 
            _db = personsDbContext;
        }

        public CountryResponse AddCountry(CountryAddRequest countryAddRequest)
        {
            //1.
            if (countryAddRequest == null) { 
                throw new ArgumentNullException(nameof(countryAddRequest));
            }
            //2.
            if (countryAddRequest.CountryName == null) { 
                throw new ArgumentException(nameof(countryAddRequest.CountryName));
            }

            if (_db.Countries.Count(temp => temp
            .CountryName == countryAddRequest.CountryName) > 0) {
                throw new ArgumentException("Given country name already exists");
            }

            //4.
            Country country = countryAddRequest.ToCountry();

            country.CountryID = Guid.NewGuid();

            _db.Countries.Add(country);

            //_db.SaveChanges();

            return country.ToCountryResponse();
        }

        public List<CountryResponse> GetAllCountries()
        {
            return _db.Countries.Select(country => country.ToCountryResponse()).ToList();

        }

        public CountryResponse? GetCountryByCountryID(Guid? countryID)
        {
            if (countryID == null)
                return null;

            Country? country_response_from_list = _db.Countries
                .FirstOrDefault(temp => temp.CountryID == countryID);

            if (country_response_from_list == null)
                return null;

            return country_response_from_list.ToCountryResponse();
        }
    }
}