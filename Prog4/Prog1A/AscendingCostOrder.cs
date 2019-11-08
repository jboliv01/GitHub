// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D6818
// File: AscendingCostOrder.cs
// Implements IComparer interface for Parcel class and orders the objects in Ascending order by Cost

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class AscendingCostOrder: Comparer<Parcel>
    {
        //Precondition: None
        //Postcondition: Sorts in natural order, if parcel1.CalcCost > parcel2.CalcCost method returns -#
        // when parcel1.CalcCost < parcel2.CalcCost, method returns a positive #,
        // when parcel2.CalcCost == parcel2.CalcCost, method returns 0
        public override int Compare(Parcel parcel1, Parcel parcel2)
        {
            if (parcel1 == null && parcel2 == null) //if parcel1 and parcel2 are both null, they are equal 
            {
                return 0; //return 0
            }

            if (parcel1 == null) //if parcel1 is null, return -1 because any parcel is greater than no parcel
            {
                return -1;
            }

            if (parcel2 == null) //if parcel2 is null, return 1 because any parcel is greater than no parcel
            {
                return 1;
            }
            return parcel1.CalcCost().CompareTo(parcel2.CalcCost()); // return the comparison of parcel1's CalcCost method and parcel2's CalcCost method

        }

       
    }
}
