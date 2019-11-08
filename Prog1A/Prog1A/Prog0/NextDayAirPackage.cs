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
    public class NextDayAirPackage:AirPackage
    {
        private decimal _expressFee; //backing field for the Express Fee property

        //Precondition: express fee >= 0
        //Postcondition: create an NextDayAirPackage object with the specified values derived from the base class, plus the Express Fee
        public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width,
           double height, double weight, decimal expressFee) : base(originAddress, destAddress, length, width, height, weight)
        {
            ExpressFee = expressFee;
        }

        public decimal ExpressFee
        {
            //Precondition: none
            //Postcondition: return _expressFee value
            get
            {
                return _expressFee;
            }
            //Precondition: value >= 0
            //Postcondition: set _expressFee to the specified value
            private set
            {
                if (value >= 0)
                    _expressFee = value;
                else
                    throw new ArgumentOutOfRangeException("ExpressFee", value, "ExpressFee must be >= 0");
            }
        }

       //Precondition: none
       //Postcondition: return the decimal value representing the cost if the package is Heavy & Large, if the package is just Heavy, if the package is just Large, or if the package is neither
        public override decimal CalcCost()
        {
           
            if (IsHeavy() && IsLarge())
            {
                return .40M * ((decimal)Length + (decimal)Width + (decimal)Height) + .30M * ((decimal)Weight) + ExpressFee + (.25M * ((decimal)Length + (decimal)Width + (decimal)Height)) + (.25m * (decimal)Weight);
                
            }
            else
                if (IsHeavy())
                {
                return .40M * ((decimal)Length + (decimal)Width + (decimal)Height) + .30M * ((decimal)Weight) + (ExpressFee) + (.25M * ((decimal)Weight));
                }
                else
                    if(IsLarge())
                    {
                        return .40M * ((decimal)Length + (decimal)Width + (decimal)Height) + .30M * ((decimal)Weight) + ExpressFee + (.25M * ((decimal)Length + (decimal)Width + (decimal)Height));
                    }
                    else
                        return .40M * ((decimal)Length + (decimal)Width + (decimal)Height) + .30M * ((decimal)Weight) + ExpressFee;

        }

        //Precondition: none
        //Postcondition: return string value for the NextDayAirPackage object
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
