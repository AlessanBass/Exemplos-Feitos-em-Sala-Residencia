namespace Middleware;

public class ChassiM
{
    private readonly RequestDelegate _next;

    public ChassiM(RequestDelegate next){
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Passei no Chassi \n");
        await _next.Invoke(context);
    }
}
 public static class ChassiMExtensions
   {
      public static IApplicationBuilder UseExampleMiddleware(this IApplicationBuilder builder)
      {
         return builder.UseMiddleware<ChassiM>();
      }
   }