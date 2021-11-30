﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario //Usar : diz que esta classe herda os campos da classe Funcionário
    {
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando Diretor!");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }


        public override double GetBonus()//override sobre poem a classe funcionário
        {
            return Salario + base.GetBonus();
        }
    }
}
 