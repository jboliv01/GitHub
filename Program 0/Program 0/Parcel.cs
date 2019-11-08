//D6818
//Program 0
//due September 10
//200-01
//Abstract Parcel class from which Letter and Package derive from, sets the foundation by creating a base constructor that accepts two addresses: origin and destination
//also includes an abstract CalcCost() method that can later be overriden and a ToString() that can also be overriden


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public abstract class Parcel //abstract base class 
    {
        

        public Parcel(Address originAddress, Address destinationAddress) //constructor accepting two parameters of type Address
        {
            OriginAddress = originAddress; //initializing OriginAddress Property
            DestinationAddress = destinationAddress; //initializing DestinationAddress Property

        }

        public Address OriginAddress { get; } //readonly auto-implemented property 
        public Address DestinationAddress { get; } //readonly auto-implemented property



        public abstract decimal CalcCost(); //abstract method that cannot contain a body

        public override string ToString() => //ToString() method overriden from base class(object) to print specified properties OriginAddress, DestinationAddress, and CalcCost() method with two decimal places of precision
            $"Origin Address: {Environment.NewLine}{OriginAddress}" +
            $"{Environment.NewLine}{Environment.NewLine}Destination Address: {Environment.NewLine}{DestinationAddress}" +
            $"{Environment.NewLine}Shipping Cost: {CalcCost():C}";

        
           

    }

}

