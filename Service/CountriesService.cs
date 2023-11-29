using Entities;
using ServiceContract;
using ServiceContract.DTO;

namespace Service
{
    public class CountriesService : ICountriesService
    {
        private readonly List<Country> _countries;

        public CountriesService(bool initialize = true) { 
            _countries = new List<Country>();
            if (initialize) {
                _countries.AddRange(new List<Country>()
                {
                    new Country()
                    {
                        CountryID = Guid.Parse
                    ("C989A57C-B8E4-4A7D-9A30-D2FFF358165B"),
                        CountryName = "USA"
                    },
                    new Country()
                    {
                        CountryID = Guid.Parse
                    ("689988FD-58FA-4262-BDC9-842ACD29B2B1"),
                        CountryName = "MEXICO"
                    },
                    new Country()
                    {
                        CountryID = Guid.Parse
                    ("A86FB1C7-4A09-4B92-9503-536990A6A97D"),
                        CountryName = "CANADA"
                    },
                    new Country()
                    {
                        CountryID = Guid.Parse
                    ("530A9718-716F-4B1F-9ACF-9DE52B7E84B2"),
                        CountryName = "CHINA"
                    },
                    new Country()
                    {
                        CountryID = Guid.Parse
                    ("D3A6525D-2532-49DC-B581-44F7572A6B1C"),
                        CountryName = "JAPAN"
                    }
                });
            }
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

            if (_countries.Where(temp => temp.CountryName == countryAddRequest.CountryName).Count() > 0) {
                throw new ArgumentException("Given country name already exists");
            }

            //4.
            Country country = countryAddRequest.ToCountry();

            country.CountryID = Guid.NewGuid();

            _countries.Add(country);

            return country.ToCountryResponse();
        }

        public List<CountryResponse> GetAllCountries()
        {
            return _countries.Select(country => country.ToCountryResponse()).ToList();

        }

        public CountryResponse? GetCountryByCountryID(Guid? countryID)
        {
            if (countryID == null)
                return null;

            Country? country_response_from_list = _countries.FirstOrDefault(temp => temp.CountryID == countryID);

            if (country_response_from_list == null)
                return null;

            return country_response_from_list.ToCountryResponse();
        }
    }
}