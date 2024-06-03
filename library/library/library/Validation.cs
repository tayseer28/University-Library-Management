using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace library
{
    internal class Validation
    {
        public static bool studEmailValidation(string email)
        {
            Regex emailPattern = new Regex("^114101[0-9]{8}@stud\\.cu\\.edu\\.eg$");
            if (emailPattern.IsMatch(email))
            {
                return true;

            }
            return false;

        }

        public static bool passWordValidation(string password)
        {
            Regex passwordPattern = new Regex("^[a-zA-z0-9]{8,12}$");
            if (passwordPattern.IsMatch(password))
            {
                return true;

            }
            return false;

        }

        public static bool studIdValidation(string ID)
        {
            Regex IdPattern = new Regex("^\\d{8}$");

            if (IdPattern.IsMatch(ID))
            {
                return true;

            }
            return false;

        }

        public static bool studyYearValidation(string studyY)
        {
            Regex studyYearPattern = new Regex("^[1-4]$");
            if (studyYearPattern.IsMatch(studyY))
            {
                return true;
            }

            return false;

        }
        public static bool departmentValidation(string dep)
        {
            Regex departmentPattern = new Regex("^(G|g|C|c|IS|is|AI|ai|IT|it|CS|cs|DS|ds)$");
            if (departmentPattern.IsMatch(dep))
            {
                return true;
            }

            return false;


        }

        public static bool adminEmailValidation(string email)
        {
            Regex emailPattern = new Regex("^([a-zA-Z0-9._%-]+@[a-zA-Z0-9]{3,}\\.[a-zA-Z]{2,6})*$");
            if (emailPattern.IsMatch(email))
            {
                return true;
            }
            return false;
        }


    }

}
