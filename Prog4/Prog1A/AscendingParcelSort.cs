// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D6818
// File: AscendingParcelSort.cs
// Implements IComparer interface for the Parcel class that orders the objects in Ascending Order by Parcel Type, then in Descending order by Cost

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class AscendingParcelSort: Comparer<Parcel>
    {

        //Precondition: None
        //Postcondition: Multilevel sort, if parcel's Type > parcel2's Type method returns -#
        // when parcel1's Type < parcel2's Type, method returns a positive #,
        // when parcel2's Type == parcel2's Type, method returns 0
        public override int Compare(Parcel parcel1, Parcel parcel2)
        {
            if (parcel1 == null && parcel2 == null) //both parcel's null?
            {
                return 0; //equal
            }
            
            if (parcel1 == null) //parcel 1 is null?
            {
                return -1; //null is less than any value
            }

            if (parcel2 == null) //parcel 2 is null?
            {
                return 1; //any actual value is greater than null
            }

            if (parcel1.GetType().ToString().CompareTo(parcel2.GetType().ToString()) != 0) // if parcel1's type and parcel2's type arent equal
            {
                return parcel1.GetType().ToString().CompareTo(parcel2.GetType().ToString()); // return their comparison value
            }
            else // if they are equal, sort by cost now
            if (parcel1.CalcCost().CompareTo(parcel2.CalcCost()) != 0) //if parcel1's CalcCost method does not equal parcel2's CalcCost method
            {
                return (-1) * parcel1.CalcCost().CompareTo(parcel2.CalcCost()); //reverse the natural order of their comparison values, descending order
            }
            else return 0; //otherwise
           

            

        }
    }
}
