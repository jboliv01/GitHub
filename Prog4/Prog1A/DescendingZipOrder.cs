// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D6818
// File: DescendingZipOrder.cs
// Implements IComparer interface for Parcel class that orders the objects in Descending order by Zip code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingZipOrder: Comparer<Parcel>
    {
        //Precondition: None
        //Postcondition: Reverses natural order, if parcel1's Zip > parcel2's Zip method returns -#
        // when parcel1's Zip < parcel2's Zip, method returns a positive #,
        // when parcel2's Zip == parcel2's Zip, method returns 0
        public override int Compare(Parcel parcel1, Parcel parcel2)
        {
            if(parcel1 == null && parcel2 == null) //both parcel's null?
            {
                return 0; //empty
            }

            if (parcel1 == null) //parcel 1 is null?
            {
                return -1; //null is less than any value
            }

            if (parcel2 == null) //parcel 2 is null?
            {
                return 1; //any actual value is greater than null
            }

            return (-1) * parcel1.DestinationAddress.Zip.CompareTo(parcel2.DestinationAddress.Zip); //reverse the natural order, descending 
        }
    }
}
