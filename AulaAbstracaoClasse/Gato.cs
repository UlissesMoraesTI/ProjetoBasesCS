using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaAbstracaoClasse
{
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O gato faz miau! miau!");
        }
    }
}