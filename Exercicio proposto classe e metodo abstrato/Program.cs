using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of payers: ");
            int x = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for(int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data");
                Console.Write("Individual or Company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Incoming: $ ");
                double anualIncoming = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(type == 'i')
                {
                    Console.Write("Helth Expeditures: $ ");
                    double helth = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncoming, helth));
                }
                else
                {
                    Console.Write("Employees number: ");
                    int number = int.Parse(Console.ReadLine());
                    list.Add (new Company(name, anualIncoming, number));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double total = 0;
            foreach(TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + " : $" + taxPayer.AnualTaxes().ToString("F2",CultureInfo.InvariantCulture));
                total += taxPayer.AnualTaxes();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES : S " + total.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
