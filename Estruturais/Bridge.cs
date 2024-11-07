using System;

// Implementação: Define a interface para os tipos de pagamento
public interface IPaymentMethod
{
    void Pay(double amount);
}

// Implementação 1: Pagamento com Cartão de Crédito
public class CreditCardPayment : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Pagando {amount} com Cartão de Crédito.");
    }
}

// Implementação 2: Pagamento com PayPal
public class PayPalPayment : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Pagando {amount} com PayPal.");
    }
}

// Abstração: Processamento do pagamento
public abstract class PaymentProcessor
{
    protected IPaymentMethod paymentMethod;

    // Construtor
    protected PaymentProcessor(IPaymentMethod paymentMethod)
    {
        this.paymentMethod = paymentMethod;
    }

    // Método para processar o pagamento (abstração)
    public abstract void ProcessPayment(double amount);
}

// Abstração Concreta 1: Processador de pagamento normal
public class NormalPaymentProcessor : PaymentProcessor
{
    public NormalPaymentProcessor(IPaymentMethod paymentMethod) : base(paymentMethod) { }

    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Processando pagamento...");
        paymentMethod.Pay(amount);
    }
}

// Abstração Concreta 2: Processador de pagamento premium
public class PremiumPaymentProcessor : PaymentProcessor
{
    public PremiumPaymentProcessor(IPaymentMethod paymentMethod) : base(paymentMethod) { }

    public override void ProcessPayment(double amount)
    {
        // Aplicando um desconto de 10% para clientes premium
        double discountedAmount = amount * 0.9;
        Console.WriteLine("Processando pagamento para cliente premium...");
        Console.WriteLine($"Desconto de 10% aplicado. Valor final: {discountedAmount}");
        paymentMethod.Pay(discountedAmount);
    }
}

// Programa de Teste
public class Program
{
    public static void Main()
    {
        // Criando diferentes métodos de pagamento
        IPaymentMethod creditCard = new CreditCardPayment();
        IPaymentMethod paypal = new PayPalPayment();

        // Criando processadores de pagamento e associando o método de pagamento
        PaymentProcessor normalPayment1 = new NormalPaymentProcessor(creditCard);
        PaymentProcessor normalPayment2 = new NormalPaymentProcessor(paypal);

        // Criando processadores premium
        PaymentProcessor premiumPayment1 = new PremiumPaymentProcessor(creditCard);
        PaymentProcessor premiumPayment2 = new PremiumPaymentProcessor(paypal);

        // Processando pagamentos
        Console.WriteLine("Pagamento normal com Cartão de Crédito:");
        normalPayment1.ProcessPayment(100.0);  // Pagamento com Cartão de Crédito
        Console.WriteLine();

        Console.WriteLine("Pagamento normal com PayPal:");
        normalPayment2.ProcessPayment(200.0);  // Pagamento com PayPal
        Console.WriteLine();

        Console.WriteLine("Pagamento premium com Cartão de Crédito:");
        premiumPayment1.ProcessPayment(100.0);  // Pagamento premium com Cartão de Crédito
        Console.WriteLine();

        Console.WriteLine("Pagamento premium com PayPal:");
        premiumPayment2.ProcessPayment(200.0);  // Pagamento premium com PayPal
    }
}