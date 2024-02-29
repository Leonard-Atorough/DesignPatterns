using OptionsPattern.Models;

namespace OptionsPattern.Helpers
{
    public static class ProgramHelpers
    {

        public static IServiceCollection GetConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ComplexOptions>(configuration.GetSection("ComplexOptions"));

            return services;
        }
    }
}