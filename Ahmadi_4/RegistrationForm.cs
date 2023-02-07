// Programmer: Maxwell Ahmadi
// Project: Ahmadi_4
// Date: 12/02/2022
// Description: Individual Assignment #4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmadi_4
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Declare all constants needed for course registrant options and detailing the maximum # of classes the film student can take*
        private const decimal LIVE_ACTION_CLASS_COST = 79.95m;
        private const decimal ANIMATION_CLASS_COST = 99.95m;
        private const int MAXIMUM_COURSES_ALLOWED = 4;

        // Declare all of the necessary class-level variables for calculation of totals (come end of the program)
        private decimal numberOfClassesSelected = 0m;
        private decimal pricePerClass = 0m;
        private decimal totalRegistrationCost = 0m;


        // Handles Form 1's initial loading event (when the form is first opened for user input)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Allows the list box to load all necessary class information from the respective LiveAction/Animation class text files
            PopulateList();

            // Allows all of the calculations to be ran under the Update Totals event handler

            // Displays the current date to the masked date text box atop the form*
            registrationDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Establishes the array for the details of the 'Registrant Status' Combo Box* 
            string[] registrantStatusArray = { "Actor", "Producer", "Director", "Animator", "Cinematographer",  "Drama Teacher", "Light Technician", "Sound Technician" };
            registrantStatusComboBox.Items.AddRange(registrantStatusArray); // Allows the array to display the range of information to the proper Combo Box

            // Ensures that the 'Live Action' button is selected when the form first loads
            liveActionRadioButton.Checked = true;

            // Ensures that the 'Cash' radio button is selected when the form first loads
            cashRadioButton.Checked = true;

            // Ensures that the 'Email Receipt Requested' check box is NOT selected when the form first loads
            emailReceiptCheckBox.Checked = false;


            // Establishes the string variable/label relationships so that prices and numbers can display at the bottom of the form to assist the person registering*
            numberOfClassesSelectedLabel.Text = numberOfClassesSelected.ToString("c");
            pricePerClassLabel.Text = pricePerClass.ToString("c");
            totalRegistrationCostLabel.Text = totalRegistrationCost.ToString("c");
            maximumNumberOfClassesAllowedLabel.Text = MAXIMUM_COURSES_ALLOWED.ToString("n");

        }

        // Establishes the PopulateList event header in order to input the text from the LiveAction/Animation files to fill the availableClassesListBox*
        private void PopulateList()
        {
            
            if (liveActionRadioButton.Checked)
            {
                availableClassesListBox.Sorted = true;

                try
                {
                    string classes;
                    StreamReader inputFile;
                    inputFile = File.OpenText("LiveActionClasses.txt");
                    availableClassesListBox.Items.Clear();
                    while (!inputFile.EndOfStream)
                    {
                        classes = inputFile.ReadLine();
                        availableClassesListBox.Items.Add(classes);
                    }
                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                availableClassesListBox.Sorted = true;

                try
                {
                    string classes;
                    StreamReader inputFile;
                    inputFile = File.OpenText("AnimationClasses.txt");
                    availableClassesListBox.Items.Clear();
                    while (!inputFile.EndOfStream)
                    {
                        classes = inputFile.ReadLine();
                        availableClassesListBox.Items.Add(classes);
                    }
                    inputFile.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }  
            
        }

        // Establishes the UpdateTotals event header, which will help the form continuously update totals for prices/classes selected based on
        // use of other radio buttons/controls in the program
        private void UpdateTotals()
        {
            numberOfClassesSelected = 0;

            for (int counter = 0; counter < availableClassesListBox.Items.Count; counter++)
            {
                if (availableClassesListBox.GetSelected(counter))
                {
                    numberOfClassesSelected++;
                }
            }

            if (liveActionRadioButton.Checked)
            {
                pricePerClass = LIVE_ACTION_CLASS_COST;
            }
            else
            {
                pricePerClass = ANIMATION_CLASS_COST;
            }

            totalRegistrationCost = numberOfClassesSelected * pricePerClass;
            totalRegistrationCostLabel.Text = totalRegistrationCost.ToString("c");
            pricePerClassLabel.Text = pricePerClass.ToString("c");
            numberOfClassesSelectedLabel.Text = numberOfClassesSelected.ToString("n");
        }
        
        // Establishes the event header for the Live Action Radio Button
        private void liveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
            UpdateTotals();
        }

        // Establishes the event header for the Animation Radio Button
        private void animationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
            UpdateTotals();
        }

        // Establishes the private event header for ResetForm void, which will be used both after clearing, and after
        // a successful registration, to reset the form to its original state*
        private void ResetForm()
        {
            registrationDateMaskedTextBox.Focus();
            registrationDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            dobMaskedTextBox.Text = "";
            registrantStatusComboBox.SelectedItem = "";
            liveActionRadioButton.Checked = true;
            cashRadioButton.Checked = true;
            availableClassesListBox.SelectedItem = "";
            emailReceiptCheckBox.Checked = false;
            PopulateList();
            UpdateTotals();

        }

        // Handles the click event for the 'Clear' menu tool
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Handles the click event for the 'Exit' menu tool
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to exit the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (selection == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Handles the click event for the 'About' menu tool
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates an instance of the AboutForm form class
            AboutForm myAboutForm = new AboutForm();

            // Displays the AboutForm instance as a modal form
            myAboutForm.ShowDialog();
        }

        // Updates the totals if counted classes after each class is selected in the list box*
        private void availableClassesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Establishes the event header for the Save Tool, which will display a Registration Summary page, 
        // and will save the contents of this page (without dialogue) to a RegistrationData.txt file*
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string listOfClasses = "";
            string typeOfPayment = "";
            string emailReceiptRequestCheck = "";

            // Adds all of the inputed items from the List Box to the list, so that it can count how many classes are selected*
            for (int counter = 0; counter < availableClassesListBox.Items.Count; counter++)
            {
                if (availableClassesListBox.GetSelected(counter))
                {
                    listOfClasses += availableClassesListBox.Items[counter].ToString() + "\n";
                }
            }

            if (cashRadioButton.Checked)
            {
                typeOfPayment = "Cash";
            }

            else
            {
                typeOfPayment = "Check";
            }

            if (emailReceiptCheckBox.Checked)
            {
                emailReceiptRequestCheck = "Yes";
            }

            else
            {
                emailReceiptRequestCheck = "No";
            }

            if (numberOfClassesSelected != 0 && numberOfClassesSelected <= MAXIMUM_COURSES_ALLOWED)
            {
                if (firstNameTextBox.Text == "" | lastNameTextBox.Text == "" | emailTextBox.Text == "" | registrationDateMaskedTextBox.Text == "")
                {
                    MessageBox.Show("Error: Please complete the entirety of the form in order to continue!");
                }
                else
                {
                    // Organize message box to allow it to be clear and insert the necessary icons for display.
                    MessageBox.Show("Hopkins Film School Registration Summary:"
                        + "\nDate of Registration: " + registrationDateMaskedTextBox.Text
                        + "\nRegistrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text
                        + "\nEmail Address: " + emailTextBox.Text
                        + "\nDate of Birth: " + dobMaskedTextBox.Text
                        + "\nRegistrant Status: " + registrantStatusComboBox.SelectedItem
                        + "\nClasses Selected: " + listOfClasses
                        + "\nNumber of Classes Selected: " + numberOfClassesSelected
                        + "\n"
                        + "\nPrice per Class: " + pricePerClass
                        + "\nTotal Cost: " + totalRegistrationCost
                        + "\nType of Payment: " + typeOfPayment
                        + "\nEmail Receipt Requested: " + emailReceiptRequestCheck
                        + "\n"
                        + "\n"
                        + "An emailed copy of this registration information will be emailed to you if you requested so on the original form."
                        + "\n"
                        + "\n"
                        + "You have finished registering and your inputs have been saved, thank you!");

                    StreamWriter outputFile; // Declares the stream-writer object that we will be saving the file to
                    outputFile = File.AppendText("RegistrationData.txt");
                    outputFile.WriteLine("Hopkins Film School Registration Summary");
                    outputFile.WriteLine("Date of Registration: " + registrationDateMaskedTextBox.Text);
                    outputFile.WriteLine("Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text);
                    outputFile.WriteLine("Email Address: " + emailTextBox.Text);
                    outputFile.WriteLine("Date of Birth: " + dobMaskedTextBox.Text);
                    outputFile.WriteLine("Registrant Status " + registrantStatusComboBox.SelectedItem);
                    outputFile.WriteLine("Classes Selected: " + listOfClasses);
                    outputFile.WriteLine("Number of Classes Selected: " + numberOfClassesSelected);
                    outputFile.WriteLine("Price Per Class: " + pricePerClass);
                    outputFile.WriteLine("Total Cost: " + totalRegistrationCost);
                    outputFile.WriteLine("Type of Payment: " + typeOfPayment);
                    outputFile.WriteLine("Email Receipt Requested: " + emailReceiptRequestCheck);
                    outputFile.WriteLine();
                    outputFile.Close();

                    ResetForm();
                }
            }

            else // Shows the error message if the registration process has not been completed successfully
            {
                MessageBox.Show("An error has occured during your class registration, please review the previous form.");
            }

        }
    }
}
