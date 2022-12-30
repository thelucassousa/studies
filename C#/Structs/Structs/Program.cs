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
                this.nome = nome; // o que a linha está dizendo:l variavel do atributo recebe variavel do parametro - lembrando que quando estou chamando "nome" estou me referenciando ao parametro da função e não ao atributo, lembrar do escopo.
                this.preco = preco;//lembrando que precisa declarar todos e não somente um.
                this.peso = peso;
                this.marca = marca;
            }
        }


        static void Main(string[] args)
        {

            /*
            Produto computador = new Produto();
            computador.nome = "Ideaped 330s";
            computador.marca = "Lenovo";
            computador.peso = 1.2f;
            computador.preco = 3999f;
            */

            Produto computador = new Produto("Ideaped 330s", 3999f, 1.2f, "Lenovo");
        }
    }
}
