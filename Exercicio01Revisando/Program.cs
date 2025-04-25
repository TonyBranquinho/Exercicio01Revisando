using Exercicio01Revisando;
using System;
using System.Globalization;

namespace MyApp
{ 
    // Calcula 3 propriedades geometricas de um retangulo que é definido pelo usuario.
    // 1. Área
    // 2. Perímetro
    // 3. Diagonal
    // O retângulo é definido pelo usuário através de sua largura e altura.
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Digite a largura e altura do retangulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}