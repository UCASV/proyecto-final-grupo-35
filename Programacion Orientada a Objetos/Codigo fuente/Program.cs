using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationManagement.Views;
using VaccinationManagement.Context;
using VaccinationManagement.Models;

namespace VaccinationManagement
{
    static class LocationData
    {
        public static int UserId { get; set; }
        public static string GestorName { get; set; }
        public static int IdActualBooth { get; set; }
    }
    
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

         
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VaccinationProcess());
        }
    }
}