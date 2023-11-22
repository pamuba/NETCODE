using ServiceContracts;


namespace Services
{
    public class LatinCitiesService: ICitiesService
    {
        private List<string> _cities;

        public LatinCitiesService()
        {
            _cities = new List<string>()
            {
                "Sao Paulo",
                "B Aries",
                "Santiago",
                "Lima",
                "Brazil"
            };
        }

        public Guid _serviceInstanceId;

        public Guid ServiceInstanceId
        {
            get
            {
                return _serviceInstanceId;
            }
        }

        public List<string> GetCities()
        {
            return _cities;
        }
    }
}
