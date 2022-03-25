using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolGroupProject
{
    class clsValidation
    {

        public static bool Password(string strPassword)
        {
            int intComplexityCounter = 0;
            bool bolHasSpecial = false;
            string strAllowedKeys = "!@#$%^&*()[]";

            if (strPassword.Length >= 8 && strPassword.Length <= 20)
            {
                intComplexityCounter++;
            }
            else
            {
                return false;
            }

            if (strPassword.Any(char.IsUpper))
            {
                intComplexityCounter++;
            }
            if (strPassword.Any(char.IsLower))
            {
                intComplexityCounter++;
            }
            if (strPassword.Any(char.IsDigit))
            {
                intComplexityCounter++;
            }

            foreach (char chLetter in strPassword)
            {
                if (strAllowedKeys.Contains(chLetter.ToString()))
                {
                    bolHasSpecial = true;
                }
            }

            if (bolHasSpecial)
            {
                intComplexityCounter++;
            }

            if(intComplexityCounter >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
