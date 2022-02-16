using DIO_JogoRPG.src.Entities;
using System;
using static System.Console;

namespace DIO_JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Knight knight = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            WriteLine(knight.Attack());
            WriteLine(wizard.Attack());
        }
    }
}
