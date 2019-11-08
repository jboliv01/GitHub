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

    //This class is designed to pull information gathered from the AddressForm and Print it 

namespace UPVApp
{
    

    public partial class Prog2Form : Form
    {
        readonly string NL = Environment.NewLine; //NewLine Shortcut
        const string DL = "====================="; //Visual aid to segment output

        internal UserParcelView upv = new UserParcelView(); //Instantiate a UserParcelView object with no parameters

        //Precondition: none
        //Postcondition: set control properties
        public Prog2Form()
        {
            InitializeComponent();
           
        }
      
        //Precondition: click
        //Postcondition: Show message box containing information about the program
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Program 2\nCIS 200-01\nID: D6818\nDue: October 24, 2018", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Precondition: click
        //Postcondition: Exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        //Precondition: click
        //Postcondition: Show Address Form, Add address to upv AddressList 
        public void addressToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            AddressForm AF = new AddressForm(); //create an AddressForm object
            DialogResult result; //holds result of the AddressForm button (OK/Cancel)
            result = AF.ShowDialog(); //Shows the form as a modal dialog box

            if (result == DialogResult.OK && AF.ValidateChildren()) //if Result is OK, then Add an Address to the UserParcelView AddressList
            {
                //Precondition: ValidateChildren() must return true
                //Postcondition: Add Address to UserParcelView Address list
                upv.AddAddress(AF.NameValue, AF.AddressValue, AF.AddressValue1, AF.CityValue, AF.StateValue, AF.ZipValue);
            }
            else
                if(result == DialogResult.Cancel) //Dispose of resources if result == cancel
            {
                AF.Dispose();
            }
                
                
            
        }

        //Precondition: click, upv.address must be instantiated with more than 2 addresses
        //Postcondition: Show Letter Form, add letter to upv parcel list
        private void letterToolStripMenuItem_Click(object sender, EventArgs e) 
        {
           
            LetterForm LF = new LetterForm(upv.addresses); //create LetterForm object, pass upv.AddressList into the constructor
            DialogResult result; //holds dialog result OK/Cancel
            result = LF.ShowDialog(); //shows form as a modal dialog box

            if (result == DialogResult.OK) //result == OK? add the selected indices and parsed fixed cost to the parcel list
            {
                //Precondition: origin address and destination address Indices cannot be Equal, fixed cost must be a decimal value
                //Postcondition: Add Letter to UserParcelView parcel list
                upv.AddLetter(LF.AddressList[LF.OriginIndex], LF.AddressList[LF.DestinationIndex], decimal.Parse(LF.FixedCost));
            }
            else
                if (result == DialogResult.Cancel) //Dispose of resources if result == cancel
            {
                LF.Dispose();
            }
        }

        //Precondition: click
        //Postcondition: print corresponding toString method for each parcel
        private void listParcelToolStripMenuItem_Click(object sender, EventArgs e) //Displays Parcel List ToString values
        {
            StringBuilder result = new StringBuilder(); //create a stringbuilder object
            foreach(Parcel p in upv.ParcelList) //Add ToString value of each Parcel in the Parcel List to the string builder
            {
                result.Append(p + NL + DL + NL); //Appends each Parcel
            }
            printBox.Text = result.ToString(); //display results
        }

        //Precondition: click
        //Postcondition: Print toString for each address
        private void listAddressToolStripMenuItem_Click(object sender, EventArgs e) //Displays Address List ToString values
        {
            

            StringBuilder result = new StringBuilder(); //create a stringbuilder object
            foreach (Address a in upv.AddressList) //Add ToString value of each Address in the Address List to the string builder
            {
                result.Append(a + NL + DL + NL); //Appends each Address
            }
            printBox.Text = result.ToString();//display results

        }

        //Precondition: none
        //Postcondition: load address objects and parcels and add them to a list
        private void Prog2Form_Load(object sender, EventArgs e)
        {
            Address a1 = new Address("John Papa", "90802 Schneider Ln.", "Louisville", "KY", 40223); //test address 1
            Address a2 = new Address("Mary Malone", "10100 Woodword Ct.", "Apt. 12", "Louisville", "KY", 40223); //test address 2
            Address a3 = new Address("Doug Digadome", "48382 Digsdale Pl.", "Tampa", "FL", 67321); //test address 3
            Address a4 = new Address("Bean Lima", "10230 Sprout Dr.", "Gainsville", "FL", 92231); //test address 4
            Address a5 = new Address("Vader Darth", "00000 Anakinsky Ct.", "Nashville", "TN", 50511); //test address 5
            Address a6 = new Address("Lebron James", "12345 Teams Pl.", "Los Angeles,", "CA", 90210); //test address 6

            upv.addresses = new List<Address> { a1, a2, a3, a4, a5, a6 }; //populate address List         
            upv.parcels = new List<Parcel> { //populate parcel List
                new GroundPackage(a1, a2, 10, 10, 12, 5), 
                new GroundPackage(a2, a5, 11, 12, 4, 10),
                new NextDayAirPackage(a4, a6, 12, 22, 5, 16, 22.00M),
                new TwoDayAirPackage(a3, a2, 5, 4, 5, 6, TwoDayAirPackage.Delivery.Early),
                new GroundPackage(a6, a1, 2, 1, 1, 1)

            };
            




        }
    }
}
