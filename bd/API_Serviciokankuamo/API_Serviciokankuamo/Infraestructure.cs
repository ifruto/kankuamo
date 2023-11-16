using API_Serviciokankuamo.Repository;
using Microsoft.EntityFrameworkCore;

namespace API_Serviciokankuamo
{
    public static class Infraestructure
    {
        public static void AddRegisterServiciokankuamo_DbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ServicioKankuamoDB");
            var version = new MySqlServerVersion(new Version(8, 0, 25));

            services.AddDbContext<Serviciokankuamo_Context>(builder =>
            {
                builder.UseMySql(connectionString, version);
            }, ServiceLifetime.Transient);

            services.AddHttpClient();
            services.AddHttpContextAccessor();
            services.AddRepositories();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepositoryPort, UsuarioRepositoryAdapter>();
        }
    }
}
