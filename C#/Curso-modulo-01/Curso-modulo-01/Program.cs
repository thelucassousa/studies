﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_modulo_01
{
    //Aula atual: sempre;
    internal class Program
    {
       public static void Main(string[] args)
        {
            int contador = 100;
            do
            {
                Console.WriteLine($"número: {contador}");
            } while (contador < 10);


            Console.ReadLine();
        }
    }
}

