using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of the Person
        /// </summary>
        public string FirstName{ get; set; }
        /// <summary>
        /// Represents The last name of the Person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the email of the current Person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the cellphone number of the current Person
        /// </summary>
        public string CellPhoneNumber { get; set; }

    }
}
