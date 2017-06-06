using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonEntry_HW8
{
    class PersonEntry
    {
        //declare class variables
        private string _name;
        private string _email;
        private string _phone;

        //when this class is instantiated, set all of the varibles' values to blank
        public PersonEntry()
        {
            _name = "";
            _email = "";
            _phone = "";
        }

        //Make properties to allow other classes to access this class's variables' values
        public string Name
        {
            get { return _name; }
            set{_name = value;}
        }// end of Name Property

        public string Email
        {
            get{return _email;}
            set{ _email = value; }
        }//end of Email property

        public string Phone
        {
            get {return _phone;}
            set { _phone = value;}
        }// end of Phone property      
    }
}
