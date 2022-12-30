using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {

        struct Produto {

            public string nome;
            public float peso;
            public float preco;
            public string marca;
                
        }


        static void Main(string[] args)
        {
            Produto bola = new Produto(); //chamando a estrutura;
            bola.nome = "MyBol";
            bola.marca = "Nike";
        }
    }
}
