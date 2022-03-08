using System;

namespace OrientacaoObjeto5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera CalculoEsfera = new Esfera();
            CalculoEsfera.raio = 3.5;
            Console.WriteLine($"A esfera tem o volume total de: {CalculoEsfera.volume():F2} metros cúbicos");
            Console.ReadKey();
        }
    }
}
