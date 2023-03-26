namespace Calculadora;
public class MenuClass
{
    public static void Menu()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("---| CALCULADORA |---");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Operacoes.Soma();
                    break;
                case 2:
                    Operacoes.Subtracao();
                    break;
                case 3:
                    Operacoes.Multiplicacao();
                    break;
                case 4:
                    Operacoes.Divisao();
                    break;
                case 0:
                    Operacoes.Sair();
                    break;
                default:
                    Menu();
                    break;
            }
        } while (opcao >= 1 && opcao <= 4);
    }
}
