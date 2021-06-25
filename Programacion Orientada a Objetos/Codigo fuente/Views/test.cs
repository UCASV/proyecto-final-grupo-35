using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VaccinationManagement.Views
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            
            Pen pen = new Pen(Color.Black);
            pen.Width = 6.0F;
            
            GraphicsContainer containerState = canvas.BeginContainer();
            
            canvas.DrawRectangle(pen, 25, 25, 30, 30);
            
            
            canvas.EndContainer(containerState);
            
            
        }
    }
}