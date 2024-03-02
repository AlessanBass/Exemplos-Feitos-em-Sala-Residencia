using Modulo4.LinhaDeMontagem;
namespace Modulo4.LinhaDeMontagem;

public class Duration
{
    private readonly RequestDelegate _next;

    public Duration(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        // Registra o tempo de início da requisição
        var startTime = DateTime.Now;

        // Executa o próximo middleware no pipeline
        await _next(context);

        // Calcula a duração da requisição
        var duration = DateTime.Now - startTime;

        // Adiciona o cabeçalho com a duração da requisição em milissegundos
        context.Response.Headers.Add("X-Request-Duration", $"{duration.TotalMilliseconds} ms");

        await context.Response.WriteAsync($"Duration: {duration.TotalMilliseconds} ms");
        // Adiciona informações da descrição no corpo
        await context.Response.WriteAsync(descricao.ToString());

        // Continua o pipeline
        await _next(context);
    }
}
