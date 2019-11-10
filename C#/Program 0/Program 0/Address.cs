//D6818
//Program 0
//due September 10
//200-01
//Address class containing backing fields, accessors, and constructors that define an Address

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class Address
    {
       
        const int MAX_ZIP = 99999; //Max number a zip code can be
        const int MIN_ZIP = 0; //Min number a zip code can be

        private string _name; //backing field holding name
        private string _address1; //backing field holding primary address
        private string _address2; //backing field holding secondary address
        private string _city; //backing field holding name of city
        private string _state; //backing field holding name of state
        private int _zipCode; //backing field holding zip code

        public Address(string name, string address1, string address2, string city, string state, int zipCode) //constructor that initializes name, address1, address2, city, state, and zip code
        {
            Name = name; //initializes Name property
            Address1 = address1; //initializes Address1 property
            Address2 = address2; //initializes Address2 property
            City = city; //initializes City property
            State = state; //initializes State property
            Zip = zipCode; //initializes Zip property
        }
        public Address(string name, string address1, string city, string state, int zipCode) //Overloaded constructor that accepts only one address: address1
        {
            Name = name; //Initializes Name 
            Address1 = address1; //Initializes Address1
            City = city; //Initializes City
            State = state; //Initializes State
            Zip = zipCode; //Initializes Zip
        }
       

    public string Name //Name property providing access to private backing field
        {
            get
            {
                return _name; //returns value of _name 
            }
            set
            {
                
                if (string.IsNullOrEmpty(value)) //if string is empty
                {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Name)} must specify a valid Name");//throw an exception
                }
                else
                {
                    _name = value;
                }
                
            }
        }
        public string Address1 // public property providing access to _address1
        {
            get
            {
                return _address1; //returns value of _address1
            }
            set
            {

                if (string.IsNullOrWhiteSpace(value)) //if string is empty
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Address1)} must specify a valid Address"); //throw an exception
                }
                else
                {
                    _address1 = value;
                }


            }
        }
        public string Address2 // public property providing access to _address2 backing field
        {
            get
            {
                return _address2; //returns value of _address2
            }
            set
            {
               
                if (string.IsNullOrWhiteSpace(value)) //if string length is empty
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Address2)} must specify a valid Address"); //throw an exception
                }
                else
                {
                    _address2 = value;
                }
                
            }
        }
        public string City //public property providing access to _city backing field
        {
            get
            {
                return _city; //returns value of _city
            }
            set
            {
                
                if (string.IsNullOrWhiteSpace(value)) //if string is empty
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(City)} must specify a valid City"); //throw an exception
                }
                else
                {
                    _city = value;

                }
               
                
            }
        }
        public string State //public property providing access to _state backing field
        {
            get
            {
                return _state; //returns value of _state
            }
            set
            {
                
                if (string.IsNullOrWhiteSpace(value)) //if string length is less than 1
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(State)} must specify a valid State"); //throw an exception
                }
                else
                {
                    _state = value;
                }
                
            }
        }
        public int Zip //public property to access _zipCode
        {
            get
            {
                return _zipCode; //returns value of _zipCode 
            }
            set
            {
                if (value < MIN_ZIP || value > MAX_ZIP) //if the value is less than 0 or greater than 99999, it is an invalid zip and will throw the exception below
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Zip)} must specify a valid Zip Code between 0 - 99999"); //throw an exception for out of range
                }
                else
                {
                    _zipCode = value; //sets _zipCode to value
                }
            }
        }

        public override string ToString()
        { //overrides base class ToString() method to print the value of Name, Address1, Address2, City, State, and Zip properties
            if (Address2 is null) //if Address2 is empty, 
            {
             return $"Name: {Name}{Environment.NewLine }" + //return a string without an Address2 reference.
             $"Address1: {Address1}{Environment.NewLine }" +
             $"City: {City}, State: {State}, Zip Code: {Zip:D5}";
            }
            else //if false
            {
                return $"Name: {Name}{Environment.NewLine }" + //return a string with an Address 2 reference.
             $"Address1: {Address1}{Environment.NewLine }" +
             $"Address2: {Address2}{Environment.NewLine }" +
             $"City: {City}, State: {State}, Zip Code: {Zip:D5}";
            }
        }
        



    }
}
