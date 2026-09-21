using System;

namespace AparelhosEletronicos;

public class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public bool EstaLigado { get; set; }

    public void Ligar()
    {
        EstaLigado = true;
        Console.WriteLine("O celular está ligado.");
    }

    public void Desligar()
    {
        EstaLigado = false;
        Console.WriteLine("O celular está desligado.");
    } 

    public void FazerLigacao(string numero)
    {
        if (EstaLigado)
        {
            Console.WriteLine("Ligando para " + numero + "...");
        }
        else
        {
            Console.WriteLine("O celular está desligado. Ligue-o antes de fazer uma ligação.");
        }
    }

}


