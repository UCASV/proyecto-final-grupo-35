using System;
using System.Windows.Forms;

namespace VaccinationManagement.Views
{
    public partial class Frmverification : Form
    {
        public Frmverification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            borrarmensajeerror();
            if (validarcampos())
            {
                MessageBox.Show("datos bien ingresados");
            }
                
        }

        private bool validarcampos()
        {
            bool ok = true;

            if (textBox1 == "")
            {
                ok = false;
                ErrorProvider.SetError(textBox1, "ingresar su nombre")
            }

            return ok;
        }

        private void borrarmensajeerror()
        {
            ErrorProvider.SetError(textBox1, "")
        }
    }
}