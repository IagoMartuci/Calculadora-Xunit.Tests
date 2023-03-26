namespace Calculadora;
public class Operacoes
{
    public static void Soma()
    {
        Console.Clear();
        Console.WriteLine("SOMA");
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        CalculadoraService.Soma(num1, num2);
        Console.ReadKey();
    }

    public static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("SUBTRAÇÃO");
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        CalculadoraService.Subtracao(num1, num2);
        Console.ReadKey();
    }

    public static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("MULTIPLICAÇÃO");
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        CalculadoraService.Multiplicacao(num1, num2);
        Console.ReadKey();
    }

    public static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("DIVISÃO");
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        CalculadoraService.Divisao(num1, num2);
        Console.ReadKey();
    }

    public static void Sair()
    {
        Console.Clear();
        Thread.Sleep(500);
        Console.Write("Saindo");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.WriteLine(".");
        Thread.Sleep(1000);
        Console.WriteLine("Obrigado por utilizar o sistema!");
        Environment.Exit(0);
    }
}
