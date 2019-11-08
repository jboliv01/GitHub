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
    public abstract class AirPackage:Package
    {
        const int HEAVY_PACKAGE = 75; //constant value defining the minimum weight of a heavy package
        const int LARGE_PACKAGE = 100; //constant value defining the minimum inches in a large package


        //Precondition: none
        //Postcondition: creates an AirPackage object with the specified values
        public AirPackage(Address originAddress, Address destAddress, double length, double width,
            double height, double weight) : base(originAddress, destAddress, length, width, height, weight)
        {

        }

        //Precondition: none
        //Postcondition: returns the bool value T/F if the Weight property is >= 75
        public bool IsHeavy()
        {
            if (Weight >= HEAVY_PACKAGE)
            {
                return true;
            }
            else
                return false;
        }

        //Precondition: none
        //Postcondition: returns the bool value T/F if the sum of the Length, width, height >= 100
        public bool IsLarge()
        {
            if ((Length + Width + Height) >= LARGE_PACKAGE)
            {
                return true;
            }
            else
                return false;
        }

        //Precondition: none
        //Postcondition: returns the string value for an Air Package object including whether package is heavy/large
        public override string ToString()
        {
            string NL = Environment.NewLine;
            return base.ToString() + $"{NL}Is the package Heavy? {IsHeavy()}{NL}Is the package Large? {IsLarge()}";
        }
    }
}
