using System;

namespace jurossimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o montante final de um investimento de juros simples.");
            double C=1200;
            double I=2;
            double T=15;
            double resultado=C * I;
            double resultado_1=resultado / 100;
            double resultado_2=resultado_1 * T;
            double J=resultado_2;
            double resultado2=C + J;
            Console.WriteLine($"{resultado_2:C}");
            Console.WriteLine($"{resultado2:C}");
        }
    }
}
        
    

