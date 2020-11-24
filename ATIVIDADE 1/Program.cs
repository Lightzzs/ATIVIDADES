using System;

namespace ATIVIDADE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("em que ano você nasceu :");  
            int ano = int.Parse(Console.ReadLine());
                int idade = (2020 - ano);

            if(idade >=18){
            Console.WriteLine("Você pode votar!!");
            }
            else {
                Console.WriteLine("você não tem idade para votar!");
            }

        }
    }
}
