using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3._4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Data.Students.Add(new Student() { StudentID = 2, Name = "Bill Gates", Tuition = 120000, Classes = Classes.Javascript, Admission = MonthOfAdmission.December});
            Data.Students.Add(new Student() { StudentID = 3, Name = "Meatball Quiroz", Tuition = 100000, Classes = Classes.Ruby, Admission = MonthOfAdmission.January });
            Data.Students.Add(new Student() { StudentID = 4, Name = "Joe Smoe", Tuition = 157333, Classes = Classes.HTML, Admission = MonthOfAdmission.June });
            Data.Students.Add(new Student() { StudentID = 5, Name = "Austin Mussle", Tuition = 12900, Classes = Classes.Javascript, Admission = MonthOfAdmission.April });
            Data.Students.Add(new Student() { StudentID = 6, Name = "Hot Dog", Tuition = 56700, Classes = Classes.Python, Admission = MonthOfAdmission.August });
            Application.Run(new Form1());
        }
    }
}