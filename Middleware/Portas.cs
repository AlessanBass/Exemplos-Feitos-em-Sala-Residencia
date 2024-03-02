namespace Middleware;

public class Portas
{
    private readonly RequestDelegate _next;

    public Portas(RequestDelegate next){
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Passei pelas Portas \n");
        await _next.Invoke(context);
    }
}
 public static class PortasExtensions
   {
      public static IApplicationBuilder UseExampleMiddleware(this IApplicationBuilder builder)
      {
         return builder.UseMiddleware<Portas>();
      }
   }