using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Data_Structures;

class Program
{
    static void Main(string[] args)
    {
        Calculator();
    }

    public static void Calculator()
    {
        //Basic Calculator
        Menu();
    }
    public static void Sub()
    {

        (int valueA, int valueB) = Massage();

        int resp;
        resp = valueA - valueB;
        Console.WriteLine("RESULTADO: "+valueA + " - " + valueB + " = " + resp);
        Console.WriteLine("\n");
    }

    public static void Sum()
    {

        (int valueA, int valueB) = Massage();
        int resp;
        resp = valueA + valueB;
        Console.WriteLine("RESULTADO: "+valueA + " + " + valueB + " = " + resp);
        Console.WriteLine("\n");
    }

    public static void Div()
    {


        (int valueA, int valueB) = Massage();
        int resp;
        resp = valueA / valueB;
        Console.WriteLine("RESULTADO: "+valueA + " / " + valueB + " = " + resp);
        Console.WriteLine("\n");
    }

    public static void Mult()
    {

        (int valueA, int valueB) = Massage();

        int resp;
        resp = valueA * valueB;
        Console.WriteLine("RESULTADO: "+valueA + " * " + valueB + " = " + resp);
        Console.WriteLine("\n");
    }

    public static (int, int) Massage()
    {
        Console.WriteLine("Digite dois valores: ");
        Console.WriteLine("Valor A: ");
        int valueA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Valor B: ");
        int valueB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");

        return (valueA, valueB);
    }

    public static void Menu()
    {
        int option = -1;
        while (option != 0)
        {

            Console.WriteLine("Operações disponíveis. 0 para sair do programa.");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite o número da operação desejada: ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (option)
            {
                case 1:
                    Sum();
                    break;

                case 2:
                    Sub();
                    break;

                case 3:
                    Mult();
                    break;

                case 4:
                    Div();
                    break;

                case 0:
                    Console.WriteLine("Fim do programa!");
                    Console.WriteLine("\n");
                    break;
            }
        }
    }
}
