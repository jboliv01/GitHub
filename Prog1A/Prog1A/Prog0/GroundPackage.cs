// Program 1A
// CIS 200-01
// Fall 2018
// Due: 9/10/2017
//D6818

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1A
{

    public class GroundPackage:Package
    {

        const int ZONE_DISTANCE_DIV = 10000; //constant integer holding the dividend for the zone distance equation

        //Precondition: none 
        //Postcondition: creates a ground package object with the data specified
        public GroundPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight): base(originAddress, destAddress, length, width, height, weight)
        {

        }

        public int ZoneDistance
        {
            //Precondition: none
            //Postcondition: returns the absolute value of the Zone Distance
           get
            {
                return Math.Abs(OriginAddress.Zip - DestinationAddress.Zip)/ZONE_DISTANCE_DIV;
            }              
        }

        //Precondition: none
        //Postcondition: returns the decimal value for the cost of the package
        public override decimal CalcCost()
        {
            return .20M * ((decimal)Length + (decimal)Width + (decimal)Height) + 0.5M * ((decimal)ZoneDistance + 1) * ((decimal)Weight);
        }

        //Precondition: none
        //Postcondition: returns the string value for a Ground Package object, includes Zone Distance.
        public override string ToString()
        {
            string NL = Environment.NewLine; //NewLine shortcut
            return base.ToString() + $"{NL}Zone Distance: {ZoneDistance}";
        }

    }
}
