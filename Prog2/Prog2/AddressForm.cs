using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Program 2
//CIS 200-01
//ID: D6818
//Due: October 24, 2018

//this class was designed to gather information/values necessary to instantiate an Address object

namespace UPVApp
{
    public partial class AddressForm : Form
    {
        const int TOO_BIG = 100; //Max string Length
        const int MAX_ZIP = 99999; // Max Zip value
        const int MIN_ZIP = 0; // Min Zip value
        const int INVALID_INDEX = -1; //invalid index value

        //Precondition: none
        //Postcondition: set control properties
        public AddressForm()
        {
            InitializeComponent();

        }

        //Precondition: nameBx.Text must contain a value
        //Postcondition: return a string
        internal string NameValue { get => nameBx.Text; }
        //Precondition: addressBx.Text must contain a value
        //Postcondition: return a string
        internal string AddressValue { get => addressBx.Text; }
        //Precondition: none
        //Postcondition: return a string
        internal string AddressValue1 { get => addressBx1.Text; }
        //Precondition: cityBx.Text must contain a string value
        //Postcondition: return a string
        internal string CityValue { get => cityBx.Text; }
        //Precondition: SelectedIndex must be >= 0
        //Postcondition: return a string
        internal string StateValue { get => stateBx.Text; }
        //Precondition: zipBx.Text must contain an integer value
        //Postcondition: return an integer
        internal int ZipValue { get => int.Parse(zipBx.Text); }

        //Precondition: none
        //Postcondition: set statebox index to 0
        private void AddressForm_Load(object sender, EventArgs e) //Set State ComboBox Index to a default value
        {
            stateBx.SelectedIndex = 0;
        }

        //Precondition: textboxes must pass validation 
        //Postcondition: DialogResult is set to OK
        private void okButton_Click(object sender, EventArgs e) //Validate Child Controls
        {
            if (this.ValidateChildren()) //If Validation returns true, DialogResult is set to OK
                this.DialogResult = DialogResult.OK;
            
        }

        //Precondition: click       
        //Postcondition: dispose of address form
        private void cancelButton_Click(object sender, EventArgs e) 
        {
            this.DialogResult = DialogResult.Cancel; 
        }

        //Precondition: none    
        //Postcondition: change focus, set error provider
        private void nameBx_Validating(object sender, CancelEventArgs e)//validate nameBx
        {
            if(string.IsNullOrWhiteSpace(nameBx.Text)) //string is null or white space? stop focus and provide an error
                {
                e.Cancel = true;
                nameError.SetError(nameBx, "Enter something, no name!"); //Set error message
                
                } 
                if(nameBx.Text.Length > TOO_BIG) //string length is unreasonably long? stop focus and provide an error
                {
                e.Cancel = true;
                nameError.SetError(nameBx, "Try entering a condensed address"); //set error message
                nameBx.SelectAll();//highlight text
                }


        }
        //Precondition: validated          
        //Postcondition: clear error provider
        private void nameBx_Validated(object sender, EventArgs e) //clear error provider
        {
            nameError.SetError(nameBx, "");
        }

        //Precondition: none    
        //Postcondition: change focus, set error provider
        private void addressBx_Validating(object sender, CancelEventArgs e) //validate addressBx
        {
            if(string.IsNullOrWhiteSpace(addressBx.Text)) //string is null or empty? stop focus an provide an error
            {
                e.Cancel = true;
                addressError.SetError(addressBx, "Must enter an address");//Set error message             
            }
            if(addressBx.Text.Length > TOO_BIG) //string length unreasonably long? stop focus an provide an error
            {
                e.Cancel = true;
                addressError.SetError(addressBx, "Try entering a condesned address"); //Set error message
                addressBx.SelectAll(); //highlight text
            }

        }

        //Precondition: validated  
        //Postcondition: Clear error provider
        private void addressBx_Validated(object sender, EventArgs e) //clear error provider
        {
            addressError.SetError(addressBx, "");
        }

        //Precondition: none    
        //Postcondition: change focus, set error provider
        private void addressBx1_Validating(object sender, CancelEventArgs e) //validate addressBx1
        {
            if(addressBx1.Text.Length > TOO_BIG) //string length unreasonably long? stop focus an provide an error
            {
                e.Cancel = true;
                addressError1.SetError(addressBx1, "Try entering a condesned address");//Error message
                addressBx.SelectAll();//Highlight text
            }
        }

        //Precondition: none    
        //Postcondition: change focus, set error provider
        private void addressBx1_Validated(object sender, EventArgs e) //clear error provider
        {
            addressError1.SetError(addressBx1, "");
        }

        //Precondition: none    
        //Postcondition: change focus, set error provider
        private void cityBx_Validating(object sender, CancelEventArgs e) //validating cityBx
        {
            if(string.IsNullOrWhiteSpace(cityBx.Text)) //value of cityBx.Text is null or white space? stop focus an provide an error
            {
                e.Cancel = true;
                cityError.SetError(cityBx, "Enter a valid city"); //Error message
            }
            if(cityBx.Text.Length > TOO_BIG) //Length of the given string unreasonably long? stop focus an provide an error
            {
                e.Cancel = true;
                cityError.SetError(cityBx, "Try entering a condesned address"); //Error message
                cityBx.SelectAll();//highlights text
            }
                
        }

        //Precondition: validated  
        //Postcondition: Clear error provider
        private void cityBx_Validated(object sender, EventArgs e) //clears cityBx error provider
        {
            cityError.SetError(cityBx, "");
        }

        //Precondition: none    
        //Postcondition: change focus, set error provider
        private void zipBx_Validating(object sender, CancelEventArgs e)
        {
            int number; //holds value of parsed number

            if (!int.TryParse(zipBx.Text, out number)) //cant parse? stop focus change and provide an error
            {
                e.Cancel = true; 
                zipError.SetError(zipBx, "Enter an integer!"); // Set error message
                zipBx.SelectAll(); //highlights text
            }
            else
            {
                if (number < MIN_ZIP) //parsed value a negative number? stop focus an provide an error
                {
                    e.Cancel = true;                   
                    zipError.SetError(zipBx, "Enter a non-negative integer!"); // Set error message
                    zipBx.SelectAll(); //highlights text
                }
                if (number > MAX_ZIP) //parsed value greater than 99999? stop focus an provide an error
                {
                    e.Cancel = true;
                    zipError.SetError(zipBx, "Value is too large"); // Set error message
                    zipBx.SelectAll();//highlights text
                }


            }
        }

        //Precondition: validated  
        //Postcondition: Clear error provider
        private void zipBx_Validated(object sender, EventArgs e) //clears zipBx ErrorProvider
        {
            zipError.SetError(zipBx, "");
        }

        //Precondition: none    
        //Postcondition: change focus, set error provider
        private void stateBx_Validating(object sender, CancelEventArgs e) //Validates whether a state is selected
        {
            if(stateBx.SelectedIndex == INVALID_INDEX) //Fail to make a state selection? focus is stopped and error is provided
            {
                e.Cancel = true;
                stateError.SetError(stateBx, "Must select a State");
            }
        }

        //Precondition: validated  
        //Postcondition: Clear error provider
        private void stateBx_Validated(object sender, EventArgs e) //clears stateBx ErrorProvider
        {
            stateError.SetError(stateBx, "");
        }
    }
}

