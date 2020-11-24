using System;

namespace ATIVIDADE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float discount1 = 0.02f;
            float discount2 = 0.03f;
            float discount3 = 0.05f;

            Console.WriteLine("Bem vindo ao Mercado Online, escreva o nome do produto: ");
            string produto = Console.ReadLine();

            Console.WriteLine($"quantas unidades do(a) {produto} você comprou: ");
            int unidades = int.Parse(Console.ReadLine());

            Console.WriteLine($"valor unitário do(a) {produto}: ");
            float preco = float.Parse(Console.ReadLine());

            if(unidades <= 5){

                float total = (unidades * preco);
                float desconto = (total * discount1);
                float final = (total - desconto);

                Console.WriteLine($"com o desconto é de {final}");

            }else if(unidades >5 || unidades <=10){

                float total = (unidades * preco);
                float desconto = (total * discount2);
                float final = (total - desconto);

                Console.WriteLine($"com o desconto é de {final}");
                
            }else{

                float total = (unidades * preco);
                float desconto = (total * discount3);
                float final = (total - desconto);

                Console.WriteLine($"com o desconto é de {final}"); 
        
            }
        }
    }
}
