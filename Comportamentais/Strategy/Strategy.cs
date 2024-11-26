// Interface Strategy
public interface IImpostoStrategy
{
    decimal CalcularImposto(decimal valor);
}

// Concrete Strategy
public class ISSStrategy: IImpostoStrategy
{
    public decimal CalcularImposto(decimal valor)
     => valor * 0.1m; // retorna 10% de ISS
}

public class ICMSStrategy: IImpostoStrategy
{
    public decimal CalcularImposto(decimal valor)
     => valor * 0.18m; // retorna 18% de ICMS
}

// Contexto
public class CalculadoraDeImpostos
{
    private IImpostoStrategy _impostoStrategy;
    public CalculadoraDeImpostos(IImpostoStrategy impostoStrategy)
    {
        _impostoStrategy = impostoStrategy;
    }
    public void DefinirEstrategia(IImpostoStrategy impostoStrategy)
    {
        _impostoStrategy = impostoStrategy;
    }

    public decimal Calcular(decimal valor)
        => _impostoStrategy.CalcularImposto(valor);
    // retotorna o calculo do imposto  
}

class Program
{
    static void Main(string[] args)
    {
        var valor = 1000m;

        //Usando a stratégia ISS
        var calculadora =  new CalculadoraDeImpostos(new ISSStrategy());
        System.Console.WriteLine($"Imposto ISS: {calculadora.Calcular(valor)}");
    
        // Mudando para a estratégia ICMS
        calculadora.DefinirEstrategia(new ICMSStrategy());
        System.Console.WriteLine($"Imposto ICMS: {calculadora.Calcular(valor)}");
    }
}