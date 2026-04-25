// Interface principal do jogo


// Tela de boas vindas e cadastro do jogador

string nome = "";

string email = "";

string senha = "";




Console.WriteLine("Minecraft Zeus!");

Console.WriteLine("Digite seu nome: ");

nome = Console.ReadLine();

Console.WriteLine("Digite seu email: ");

email = Console.ReadLine();

Console.WriteLine("Digite sua senha: ");

senha = Console.ReadLine();

Console.WriteLine($"Olá, {nome}! Seja bem vindo ao Minecraft Zeus!");

// Menu principal do jogo

Console.WriteLine("Menu Principal:");

Console.WriteLine("1. Iniciar Jogo");

Console.WriteLine("2. Configurações");

Console.WriteLine("3. Sair");

Console.WriteLine("Digite a opção desejada: ");

const int opcao = 0;

opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Iniciando o jogo...");
        // Lógica para iniciar o jogo
        break;
    case 2:
        Console.WriteLine("Abrindo configurações...");
        // Lógica para abrir as configurações
        break;
    case 3:
        Console.WriteLine("Saindo do jogo...");
        // Lógica para sair do jogo

        Console.WriteLine("Jogo encerrado.");

Console.WriteLine("Obrigado por jogar Minecraft Zeus! Até a próxima!");

        break;
    default:
        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
        break;
}



