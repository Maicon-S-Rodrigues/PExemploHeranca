﻿using System;

namespace PExemploHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("FIAT", "500", 5, 4, 100000, "Branco");
            Console.WriteLine(veiculo);

            Moto moto = new Moto("Yamaha", "XJ6", 2, 2, 30000, "Vermelha", 600, true);
            Console.WriteLine(moto);
        }
    }
}
