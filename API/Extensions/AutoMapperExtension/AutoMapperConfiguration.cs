using System.Reflection;

namespace API.Extensions.AutoMapperExtension
{
    public static class AutoMapperConfiguration
    {
        public static void AutoMapperConfig(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.Load("Core"));
        }
    }
}
