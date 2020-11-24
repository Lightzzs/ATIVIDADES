using System;

namespace ATIVIDADES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o Tipo de combustivel? G - Gasolina ou A - Álcool");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de litros que deseja abastecer");
            float litros = float.Parse(Console.ReadLine());
            float precoalcool = 4.9f;
            float precogasolina = 5.3f;
            float resultadodafuncao;

            switch (tipo.ToLower())
            {
                case "a":
                    resultadodafuncao = valoraserpago(litros,precoalcool,0.03f,0.05f);
                    Console.WriteLine($"O valor a ser pago é de: {resultadodafuncao}");
                    break;
                case "g":
                    resultadodafuncao = valoraserpago(litros,precogasolina,0.04f,0.06f);
                    Console.WriteLine($"O valor a ser pago é de: {resultadodafuncao}");
                    break;
                    default:
                        Console.WriteLine("Valor Invalido");
                        break;



                        static float valoraserpago(float litros, float preco, float perc1, float perc2){
                            float percentualdesconto;
                            if(litros <=20){
                                percentualdesconto = perc1;
                            }else{
                                percentualdesconto = perc2;
                            }
                            float totaldodesconto = (litros * preco) * percentualdesconto;
                            float valorbruto = (litros * preco);
                            float valorapagar = valorbruto - totaldodesconto;
                            return valorapagar;
                        }



                    
            }       
        }
    }
}
