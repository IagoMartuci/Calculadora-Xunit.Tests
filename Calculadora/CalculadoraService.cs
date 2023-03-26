namespace Calculadora;
public class CalculadoraService
{
    public static int Soma(int n1, int n2)
    {
        int resultadoSoma = n1 + n2;
        ResultadoInt(resultadoSoma);
        return resultadoSoma;
    }

    public static int Subtracao(int n1, int n2)
    {

        int resultadoSubtracao = n1 - n2;
        ResultadoInt(resultadoSubtracao);
        return resultadoSubtracao;
    }

    public static double Multiplicacao(double n1, double n2)
    {
        double resultadoMultiplicacao = n1 * n2;
        ResultadoDouble(resultadoMultiplicacao);
        return resultadoMultiplicacao;
    }

    public static double Divisao(double n1, double n2)
    {
        double resultadoDivisao = n1 / n2;
        ResultadoDouble(resultadoDivisao);
        return resultadoDivisao;
    }

    public static void ResultadoInt(int resultado)
    {
        Console.WriteLine($"Resultado: {resultado}");
    }

    public static void ResultadoDouble(double resultado)
    {
        Console.WriteLine($"Resultado: {resultado}");
    }
}