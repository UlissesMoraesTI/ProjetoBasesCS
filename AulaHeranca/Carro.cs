using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaHeranca
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }

        public void Ligar()
        {
            Console.WriteLine("O carro está ligado.");
        }

        public void Desligar()
        {
            Console.WriteLine("O carro está desligado.");
        }

        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando.");
        }

        public void Frear()
        {
            Console.WriteLine("O carro está freando.");
        }
    }
}