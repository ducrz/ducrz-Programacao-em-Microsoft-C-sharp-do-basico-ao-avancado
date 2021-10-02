﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Classes.ClassesAbstratas
{
    public class Moto : Veiculo
    {
        public Moto(string Marca, string Modelo, string Cor) : base(Marca, Modelo, Cor)
        {

        }

        public override void ProximaManutencao(int Dias)
        {
            Console.WriteLine($"Próxima Manutenção da Moto em dias: { Dias }");
        }
    }
}
