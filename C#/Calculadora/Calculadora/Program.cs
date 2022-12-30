using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Multiplicacao, Divisao, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {
            bool sair = false; //como while só funciona quando está verdadeiro, coloquei como verdadeira a variavel ao dizer:
            while (!sair) {//não false ou seja: verdadeiro
                Console.WriteLine("Seja bem-vindo ao Calc.");
                Console.WriteLine("1 - Soma\n2 - Subtracao\n3 - Multiplicacao\n4 - Divisao\n5 - Potencia\n6 - Raiz\n7 - Sair");
                Console.Write("Qual opção você deseja? ");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        sair = true;//como no início está ! = não, não verdadeiro é igual a false;
                        break;

                    default:
                        Console.WriteLine("\nOpção não identificada, aperte qualquer tecla para retornar ao Menu.");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();


            }

        }
        static void Soma()
        {
            Console.WriteLine($"\n{Menu.Soma}:");
            Console.Write("Escolha o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Escolha o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado de {a} + {b} é {resultado}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.WriteLine($"\n{Menu.Subtracao}:");
            Console.Write("Escolha o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Escolha o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado de {a} - {b} é {resultado}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine($"\n{Menu.Multiplicacao}:");
            Console.Write("Escolha o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Escolha o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado de {a} * {b} é {resultado}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine($"\n{Menu.Multiplicacao}:");
            Console.Write("Escolha o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Escolha o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado de {a} / {b} é {resultado}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine($"\n{Menu.Potencia}:");
            Console.Write("Qual o número base? ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Escolha o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado de {baseNum} elevado a {expo} é {resultado}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine($"\n{Menu.Raiz}:");
            Console.Write("A raiz de qual número você deseja? ");
            int numRaiz = int.Parse(Console.ReadLine());
            double  resultado = Math.Sqrt(numRaiz);
            Console.WriteLine($"A raiz de {numRaiz} é {resultado}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadLine();
        }
    }
}
