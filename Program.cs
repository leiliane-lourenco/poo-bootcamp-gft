using POOBootcampGFT.src;
using System;

namespace POOBootcampGFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");
            BlackWizard blackWizard = new BlackWizard("Mago Negro", 23, "BlackWizard");

            Console.WriteLine(arus.ToString());
            Console.WriteLine(arus.Attack());
            Console.WriteLine();
            Console.WriteLine(wizard.ToString()); 
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine();
            Console.WriteLine(blackWizard.ToString()); 
            Console.WriteLine(blackWizard.Attack(2));
            Console.WriteLine(blackWizard.Attack(7));

        }
    }
}
