using System;
using System.Linq;
using System.Windows.Forms;
using VaccinationManagement.Context;
using VaccinationManagement.Models;

namespace VaccinationManagement.Views
{
    public partial class FrmGetDui : Form
    {
        public System.Windows.Forms.Button btnVerification;
        public int? appointmentoToDisplay;
        public FrmGetDui()
        {
            InitializeComponent();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            var db = new VaccinationContext();
            var dui = 0;

            ////Primero se verifica que no este vacio le txtBox
            if (txtDui.Text.Equals(""))
            {
                using (var duiError = new FrmDUIError())
                {
                    var result = duiError.ShowDialog();
                    if (result == DialogResult.OK);
                                    
                }
                return;
            }
            
            //Se intenta obtener el dui desde el textBox
            try
            {
                dui = Int32.Parse(txtDui.Text);
            }
            catch (FormatException exception)
            {
                using (var invalid = new FrmInvalidData())
                {
                    var result = invalid.ShowDialog();
                    if (result == DialogResult.OK) ;
                                    
                }
                txtDui.Text = "";
            }
            //
            
            //Revisar si hay citas de ese DUI
            var appointments = from B in db.Booths
                join E in db.Employees on B equals E.IdBoothNavigation
                join C in db.Citizens on E equals C.IdEmployeeNavigation
                join A in db.Appointments on C equals A.IdCitizenNavigation
                where B.Id == LocationData.IdActualBooth && C.Dui == dui
                select C.Dui;
            
            //Si hay, se abre el siguiente formulario 
            if(appointments.ToList().Count != 0)
            {
                
                Hide();
                appointmentoToDisplay = appointments.ToList().First();
                Close();
            }
            else
            {
                appointmentoToDisplay = null;
                
                using (var citesNull = new FrmCitesDui())
                {
                    var result = citesNull.ShowDialog();
                    if (result == DialogResult.OK) ;
                                    
                }
                
            }
            
        }

        
        
        
    }
}
