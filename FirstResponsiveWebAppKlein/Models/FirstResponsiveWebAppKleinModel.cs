/**************************************************************
* Name        : FirstResponsiveWebAppKlein.cs
* Author      : Kelly Klein
* Created     : 09/02/2020
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Program takes user input and outputs name and birthday(due to misreading of instructions)
*               Input:  Name: takes name of user; Birthday: takes birthday of user through a dropdown menu
*               Output: returns a greeting sepeating back users name and birthday
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

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

        public FirstResponsiveWebAppKleinModel()
        {
            
        }

        public FirstResponsiveWebAppKleinModel(string name, DateTime birthyear)
        {
            if (Regex.IsMatch(name, @"^[\p{L}]+$"))
            {
                Name = name;
            }
            else
            {
                ErrorMessage = "Alphabet only for name please";
            }
            if (DateTime.TryParseExact(birthyear.ToString(), "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out birthyear))
            {
                BirthYear = birthyear;
                string birthDay = BirthYear.ToString();
            }
            else
            {
                ErrorMessage = "Date only in this format: 'MM/dd/yyyy'.";
            }
            
        }
        

        public string Greeting(string name, string birthDay)
        {
            Name = name;
            birthDay = BirthYear.ToString();

            string greeting = "Hello " + name + ", your birthday is " + birthDay + ".";
            return greeting;
        }

    }

}
