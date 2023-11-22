using ServiceContracts;

namespace Services
{
    public class CitiesService :ICitiesService, IDisposable
    {
        private List<string> _cities;

        public Guid _serviceInstanceId;

        public Guid ServiceInstanceId
        {
            get { 
                return _serviceInstanceId;
            }
        }

        public CitiesService() {

            _serviceInstanceId = Guid.NewGuid();

            _cities = new List<string>()
            {
                "London",
                "Paris",
                "New York",
                "Tokyo",
                "Rome"
            };
            //TO DO: Add code to open  a connection
        }


        public List<string> GetCities() {
            return _cities;
        }

        public void Dispose()
        {
            //TO DO: add code to close the connection
        }
    }
}