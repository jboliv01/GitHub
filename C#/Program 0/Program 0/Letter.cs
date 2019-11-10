//D6818
//Program 0
//due September 10
//200-01
//Letter class that derives from Parcel. Calls base constructor to do most of the work, but adds one parameter for the fixed cost of shipping
//overrides the CalcCost method to return FixedCost property value
//overrides the ToString method to return the values of the new CalcCost Method 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class Letter : Parcel //public class derived from the Parcel class
    {
        const int MIN_FIX_COST = 0; //minimum fixed cost amount
        private decimal _fixedCost; //private backing field storing fixed cost

        public Letter(Address originAddress, Address destinationAddress, decimal fixedCost):base(originAddress, destinationAddress) //constructor calling for help from its parent constructor (Parcel), adding an additional parameter for fixedCost
        {
            FixedCost = fixedCost; //Initializes FixedCost
        }

        private decimal FixedCost //Private property for Fixed cost providing access to _fixedCost backing field
        {
            get { return _fixedCost; } //returns value of _fixedCost backing field
            set
            {
                if(value < MIN_FIX_COST) //if value is less than 0, throw an exception stating so
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(FixedCost)} must be a non negative number");
                }
                else
                {
                    _fixedCost = value; //sets _fixedCost to value if value passes validation
                }
            }
        }
        
        public override decimal CalcCost() => //overrides CalcCost() method from parent(Parcel) to return the FixedCost; 
            FixedCost;

        public override string ToString() => //overrides the ToString() method from the Parcel class
            $"{base.ToString()}";
        

    }

}
