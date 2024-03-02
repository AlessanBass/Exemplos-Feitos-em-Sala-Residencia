namespace Middleware;

public class Motor
{
    private readonly RequestDelegate _next;

    public Motor(RequestDelegate next){
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Passei no Motor \n");
        await _next.Invoke(context);
    }
}
 public static class MotorExtensions
   {
      public static IApplicationBuilder UseExampleMiddleware(this IApplicationBuilder builder)
      {
         return builder.UseMiddleware<Motor>();
      }
   }