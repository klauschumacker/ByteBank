﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonus gerenciador = new GerenciadorBonus();

            Funcionario yanne = new Funcionario(2000, "015.015.015-15");
            gerenciador.Registrar(yanne);
            yanne.Nome = "Yanne Lagarde";
            //yanne.CPF = ; 
            



            yanne.AumentarSalario(); // <<< AUMENTAR SALARIO
            Console.WriteLine("Novo salário da Yanne " + yanne.Salario);



            Console.WriteLine(Funcionario.TotalFuncionarios);



            Console.WriteLine(yanne.Nome);
            Console.WriteLine("Salário R$ " + yanne.Salario);
            Console.WriteLine("Total de bonus: " + yanne.GetBonus());
            
            //Console.WriteLine("Total de bonus: " + gerenciador.GetTotalBonus());

            //=================================================================

            Funcionario kolob = new Diretor("454.658.148-3");
            gerenciador.Registrar(kolob);

            kolob.Nome = "Kolob Lagarde";
            //kolob.CPF = ;
            



            kolob.AumentarSalario();  // <<< AUMENTAR SALARIO
            Console.WriteLine("Novo salário da Kolob " + kolob.Salario);



            Console.WriteLine(Funcionario.TotalFuncionarios);



            Console.WriteLine(kolob.Nome);
            Console.WriteLine("Salário R$ " + kolob.Salario);
            Console.WriteLine("Total de bonus: " + kolob.GetBonus());
            
            //Console.WriteLine("Total de bonus: " + gerenciador.GetTotalBonus());

            Console.ReadLine();
        }
    }
}