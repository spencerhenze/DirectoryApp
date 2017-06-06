using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonEntry_HW8
{
    public partial class InfoDisplayForm : Form
    {
        //Declare variables for the form
        string personName;
        string personEmail;
        string personPhone;


        public InfoDisplayForm()
        {
            InitializeComponent();
        }

        //make Properties to allow other classes to access the form's variables
        public string PerName
        {
            get { return personName; }
            set { personName = value; }
        }// end PerName property

        public string PerEmail
        {
            get { return personEmail; }
            set { personEmail = value; }
        }//end PerEmail property

        public string PerPhone
        {
            get { return personPhone; }
            set { personPhone = value; }
        } // end PerPhone property


        //When the form loads, display the assigned values in the form controls
        private void InfoDisplayForm_Load(object sender, EventArgs e)
        {
            nameDisplayLabel.Text = personName;
            emailDisplayLabel.Text = personEmail;
            phoneDisplayLabel.Text = personPhone;
        }
    }
}
