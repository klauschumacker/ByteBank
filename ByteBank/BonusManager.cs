﻿using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class BonusManager
    {
        private double _totalBonus; //Aqui tornamos essa classe Privada
        public void Registrar(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }

        public double GetTotalBonus() //Este código é a forma de recuperar a informacao
                                      //porém não  consigo chamar ele lá em Program.cs, na linha 44!
        {
            return _totalBonus;
        }
    }
}
