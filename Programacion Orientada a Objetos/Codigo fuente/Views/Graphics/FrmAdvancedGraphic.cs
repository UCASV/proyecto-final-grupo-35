using System.Drawing.Printing;
using System.Windows.Forms;
using VaccinationManagement.Controls;

namespace VaccinationManagement.Views.Main_Window
{
    public partial class FrmAdvancedGraphic : Form
    {
        public FrmAdvancedGraphic()
        {
            InitializeComponent();
            docToPrint = new PrintDocument();
            docToPrint.PrintPage += Printer.PrintPdf;

            Button1_Click();
        }


        private PrintDocument docToPrint;

        // This method will set properties on the PrintDialog object and
        // then display the dialog.
        private void Button1_Click()
        {
            // Allow the user to choose the page range he or she would
            // like to print.
            printDialog1.AllowSomePages = true;

            // Show the help button.
            printDialog1.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result==DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        // The PrintDialog will print the document
        // by handling the document's PrintPage event.
        
    }
}