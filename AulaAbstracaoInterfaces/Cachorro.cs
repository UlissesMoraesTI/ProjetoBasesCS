using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animais
{
    //Classe Cachorro Implementa a Interface IAnimal
    public class Cachorro : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("O cachorro faz au! au!");
        }
    }
}