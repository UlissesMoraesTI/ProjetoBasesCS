using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaHeranca
{
    public class CarroEsportivo : Carro
    {
        public void AtivarTurbo()
        {
            Console.WriteLine("O turbo do carro esportivo foi ativado.");
        }
    }
}