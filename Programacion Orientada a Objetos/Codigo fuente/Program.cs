using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationManagement.View;
using VaccinationManagement.Context;
using VaccinationManagement.Views;

namespace VaccinationManagement
{
    
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                   //Gestor_7
                   //25t07my

            var db = new VaccinationContext();
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (db.Database.CanConnect())
                Application.Run(new Login());
            else 
                Application.Run(new Form());
        }
    }
}