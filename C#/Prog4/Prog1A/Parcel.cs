// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D6818
// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel:IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    //Precondition: None
    //Postcondition:  When this < p2, method returns negative #
    // When this > p2, method returns positive #
    // When this == p2, method returns 0
    public int CompareTo(Parcel p2)
    {
        if (this == null && p2 == null) //both parcel's null?
        {
            return 0; //empty
        }

        if (this == null) //parcel 1 is null?
        {
            return -1; //null is less than any value
        }

        if (p2 == null) //parcel 2 is null?
        {
            return 1; //any actual value is greater than null
        }

        if (this.OriginAddress.CompareTo(p2.OriginAddress) != 0) //if this OriginAddress is not equal to p2. OriginAddress
            return OriginAddress.CompareTo(p2.OriginAddress); //return comparison value 
        else
            return 0; //otherwise, equal
               
    }

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}" +
            $"{DestinationAddress}{NL}Cost: {CalcCost():C}";
    }
}
