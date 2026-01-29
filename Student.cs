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
    internal class Student
    {
        public int StudentID { get; set; }
        public string? Name { get; set; }
        public double Tuition { get; set; }
        public Classes Classes { get; set; }
        public string? Admission { get; set; }
    }
}
