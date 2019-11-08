// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/10/2017
//D6818

// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ", 
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);

            foreach(Parcel p in parcels)
            {
                Console.WriteLine(p);
            }
            // Display data
            Console.WriteLine("Program 1A - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Ground Package: ");
            Console.WriteLine();
            GroundPackage package1 = new GroundPackage(a2, a1, 1, 2, 2, 10);
            Console.WriteLine(package1);
            Console.WriteLine("--------------------");
            Console.WriteLine();

            Console.WriteLine("Next Day Air Package: ");
            Console.WriteLine();
            NextDayAirPackage air1 = new NextDayAirPackage(a2, a1, 30, 30, 40, 75, 10M);
            Console.WriteLine(air1);
            Console.WriteLine("--------------------");
            Console.WriteLine();


            Console.WriteLine("Two Day Air Package: ");
            Console.WriteLine();
            TwoDayAirPackage air2 = new TwoDayAirPackage(a2, a1, 30, 30, 40, 75, TwoDayAirPackage.Delivery.Saver);
            Console.WriteLine(air2);
            Console.WriteLine("--------------------");
            Console.WriteLine();

            Console.WriteLine("Another Two Day Air Package: ");
            Console.WriteLine();
            TwoDayAirPackage air3 = new TwoDayAirPackage(a2, a1, 30, 30, 40, 75, TwoDayAirPackage.Delivery.Saver);
            Console.WriteLine(air3);
            Console.WriteLine("--------------------");
            Console.WriteLine();



        }

    }
}
