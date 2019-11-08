// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D6818

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a1, a2, 4.54M);
            Letter letter3 = new Letter(a2, a4, 7.76M);
            Letter letter4 = null;                                                 //Null test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a1, a2, 15, 11, 6, 13.5);
            GroundPackage gp3 = new GroundPackage(a4, a1, 20, 14, 9, 16.7);
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a2, a4, 13, 22, 55,    // Next Day test object
               55, 10.50M);

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a3, a1, 44.5, 55.5, 30.0, // Two Day test object
              85.5, TwoDayAirPackage.Delivery.Early);


            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(ndap2);
            parcels.Add(letter2);
            parcels.Add(tdap2);
            parcels.Add(letter3);
            parcels.Add(gp3);
            parcels.Add(letter4);

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            Console.WriteLine();
            Console.WriteLine("Descending Zip Order: ");
            parcels.Sort(new DescendingZipOrder()); //sort, using specified comparer class DescendingZipOrder
            foreach (Parcel p in parcels) //print list
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            Console.WriteLine();
            Console.WriteLine("Ascending Cost Order: ");
            parcels.Sort(new AscendingCostOrder()); //sort, using specified comparer class AscendingCostOrder
            foreach (Parcel p in parcels) //print list
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            Console.WriteLine();
            Console.WriteLine("Ascending Parcel Type/Descending Cost Order: ");
            parcels.Sort(new AscendingParcelSort()); //sort, using specified comparer class AscendingParcelSort
            foreach (Parcel p in parcels) //print list
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
                
            }


        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
