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
            

            public Produto(string nome, float preco, float peso, string marca)
            {
                this.nome = nome;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }
        }


        static void Main(string[] args)
        {

            //antes do construtor
            Produto ideaped330s = new Produto();
            ideaped330s.nome = "Ideaped 330s";
            ideaped330s.marca = "Lenovo";
            ideaped330s.peso = 1.2f;
            ideaped330s.preco = 3999f;

            //apos o construtor
            Produto inspironI15 = new Produto("Inspiron I15", 2999f, 1.6f, "Lenovo");
        }
    }
}
