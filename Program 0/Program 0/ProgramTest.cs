//D6818
//Program 0
//due September 10
//200-01
//Test Program that instantiates the classes and prints the values of each class in a List using a foreach loop
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_0
{
    class ProgramTest
    {
        static void Main()
        {
            Address add1 = new Address("Kim", "10123 Brookgreen rd.","10403 Heldway dr.", "Louisville", "Kentucky", 40223); //instantiate an instance of the Address class
            Address add2 = new Address("Jonah", "90210 Silvershells dr.", "Destin", "Florida", 100); //instantiate an instance of the Address class using overloaded constructor
            Address add3 = new Address("Drue", "12433 Coachouse pl.","14430 Lyndon ct.", "Nashville", "Tennesse", 40345); //instantiate an instance of the Address class
            Address add4 = new Address("Jenna", "13002 Rupp ln.", "Lexington", "Kentucky", 40446); //instantiate an instance of the Address class using overloaded constructor

            Letter letter1 = new Letter(add1, add2, 100.526M); //instantiate an instance of the Letter class
            Letter letter2 = new Letter(add3, add4, 25.99M); //instantiate another instace of the Letter class
            Letter letter3 = new Letter(add4, add2, 56.35M); //instantiate a third instance of the Letter class


            List<Parcel> mylist = new List<Parcel> //instantiating memory for a List containing Parcel objects
            (new Parcel[] { letter1, letter2, letter3 });

            foreach(Parcel letters in mylist) //for every Parcel object in mylist, print string representation of each letter object
            {
                WriteLine($"{letters}{Environment.NewLine}");
            }

            

        }
        
    }
}
