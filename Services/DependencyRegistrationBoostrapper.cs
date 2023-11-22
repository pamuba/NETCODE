using Microsoft.Extensions.DependencyInjection;
using ServiceContracts;


namespace Services
{
    //Func<in,out>
    public delegate ICitiesService CitiesServiceResolver(string identifier);


    public static class DependencyRegistrationBoostrapper
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
           
            services.AddTransient<CitiesService>();
            services.AddTransient<LatinCitiesService>();

            
            services.AddTransient<CitiesServiceResolver>(serviceProvider => token =>
            {
                // hardcoded strings can be extracted as constants
                return token switch
                {
                    "cities" => serviceProvider.GetService<CitiesService>(),
                    "latin" => serviceProvider.GetService<LatinCitiesService>(),
                    _ => throw new InvalidOperationException()
                };
            });
        }
    }
}
