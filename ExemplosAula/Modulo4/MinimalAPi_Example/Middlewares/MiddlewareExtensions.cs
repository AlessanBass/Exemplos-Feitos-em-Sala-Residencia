using Modulo4.LinhaDeMontagem;

namespace Middleware.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseAddChassiMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<AddChassiMiddleware>();
        }

        public static IApplicationBuilder UseAddMotorMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<AddMotorMiddleware>();
        }

        public static IApplicationBuilder UseAddTeste(this IApplicationBuilder app)
        {
            return app.UseMiddleware<Teste>();
        }

       /*  public static IApplicationBuilder UseAddDuration(this IApplicationBuilder app)
        {
            return app.UseMiddleware<Duration>();
        } */

    }
}
