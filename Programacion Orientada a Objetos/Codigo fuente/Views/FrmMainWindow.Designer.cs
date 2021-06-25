using System.ComponentModel;

namespace VaccinationManagement.View
{
    partial class FrmMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
            this.pnMenuVertical = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnControlView = new System.Windows.Forms.Panel();
            this.pnMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuVertical
            // 
            this.pnMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.pnMenuVertical.Controls.Add(this.button3);
            this.pnMenuVertical.Controls.Add(this.button2);
            this.pnMenuVertical.Controls.Add(this.button1);
            this.pnMenuVertical.Controls.Add(this.pictureBox1);
            this.pnMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnMenuVertical.Name = "pnMenuVertical";
            this.pnMenuVertical.Size = new System.Drawing.Size(240, 611);
            this.pnMenuVertical.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image) (resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "   ACTUALIZACION DE DATOS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image) (resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "  VERIFICACION DE CITAS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image) (resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "REGISTRO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnControlView
            // 
            this.pnControlView.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (29)))), ((int) (((byte) (29)))));
            this.pnControlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlView.Location = new System.Drawing.Point(240, 0);
            this.pnControlView.Name = "pnControlView";
            this.pnControlView.Size = new System.Drawing.Size(1044, 611);
            this.pnControlView.TabIndex = 2;
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.pnControlView);
            this.Controls.Add(this.pnMenuVertical);
            this.Name = "FrmMainWindow";
            this.Text = "FrmMainWindow";
            this.pnMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel pnControlView;

        private System.Windows.Forms.Panel pnMenuVertical;

        #endregion
    }
}