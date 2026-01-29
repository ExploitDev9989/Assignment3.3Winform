using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Assignment3._4
{
    enum Classes
    {
        Python = 1,
        Ruby,
        HTML,
        Javascript
    }

    enum MonthOfAdmission
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    internal class Student
    {
        public int StudentID { get; set; }
        public string? Name { get; set; }
        public double Tuition { get; set; }

        public Classes Classes { get; set; }
        public MonthOfAdmission Admission { get; set; }
    }
}
