using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaPolimorfismo
{
    public class Musico
    {
        public string Nome { get; set; }
        public string Instrumento { get; set; }

        public virtual void Tocar()
        {
            Console.WriteLine($"{Nome} está tocando {Instrumento}.");
        }
    }
}