using System;
using System.Collections.Generic;

namespace tuplasExemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDoBanco = new List<string>() { "Informação-1", "Informação-2" };
            int idBanco = 154987;
            DateTime dataBanco = DateTime.Now;

            var tuplaExemplo1 = new Tuple<int, List<string>, DateTime>(idBanco, listaDoBanco, dataBanco);
            Console.WriteLine("Exemplo 1");
            Console.WriteLine(tuplaExemplo1.Item1);
            Console.WriteLine(tuplaExemplo1.Item2[0]);
            Console.WriteLine(tuplaExemplo1.Item2[1]);            
            Console.WriteLine(tuplaExemplo1.Item3);

            (int, List<string>, DateTime) tuplaExemplo2 = (idBanco, listaDoBanco, dataBanco);
            Console.WriteLine("Exemplo 2");
            Console.WriteLine(tuplaExemplo2.Item1);
            Console.WriteLine(tuplaExemplo2.Item2[0]);
            Console.WriteLine(tuplaExemplo2.Item2[1]);            
            Console.WriteLine(tuplaExemplo2.Item3);

            var tuplaExemplo3 = Tuple.Create<int, List<string>, DateTime>(idBanco, listaDoBanco, dataBanco);
            Console.WriteLine("Exemplo 3");
            Console.WriteLine(tuplaExemplo3.Item1);
            Console.WriteLine(tuplaExemplo3.Item2[0]);
            Console.WriteLine(tuplaExemplo3.Item2[1]);          
            Console.WriteLine(tuplaExemplo3.Item3);
        }
    }
}
