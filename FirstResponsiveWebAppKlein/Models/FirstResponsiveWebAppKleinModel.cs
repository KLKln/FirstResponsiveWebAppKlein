using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppKlein.Models
{
    public class FirstResponsiveWebAppKleinModel
    {
        public string ErrorMessage = "";
        [Required(ErrorMessage = "Please enter your first name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your birthday.")]
        public DateTime BirthYear { get; set; }
        public string userName = "";
        public string userBirthday = "";

        public String Greeting()
        {
            if (Regex.IsMatch(Name, @"^[\p{L}]+$"))
            {
                string userName = Name;
            }
            else
            {
                ErrorMessage = "Alphabet only for name please";
            }
            DateTime birthday;
            if (DateTime.TryParseExact(BirthYear.ToString(), "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out birthday))
            {
                string userBirthday = birthday.ToString();
            }
            else
            {
                ErrorMessage = "Date only in this format: 'MM/dd/yyyy'.";
            }
            string greeting = "Hello " + Name + ", your birthday is " + BirthYear.ToString() + ".";
            return greeting;
        }
    }

}
