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
            Data.Students.Add(new Student() { StudentID = 1, Name = "Miguel Quiroz", Tuition = 100000, Classes = Classes.Python });
            Data.Students.Add(new Student() { StudentID = 2, Name = "Bill Gates", Tuition = 120000, Classes = Classes.Javascript });
            Data.Students.Add(new Student() { StudentID = 3, Name = "Meatball Quiroz", Tuition = 100000, Classes = Classes.Ruby });
            Data.Students.Add(new Student() { StudentID = 4, Name = "Sauce Quiroz", Tuition = 120000, Classes = Classes.HTML });
            Application.Run(new Form1());
        }
    }
}