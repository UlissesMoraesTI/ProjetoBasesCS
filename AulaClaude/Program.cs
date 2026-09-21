using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

var apiKey = builder.Configuration["Anthropic:ApiKey"]
    ?? throw new InvalidOperationException("Configure Anthropic:ApiKey.");

builder.Services.AddHttpClient<AnthropicClient>(client =>
{
    client.BaseAddress = new Uri("https://api.anthropic.com/");
    client.DefaultRequestHeaders.Add("x-api-key", apiKey);
    client.DefaultRequestHeaders.Add("anthropic-version", "2023-06-01");
});

var app = builder.Build();

app.MapPost("/chat", async (ChatRequest req, AnthropicClient claude) =>
{
    try
    {
        var texto = await claude.PerguntarAsync(req.Mensagens);
        return Results.Ok(new { resposta = texto });
    }
    catch (HttpRequestException ex)
    {
        return Results.Problem(ex.Message, statusCode: (int?)ex.StatusCode ?? 502);
    }
});

app.Run();

// ---------- Tipos ----------

record Mensagem(string Role, string Content);
record ChatRequest(List<Mensagem> Mensagens);

class AnthropicClient(HttpClient http)
{
    public async Task<string> PerguntarAsync(List<Mensagem> mensagens)
    {
        var payload = new
        {
            model = "claude-sonnet-5",
            max_tokens = 1000,
            system = "Você é um assistente prestativo e objetivo.",
            messages = mensagens.Select(m => new { role = m.Role, content = m.Content })
        };

        var response = await http.PostAsJsonAsync("v1/messages", payload);

        if (!response.IsSuccessStatusCode)
        {
            var erro = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException(erro, null, response.StatusCode);
        }

        var json = await response.Content.ReadFromJsonAsync<JsonElement>();

        return json.GetProperty("content")[0]
                   .GetProperty("text")
                   .GetString() ?? string.Empty;
    }
}