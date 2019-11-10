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
   public class TwoDayAirPackage:Package
    {
        public enum Delivery { Early, Saver}; //enum declaring the two types of Deliveries
        private Delivery _delivery; //backing field storing the value set by the DeliveryType property

        //Precondition: DeliveryType must == Early or Saver
        //Postcondition: create an TwoDayAirPackage object with the specified values derived from the base class, plus the DeliveryType 
        public TwoDayAirPackage(Address originAddress, Address destAddress, double length, double width, 
           double height, double weight, Delivery dilveryType) : base(originAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = dilveryType;
        }

        public Delivery DeliveryType 
        {
            //Precondition: none
            //Postcondition: return _delivery value
            get
            {
                return _delivery; 
            }
            //Precondition: value must == Saver or Early
            //Postcondition: set _delivery to the value specified 
            set
            {
                if (value == Delivery.Saver || value == Delivery.Early) 
                {
                    _delivery = value; 
                }
                else
                    throw new ArgumentOutOfRangeException($"DeliveryType", value, "DeliveryType must be Early or Saver"); //throw exception if not one of these values
                    
            }
        }

        //Precondition: none
        //Postcondition: Calculate the cost of the package, applying a discount for Delivery.Saver
        public override decimal CalcCost()
        {
            if(DeliveryType == Delivery.Saver)
            return (.25M * ((decimal)Length + (decimal)Width + (decimal)Height) +.25M * ((decimal)Weight))*.9M;
            else
                return .25M * ((decimal)Length + (decimal)Width + (decimal)Height) + .25M * ((decimal)Weight);
        }

        //Precondition: none
        //Postcondition: return string value for the TwoDayAirPackage object
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
