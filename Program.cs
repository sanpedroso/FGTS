﻿using System;

namespace Datas
{
  class Program
    {
      static void Main(string[] args)
      {
        decimal salario, fgts;

        Console.Write("Salário (R$)..: ");
        salario = Convert.ToDecimal(Console.ReadLine());

        fgts = (salario / 100) * 8;

        Console.WriteLine($"\nFGTS: {fgts:C2}");
     }
  }
}

