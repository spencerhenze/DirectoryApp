using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 Spencer Henze
 11/14/16
 ITM 225
 */
namespace PersonEntry_HW8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //make a new list to save the records in with their corresponding attributes
        private List<PersonEntry> personList = new List<PersonEntry>();

        //When the form loads, read the file, load the list, and display stuff in the list box:
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // declare the variables you'll need to import the records:
                StreamReader inputFile; // to read from
                string line; // to temporarily store the line before it is broken down into tokens.

                //declare the character variable that will serve as the delimiting factor
                char[] delim = { ',' }; //we will use a comma as the delimiter 

                //Open the text file named "PhoneBook"
                inputFile = File.OpenText("PhoneBook.txt");

                
                // This loop will make the things we need and put them where they go:
                while (!inputFile.EndOfStream)
                {
                    //instantiate the PersonEntry object in the loop becuase we're going to make several (more than 1)
                    PersonEntry myPerson = new PersonEntry();

                    //temporarily assign the line from the text file to this variable
                    line = inputFile.ReadLine();

                    //now tokenize it (break it up into the attributes for the myPerson object)
                    string[] tokens = line.Split(delim);
                    myPerson.Name = tokens[0]; //everything before the first comma is the first token which is saved as the "Name" property for our current object. (repeat for next 2 lines)
                    myPerson.Email = tokens[1];
                    myPerson.Phone = tokens[2];

                    personList.Add(myPerson); //now that all of the attributes are assigned to the object, save it to the list

                    personListBox.Items.Add(myPerson.Name);  //Add the name property for each record to the listbox                   
                } // end while loop
             } // end try block
             catch
             {
                MessageBox.Show("File read error");
             }
        }

        //When the selected record changes, run this process:
        private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = personListBox.SelectedIndex; //this variable keeps track of the index number of the selected record so that we can reference it later

            //instantiate the info display form to display the details
            InfoDisplayForm myInfoForm = new InfoDisplayForm();

            //Send the property associated with whatever record index number is selected to the info display form
            myInfoForm.PerName = personList[index].Name;
            myInfoForm.PerEmail = personList[index].Email;
            myInfoForm.PerPhone = personList[index].Phone;

            //once all of the variables for the info display form are sent over and set, display the form
            myInfoForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

