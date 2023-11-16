namespace API_Serviciokankuamo
{
    public static class ConfigureCORS
    {
        public static void AddConfigureCORS(this IServiceCollection services, string FuerzaVallenataCORS)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(
                    name: FuerzaVallenataCORS,
                    policy =>
                    {
                        policy.WithOrigins("*")
                              .AllowAnyHeader()
                              .AllowAnyMethod()
                              .SetIsOriginAllowedToAllowWildcardSubdomains();
                    });
            });
        }
    }
}
