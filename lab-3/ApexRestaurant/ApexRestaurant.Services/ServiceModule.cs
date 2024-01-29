using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;

namespace ApexRestaurant.Services
{
    public static class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
        }
    }
}