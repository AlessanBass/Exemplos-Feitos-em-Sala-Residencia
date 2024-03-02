using Modulo4.LinhaDeMontagem;
namespace Modulo4.LinhaDeMontagem;

public class Teste
{
    private readonly RequestDelegate _next;
    public Teste(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        context.Response.ContentType = "text/html; charset=utf-8";

        // Adiciona o cabeçalho personalizado com a hora e o IP
        context.Response.Headers.Add("X-Custom-Header", $"{DateTime.Now} - {context.Connection.RemoteIpAddress}");

        // Adiciona informações do cabeçalho no corpo
        await context.Response.WriteAsync($"Cabeçalho Personalizado: {DateTime.Now} - {context.Connection.RemoteIpAddress}<br>");

        // Adiciona informações da descrição no corpo
        await context.Response.WriteAsync(descricao.ToString());

        // Continua o pipeline
        await _next(context);
    }



}
