using System;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base;
            double Altura; 
            double Area;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o Valor da Base (cm): ");
            Base = double.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Digite o Valor da Altura (cm): ");
            Altura = double.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A Área do Triangulo é: {Area = Base * Altura / 2} (cm²)");
            Console.ResetColor();

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();

        }
    }
}
