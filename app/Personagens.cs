// Personagens do jogo


public class Personagens
{
    public string Nome { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; }
    public int Vida { get; set; }
    public int Forca { get; set; }
    public int Agilidade { get; set; }
    public int Inteligencia { get; set; }

    public Personagens(string nome, string classe, int nivel, int vida, int forca, int agilidade, int inteligencia)
    {
        Nome = nome;
        Classe = classe;
        Nivel = nivel;
        Vida = vida;
        Forca = forca;
        Agilidade = agilidade;
        Inteligencia = inteligencia;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Classe: {Classe}");
        Console.WriteLine($"Nível: {Nivel}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Força: {Forca}");
        Console.WriteLine($"Agilidade: {Agilidade}");
        Console.WriteLine($"Inteligência: {Inteligencia}");
    }
}