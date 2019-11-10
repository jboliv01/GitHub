// Program 1B
// CIS 200-01
// Fall 2018
// Due: 10/3/2018
// D6818

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;


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
            Address a5 = new Address("Bob Saget", "1709 Broderick St.", "San Francisco",
                "CA", 90430); //Test Address 5
            Address a6 = new Address("Kobe Byrant", "4032 Salem St.", "Frankfort",
                "KY", 40500); //Test Address 6
            Address a7 = new Address("John Calipari", "3200 Rupp Ln.", "Lexington",
                "KY", 40045); //Test Address 7
            Address a8 = new Address("Kendrick Lamar", "12200 Corthouse pl.", "Nashville",
                "TN", 54200); //Test Address 8



            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a7, a6, 22, 23, 11,
                75, 22.0M);                                                         // Next Day Test object
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a8, a5, 52.6, 26.6, 70.0,
                85.5, TwoDayAirPackage.Delivery.Early);                             // Two Day Test object

           string NL = Environment.NewLine; //New Line shortcut

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(ndap2);

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }

            Pause();

            var partA = //sort by Destination Address Zip Code
                from p in parcels
                orderby p.DestinationAddress.Zip descending
                select p;

            var partB = //sort by CalcCost() method results in ascending order
                from p in parcels
                orderby p.CalcCost()
                select p;

            var partC = //sort by Type in ascending order and by CalcCost() results in descending order
                from p in parcels
                orderby p.GetType().ToString() ascending, p.CalcCost() descending
                select p;

            var partD = //filters AirPackage types from the list that are Heavy and orders them by weight in descending order
                from p in parcels
                let aP = p as AirPackage //instance variable casting parcel as an AirPackage
                where (aP != null) && aP.IsHeavy() //if aP is not null and aP is Heavy
                orderby aP.Weight descending 
                select aP;

            Console.WriteLine($"Part A: {NL}");
            foreach (var p in partA) //display part A results
            {

                Console.WriteLine($"{p.DestinationAddress}");
                Console.WriteLine();
            }


            Console.WriteLine($"Part B: {NL}"); 
            foreach (var p in partB) //display part B results
            {
                 
                Console.WriteLine($"Cost: {p.CalcCost()}");
                
            }
            Console.WriteLine();


            Console.WriteLine($"Part C: {NL}");
            foreach (var p in partC) //display part C results
            {
                Console.WriteLine($"Type: {p.GetType()}, Cost: {p.CalcCost()}");
                
            }
            Console.WriteLine();

            Console.WriteLine($"Part D: {NL}");
            foreach (var p in partD) //display part D results
            {

                Console.WriteLine($"Type: {p.GetType()}, Weight: {p.Weight}");
                
            }
            Console.WriteLine();



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
