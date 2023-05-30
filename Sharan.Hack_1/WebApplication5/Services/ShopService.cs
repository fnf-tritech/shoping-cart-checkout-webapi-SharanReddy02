using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Services
{
    public class ShopService 
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<Checkout>();
        }

        public static void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
