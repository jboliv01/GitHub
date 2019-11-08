// Program 3
// CIS 200-01
// Fall 2018
// Due: 11/12/2018
// By: D6818
// File: Prog3Form.cs
// This class creates the main GUI for Program 3. It provides a
// File menu with About, Exit, Open, and Save As items, an Insert menu with Address and
// Letter items, and a Report menu with List Addresses and List Parcels
// items. It also includes an Edit Menu with an Address item. 

using Prog3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog3Form : Form
    {
        private UserParcelView upv; // The UserParcelView
        private BinaryFormatter formatter = new BinaryFormatter(); //creates a binary formatter
        private StreamWriter fileWriter; //creates a StreamWriter to be written to
        private StreamReader fileReader; //creates a StreamReader to be read to

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog3Form()
        {
            InitializeComponent();

            upv = new UserParcelView();
            
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // Newline shorthand

            MessageBox.Show($"Program 3{NL}By: D6818{NL}CIS 200{NL}Fall 2018",
                "About Program 3");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();    // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result
            int zip; // Address zip code

            if (result == DialogResult.OK) // Only add if OK
            {
                if (int.TryParse(addressForm.ZipText, out zip))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        zip); // Use form's properties to create address
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
                                   // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Addresses:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
            }

            reportTxt.Text = result.ToString();

            // -- OR --
            // Not using StringBuilder, just use TextBox directly

            //reportTxt.Clear();
            //reportTxt.AppendText("Addresses:");
            //reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            //reportTxt.AppendText(NL);

            //foreach (Address a in upv.AddressList)
            //{
            //    reportTxt.AppendText(a.ToString());
            //    reportTxt.AppendText(NL);
            //    reportTxt.AppendText("------------------------------");
            //    reportTxt.AppendText(NL);
            //}

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog
            decimal fixedCost;     // The letter's cost

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return; // Exit now since can't create valid letter
            }

            letterForm = new LetterForm(upv.AddressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as upv's AddressList
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex),
                        fixedCost); // Letter to be inserted
                }
               else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
                                  // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            decimal totalCost = 0;                      // Running total of parcel shipping costs
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Parcels:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Parcel p in upv.ParcelList)
            {
                result.Append(p.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
                totalCost += p.CalcCost();
            }

            result.Append(NL);
            result.Append($"Total Cost: {totalCost:C}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        //Postcondition: file must be selected
        //Postcondition: Deserialize binary object and downcast it as a UPV object, pass it through to the LetterForm
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; //store dialog result
            string fileName; //store the file name

            using (var fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog(); //Show OpenFileDialog Dialog box
                fileName = fileChooser.FileName; //set the file name
            }
            if (result == DialogResult.OK) //if OK clicked 
            {
                
                if (string.IsNullOrEmpty(fileName)) //is fileName empty?
                {
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error); // show error if user specified invalid file
                }
                else
                {
                    FileStream input = new FileStream(
                              fileName, FileMode.Open, FileAccess.Read); //create FileStream with path name, Open Mode, and Read Access
                    try
                    {
                                           
                 
                        fileReader = new StreamReader(input);  // set file from where data is read
                        upv = (UserParcelView)formatter.Deserialize(input); //Deserialize the input and set it to the upv
                        LetterForm LF = new LetterForm(upv.AddressList); //create LetterForm object

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file",
                           "File Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                    finally
                    {
                        input.Close(); //release the FileStream resources
                    }
                }
            }
        }

        //Precondition: none
        //Postcondition: Serializes upv object and saves it with a filename
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; //hold the dialog result
            string fileName; //hold the file name

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; 
                result = fileChooser.ShowDialog(); //show SaveFileDialog Dialog box
                fileName = fileChooser.FileName; //set the file name
            }

            if (result == DialogResult.OK) //if result is OK
            {
                if (string.IsNullOrEmpty(fileName)) //is fileName empty?
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
                else
                {
                    FileStream output = new FileStream(fileName, FileMode.Create,
                            FileAccess.Write); //create Stream with fileName as the path, Create FileMode, and Write FileAccess
                    try
                    {
                        
                        fileWriter = new StreamWriter(output); // set file from where data is written
                        formatter.Serialize(output, upv); //Serialize UPV object to the stream

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        output.Close(); //release file stream resources
                    }
                    
                }
            }

        }

        //Precondition: AddressList must be > 0
        //Postcondition: The address selected will be updated with newly specified values
        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(upv.AddressCount < SelectorForm.MIN_ADDRESSES) //Count of Addresses in the upv must be greater than 0
            {
                MessageBox.Show("Need at least " + SelectorForm.MIN_ADDRESSES + " Address", "Address Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit now since can't create valid letter
            }
            
            SelectorForm Selector = new SelectorForm(upv.AddressList); // The Selector dialog box form
            DialogResult result = Selector.ShowDialog(); //Show Selector Form as dialog and store result

            AddressForm Editor = new AddressForm(); //The Editor dialog box form
            int addIndex = Selector.Index; //local variable to store the index selected in the Editor Form
                       
            Editor.AddressName = upv.AddressAt(addIndex).Name; //Set Property to the Name of the AddressAt the SelectedIndex
            Editor.Address1 = upv.AddressAt(addIndex).Address1; //Set Property to the Address1 of the AddressAt the SelectedIndex
            Editor.Address2 = upv.AddressAt(addIndex).Address2; //Set Property to the Address2 of the AddressAt the SelectedIndex
            Editor.City = upv.AddressAt(addIndex).City; //Set Property to the City of the AddressAt the SelectedIndex
            Editor.State = upv.AddressAt(addIndex).State; //Set Property to the State of the AddressAt the SelectedIndex
            Editor.ZipText = $"{upv.AddressAt(addIndex).Zip}"; //Set Property to the Zip of the AddressAt the SelectedIndex


                if (result == DialogResult.OK) //if OK was clicked (Selector Form)
                {
                    DialogResult result1 = Editor.ShowDialog(); //Show Editor form as a dialog box
                    int zipResult; //integer holding TryParse result

                    if (result1 == DialogResult.OK) //if OK was clicked (Editor Form)
                    {
                        upv.AddressAt(addIndex).Name = Editor.AddressName; //set upv Name property to the current value held in the Editor Forms TextBox
                        upv.AddressAt(addIndex).Address1 = Editor.Address1; //set upv Address1 property to the current value held in the Editor Forms TextBox
                        upv.AddressAt(addIndex).Address2 = Editor.Address2; //set upv Address2 property to the current value held in the Editor Forms TextBox
                        upv.AddressAt(addIndex).City = Editor.City; //set upv City property to the current value held in the Editor Forms TextBox
                        upv.AddressAt(addIndex).State = Editor.State; //set upv State property to the current value held in the Editor Forms TextBox

                        if (int.TryParse(Editor.ZipText, out zipResult)) //Try parsing the value in the TextBox, if successful, set the upv Zip property to that value
                        {
                            upv.AddressAt(addIndex).Zip = zipResult;
                        }

                    }
                    Editor.Dispose(); //dispose of resources   
                    Selector.Dispose(); //dispose of resources
                
            }
        }
    }
    }
    
