using System;
using System.Globalization;
namespace Csharp
{
    class Program{
        static void Main(string[] args)
        {
            /* PrecoFinal("Chocolate", 30.0f);
             PrecoFinal("Refrigerante", 50.0f);
             PrecoFinal("Bolo", 45.0f);
             PrecoFinal("Sorvete", 60.0f);
             PrecoFinal("Pão", 15.0f);

             static void PrecoFinal(string nome , float preco)
             {
                 float ValorFinal = preco + (preco / 4);

                 Console.WriteLine("O produto: " + nome + " custa: R$ " + ValorFinal.ToString("F1", CultureInfo.InvariantCulture));
             }*/

            const double PI = 3.14;

            double A = PI * Math.Pow(30, 2);

            Console.WriteLine("A pizza deve ser de Aproximente: " + A + "cm");
        }
    }
}