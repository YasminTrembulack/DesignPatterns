public class Singleton
{
    // A variável estática que armazenará a instância única da classe
    private static Singleton _instance;

    // O construtor privado impede que instâncias da classe sejam criadas de fora
    private Singleton() =>
        Console.WriteLine("Instância do Singleton criada!");
   
    // A propriedade que permite acessar a instância única
    public static Singleton Instance
    {
        get
        {
            // Se _instance for null, cria uma nova instância do Singleton
            // Caso contrário, retorna a instância existente
            return _instance ?? (_instance = new Singleton());
        }
    }

    // Um método de exemplo para mostrar que a instância está funcionando
    public void ShowMessage() =>
        Console.WriteLine("Método do Singleton chamado!");
}


class Program
{
    static void Main(string[] args)
    {
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;

        // Verifica se ambas as variáveis referenciam a mesma instância
        Console.WriteLine(s1 == s2 ? "Ambas são a mesma instância." : "São instâncias diferentes.");

        s1.ShowMessage();
        s2.ShowMessage();
    }
}
