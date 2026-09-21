var endpoint = "https://api.anthropic.com/v1/messages";
var token = "";
var modelo = "claude-sonnet-5";

var credenciais = new ApiKeyCredential(token);
var opcoes = new OpenAIClientOptions()
{
    //Correio do endpoint
    Endpoint = new Uri(endpoint)
}

//Mensageiro do Chatbot
var cliente = new OpenAIClient(credenciais, opcoes);
var chatCliente = cliente.GetChatClient(modelo);

var mensagens = new List<ChatMessage>();

mensagens.Add(new SystemChatMessage("Você é um professor de informática, tecnologia e programação. Responda de forma simples o que o usuário pedir."));

Console.WriteLine("Iniciando Chatbot...");

do
{
    Console.WriteLine("Digite uma mensagem para o Chatbot (ou 'sair' para encerrar):");

    string mensagem = Console.ReadLine();

    if (mensagem.ToLower() == "sair")
        break;

    //chamada ao Chatbot
    mensagens.Add(new UserChatMessage(mensagem));

    var resposta = await chatCliente.CompleteChatAsync(mensagens);
    var textoResposta = string.Concat(resposta.value.Content.Where(c => !string.IsNullOrWhiteSpace(c).Select(c => c.Text)));
    Console.WriteLine($"Chatbot respondeu: {textoResposta}");
} while (true);