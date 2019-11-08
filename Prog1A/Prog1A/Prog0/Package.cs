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
    public abstract class Package:Parcel
    {
        private double _length; //backing field storing the value of the Length property
        private double _width;// backing field storing Width value
        private double _height;//backing field storing Height value
        private double _weight;//backing field holding Weight value

        //Precondition: Length, width, height, weight must be > 0
        //Postcondition: creates a Package object with values for origin address, destination address, length, width, height, and weight
        public Package(Address originAddress, Address destAddress, double length,
            double width, double height, double weight) : base(originAddress, destAddress)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        
        public double Length
        {
            //Precondition: none
            //Postcondition: Package Length has been returned
            get
            {
                return _length;
            }
            //Precondition: value > 0
            //Postcondition: Package Length has been set
            set
            {
                if(value > 0)
                {
                    _length = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Length", value,
                    "Length must be > 0");
            }
        }
        public double Width
        {
            //Precondition: none
            //Postcondition: Package width has been returned
            get
            {
                return _width;
            }
            //Precondition: value > 0
            //Postcondition: Package width has been set
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Width", value,
                    "Width must be > 0");
            }
        }
        public double Height
        {
            //Precondition: none
            //Postcondition: Package Height has been returned
            get
            {
                return _height;
            }
            //Precondition: value > 0
            //Postcondition: Package Height has been set
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Height", value,
                    "Height must be > 0");
            }
        }
        public double Weight
        {
            //Precondition: none
            //Postcondition: Package Weight has been returned
            get
            {
                return _weight;
            }
            //Precondition: value > 0
            //Postcondition: Package Weight has been set to specified value
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Weight", value,
                    "Weight must be > 0");
            }
        }

        //Precondition: none
        //Postcondition: a string has been returned with the package's data 
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"{GetType()}{NL}{base.ToString()}{NL}{NL}Package Dimensions: {NL}Length: {Length}, Width: {Width}{NL}Height: {Height}, Weight: {Weight}";
        }

    }
}
