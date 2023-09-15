using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Intro_Csharp
{
    internal class Solution
    {
        public void Uppgift_1a()
        {
            Console.WriteLine("Vad heter du?");
            String namn = Console.ReadLine();
            Console.WriteLine("Hej " + namn + ". Varmt välkommen!");
            Console.WriteLine();

        }
        public void Uppgift_1b()
        {
            Console.WriteLine("ange bredd: ");
            double bredd = Convert.ToDouble(Console.ReadLine());
            double höjd = 5.4;
            double area = 25.92;
            Console.WriteLine();


        }
     
        public void Uppgift_1c()
        {
            double bredd;
            double höjd;
            // läs in tal som text
            Console.WriteLine("Ange triangelns bredd: ");
            String text = Console.ReadLine();
            // omvandla text till decimaltal
            bredd = Convert.ToDouble(text);
            Console.WriteLine("Ange triangelns Höjd: ");
            String text2 = Console.ReadLine();
             höjd = Convert.ToDouble(text2);

            double area;
            area = bredd * höjd / 2;
            Console.WriteLine("rektangel");
            Console.WriteLine("bredd :" + bredd);
            Console.WriteLine("höjd :" + höjd);
            Console.WriteLine("area :" + area);
            Console.WriteLine();





        }
        public void Uppgift_1d() {
            Console.WriteLine("Skriv in det första talet: ");
            string input1 = Console.ReadLine();
            int tal = Convert.ToInt32(input1);

            Console.WriteLine("Skriv in det andra talet: ");
            string input2 = Console.ReadLine();
            int tal2 = Convert.ToInt32(input2);
            double sum = tal + tal2;
            Console.WriteLine($"Summan av {input1} och {input2} är {sum}");

















        }
    }
}
