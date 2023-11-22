using Microsoft.Extensions.DependencyInjection;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class DependencyRegistrationFactoryBoostrapper
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            // Register three implementations
            services.AddScoped<ICitiesService, CitiesService>();
            services.AddScoped<ICitiesService, LatinCitiesService>();
            services.AddTransient<IReminderServiceFactory, ReminderServiceFactory>();
        }

    }

    //---------------------------------------------------------------------------------
    // Factory Method for resolving the instance
    //---------------------------------------------------------------------------------
    public interface IReminderServiceFactory
    {
        ICitiesService GetInstance(string token);
    }

    public class ReminderServiceFactory : IReminderServiceFactory
    {
        private readonly IEnumerable<ICitiesService> reminderServices;

        public ReminderServiceFactory(IEnumerable<ICitiesService> reminderServices)
        {
            this.reminderServices = reminderServices;
        }

        public ICitiesService GetInstance(string token)
        {
            return token switch
            {
                "cities" => this.GetService(typeof(CitiesService)),
                "latin" => this.GetService(typeof(LatinCitiesService)),
                _ => throw new InvalidOperationException()
            }; ;
        }

        public ICitiesService GetService(Type type)
        {
            return this.reminderServices.FirstOrDefault(x => x.GetType() == type)!;
        }
    }
}
