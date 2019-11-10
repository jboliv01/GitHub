// Program 3
// CIS 200-01
// Fall 2018
// Due: 11/12/2018
// By: D6818
// File: Prog3Form.cs
//This Form allows the user to select a specified Address Object to be edited

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class SelectorForm : Form
    {
        //Precondition: upv AddressList passed through constructor
        //Postcondition: return AddressList
        private List<Address> AddressList { get; }

        //Precondition: index > -1
        //Postcondition: returns the index/ sets the index
        internal int Index { get; set; }

        public const int MIN_ADDRESSES = 1; //minimum amount of addresses that must be available to edit

        //Precondition: upv AddressList passed through
        //Postcondition: populate AddressList
        public SelectorForm(List<Address> addressList)
        {
            InitializeComponent();
            AddressList = addressList;
        }

       //Precondition: upv AddressList passed through
       //Postcondition: populate selectorBox with address names 
        private void SelectorForm_Load(object sender, EventArgs e)
        {
            foreach(Address a in AddressList) //Populate ListBox with each Address Name in the AddressList
            {
                selectorBox.Items.Add(a.Name); //populate selectorBox with address Names
            }
        }

        //Precondition: Selected index > -1
        //Postcondition: set Index to the SelectedIndex, DialogResult set to OK
        private void okButton_Click(object sender, EventArgs e)
        {
            if(selectorBox.SelectedIndex == -1)
            {
                MessageBox.Show("Must select an Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Index = selectorBox.SelectedIndex; //Index is set to selectorBox Index value
                this.DialogResult = DialogResult.OK; //DialogResult set to OK
            }
        }

        //Precondition: none    
        //Postcondition: DialogResult = Cancel
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; //DialogResult set to Cancel
        }
    }
}
