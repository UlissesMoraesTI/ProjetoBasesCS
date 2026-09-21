using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaAbstracaoClasse
{
    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O cachorro faz au au!");
        }
    }
}