using System;
using System.Threading.Tasks;

namespace appconta
{
    class Program
    {
        static void Main(string[] args)
        {
            var contador = 0;
            var maximo = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;

            while(maximo == -1 || contador < maximo)
            {
                contador++;
                Console.WriteLine($"Contando... : {contador}");
                Task.Delay(1000).Wait();
            }
        }
    }
}
