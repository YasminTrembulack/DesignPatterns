using System;

public class Light
{
    public void On() => Console.WriteLine("Light is on.");
    public void Off() => Console.WriteLine("Light is off.");
}

public class AirConditioner
{
    public void On() => Console.WriteLine("Air Conditioner is on.");
    public void Off() => Console.WriteLine("Air Conditioner is off.");
}

public class Computer
{
    public void On() => Console.WriteLine("Computer is on.");
    public void Off() => Console.WriteLine("Computer is off.");
}

public class HomeOfficeFacade
{
    private Light _light;
    private AirConditioner _airConditioner;
    private Computer _computer;

    public HomeOfficeFacade(Light light, AirConditioner airConditioner, Computer computer)
    {
        _light = light;
        _airConditioner = airConditioner;
        _computer = computer;
    }

    // Método para ligar o escritório
    public void StartWorkDay()
    {
        Console.WriteLine("Starting the workday...");
        _light.On();
        _airConditioner.On();
        _computer.On();
    }

    // Método para desligar o escritório
    public void EndWorkDay()
    {
        Console.WriteLine("Ending the workday...");
        _light.Off();
        _airConditioner.Off();
        _computer.Off();
    }
}

public class Program
{
    public static void Main()
    {
        // Componentes individuais do sistema
        var light = new Light();
        var airConditioner = new AirConditioner();
        var computer = new Computer();

        // Criando a Facade
        var homeOffice = new HomeOfficeFacade(light, airConditioner, computer);

        // Usando a Facade para iniciar o dia de trabalho
        homeOffice.StartWorkDay();

        // Usando a Facade para terminar o dia de trabalho
        homeOffice.EndWorkDay();
    }
}
