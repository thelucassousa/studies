using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_modulo_01.funcoes
{
    internal class Exercicio_01
    {

        /*
         
        1- Crie um programa em C# que utilize uma Função chamada “ PrecoFinal ” que
        ajuste em 25% a mais do valor inicial dos produtos:
        ● Chocolate: 30
        ● Refrigerante: 50
        ● Bolo: 45
        ● Sorvete: 60
        ● Pão: 15
        exiba o resultado na tela.

         public static void Main(string[] args)
        {

            int chocolate = 30;
            int refrigerante = 50;
            int bolo = 45;
            int sorvete = 60;
            int pao = 15;


            Console.WriteLine("Olá, os produtos atualizados foram:");
            Console.WriteLine("\r\n 1 - Chocolate \r\n 2 - Refrigerante \r\n 3 - Bolo \r\n 4 - Sorvete \r\n 5 - Pão \r\n 6 - Todos");
            Console.Write("Qual produto você deseja verificar? ");
            int inpt = int.Parse(Console.ReadLine());

            switch (inpt)
            {
                case 1:
                    Console.WriteLine(PrecoFinal(chocolate, "Chocolate"));
                    break;
                case 2:
                    Console.WriteLine(PrecoFinal(refrigerante, "Refrigerante"));
                    break;
                case 3:
                    Console.WriteLine(PrecoFinal(bolo, "Bolo"));
                    break;
                case 4:
                    Console.WriteLine(PrecoFinal(sorvete, "Sorvete"));
                    break;
                case 5:
                    Console.WriteLine(PrecoFinal(pao, "Pao"));
                    break;
                case 6:
                    Console.WriteLine(PrecoFinal(chocolate, "Chocolate"));
                    Console.WriteLine(PrecoFinal(refrigerante, "Refrigerante"));
                    Console.WriteLine(PrecoFinal(bolo, "Bolo"));
                    Console.WriteLine(PrecoFinal(sorvete, "Sorvete"));
                    Console.WriteLine(PrecoFinal(pao, "Pão"));
                    break;

                default:
                    Console.WriteLine("Não identificado, por favor, tente novamente!");
                    break;

            }

            Console.ReadLine();

        }
        static string PrecoFinal (int prcFinal, string inptPdt)
        {
            int result = prcFinal + (prcFinal / 4);
            string outText = $"O preço atualizado de {inptPdt} é {result}";
            return outText;
        }
    }
         
         
         */

    }
}
