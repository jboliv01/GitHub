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

//this class was designed to choose an origin and destination address, and the fixed cost, and add it to a list of parcels
namespace UPVApp
{
    public partial class LetterForm : Form
    {
        //Precondition: none
        //Postcondition: return AddressList 
        internal List<Address> AddressList { get; set; } 
        //Precondition: SelectedIndex >=0
        //Postcondition: return value of SelectedIndex
        internal int OriginIndex { get => originAddressBx.SelectedIndex; }
        //Precondition: SelectedIndex >=0
        //Postcondition: return value of SelectedIndex
        internal int DestinationIndex { get => destinationAddressBx.SelectedIndex; }
        //Precondition: FixedCostBx must contain a decimal value
        //Postcondition: return fixed cost decimal value
        internal string FixedCost { get => fixedCostBx.Text; }

        //Precondition: Parameter must be a List of type Address
        //Postcondition: create a copy of parameter and store it in AddressList property, initialize form 
        public LetterForm(List<Address> addList) //Constructor with an Address List parameter
        {
           InitializeComponent();
           AddressList = addList;
        }
        
        //Precondition: upv.address must be passed through constructor
        //Postcondition: adds the Name property value of each address object in the address list to the origin and destination combo boxes 
        private void LetterForm_Load(object sender, EventArgs e) //Load event
        {
            foreach (var a in AddressList) //Sets the values of the comboboxes to the Name property of each Address in the AddressList
            {
                originAddressBx.Items.Add(a.Name);
                destinationAddressBx.Items.Add(a.Name);
            }
            originAddressBx.SelectedIndex = 0; //sets a default index for origin address 
            destinationAddressBx.SelectedIndex = 1; //sets a default index for destination address

        }
        //Precondition: upv.address passed through constructor
        //Postcondition: change focus, set error
        private void originAddressBx_Validating(object sender, CancelEventArgs e) //Validating origin Text Box
        {
           
            if (destinationAddressBx.SelectedIndex == originAddressBx.SelectedIndex) //are the indices equal? if so, stop focus and provide an error
            {
                e.Cancel = true;
                originError.SetError(destinationAddressBx, "Destination address must differ from Origin address"); //set error message
               
            }
        }
        //Precondition: validated
        //Postcondition: clear error provider
        private void originAddressBx_Validated(object sender, EventArgs e) //Clears Error Provider after validation is complete
        {
            originError.SetError(originAddressBx, "");
        }

        //Precondition: upv.address passed through constructor
        //Postcondition: change focus, set error
        private void destinationAddressBx_Validating(object sender, CancelEventArgs e) //validating destination Text Box
        {
            if (destinationAddressBx.SelectedIndex == originAddressBx.SelectedIndex) //are the indices equal? if so, stop focus and provide an error
            {
                e.Cancel = true;
                destinationError.SetError(destinationAddressBx, "Destination address must differ from Origin address"); //set error message
                
            }
        }

        //Precondition: none
        //Postcondition: change focus, set error
        private void fixedCostBx_Validating(object sender, CancelEventArgs e) //validates whether fixedCostBox.Text can be parsed to a decimal
        {
            
            if (!decimal.TryParse(fixedCostBx.Text, out decimal fixedCost)) //can the string value be parsed to decimal type? if not, stop focus and provide an error
            {
                e.Cancel = true;
                fixedCostError.SetError(fixedCostBx, "What in compilation? Try again with a valid decimal partner "); //error message
            }
           


        }

        //Precondition: validated
        //Postcondition: clear error provider
        private void destinationAddressBx_Validated(object sender, EventArgs e)//Clears Error Provider
        {
            destinationError.SetError(destinationAddressBx, "");
        }

        //Precondition: validated
        //Postcondition: clear error provider
        private void fixedCostBx_Validated(object sender, EventArgs e) //Clears Error Provider
        {
            fixedCostError.SetError(fixedCostBx, "");
        }

       
        //Precondition: inputs must be validated
        //Postcondition: DialogResult is set to OK
        private void Ok_Button_Click(object sender, EventArgs e) //Validates form, if validation results returns true, DialogResult == Ok
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }


        //Precondition: inputs must be validated
        //Postcondition: DialogResult is set to Cancel
        private void Cancel_Button_Click(object sender, EventArgs e) //Closes Letter Form
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }  
}
