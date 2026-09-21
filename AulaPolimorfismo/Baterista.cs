using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaPolimorfismo
{
    public class Baterista : Musico
    {
        public override void Tocar()
        {
            Console.WriteLine($"{Nome} está arrasando na bateria!");
        }   
    }
}