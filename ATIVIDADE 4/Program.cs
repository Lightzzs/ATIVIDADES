using System;

namespace ATIVIDADE_4
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Deseja Saber a tabuada de qual numero?: ");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

            for (int contador = 10; contador > 0; contador--)
            {

                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
