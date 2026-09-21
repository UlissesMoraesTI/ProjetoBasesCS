using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaHeranca
{
    public class CarroPremium : Carro
    {
        public void AbrirTetoSolar()
        {
            Console.WriteLine("O teto solar do carro premium foi aberto.");
        }
    }
}

