using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Headache.Models
{
    public static class Constants
    {
        public static string GetNationality(int code)
        {
            switch(code)
            {
                case 209:
                    return "AFGHANISTANIAN";
                case 300:
                    return "AFRICAN COUNTRIES";
                case 473:
                    return "ALBANI";
                case 276:
                    return "ALFARO IELANDS";
                case 131:
                    return "ALGERIAN";
                case 502:
                    return "AMERICAN";
                case 445:
                    return "AMDORO";
                case 305:
                    return "ANJOLIAN";
                case 805:
                    return "ANTIGUA AND BRABUDA";
                case 251:
                    return "ANTIGWA";
                case 605:
                    return "ARGENTNI";
                case 263:
                    return "ARMINIAN";
                case 200:
                    return "ASIAN";
                case 441:
                    return "ATICANI";
                case 203:
                    return "PAKISTANIAN";
                default:
                    return "N/A";
            }
        }

        public static string GetGender(int code)
        {
            switch (code)
            {
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "N/A";
            }
        }
    }
}