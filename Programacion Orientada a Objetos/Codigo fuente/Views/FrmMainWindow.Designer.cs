using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using VaccinationManagement.Controls;

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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdateCitas = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnControlView = new System.Windows.Forms.Panel();
            this.pnGrafics = new System.Windows.Forms.Panel();
            this.pnMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuVertical
            // 
            this.pnMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.pnMenuVertical.Controls.Add(this.btnExit);
            this.pnMenuVertical.Controls.Add(this.btnUpdateCitas);
            this.pnMenuVertical.Controls.Add(this.btnCitas);
            this.pnMenuVertical.Controls.Add(this.btnRegister);
            this.pnMenuVertical.Controls.Add(this.picLogo);
            this.pnMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnMenuVertical.Name = "pnMenuVertical";
            this.pnMenuVertical.Size = new System.Drawing.Size(240, 611);
            this.pnMenuVertical.TabIndex = 1;            
            // 
            // pnGrafics
            // 
            this.pnGrafics.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.pnGrafics.Location = new System.Drawing.Point(100, 50);
            this.pnGrafics.Name = "pnGrafics";
            this.pnGrafics.Size = new System.Drawing.Size(700, 500);
            this.pnGrafics.TabIndex = 2;
            this.pnGrafics.Paint += new PaintEventHandler(ShowStadistics.DrawGraphics);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image) (resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(11, 532);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 67);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "  Cerrar Sesión";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdateCitas
            // 
            this.btnUpdateCitas.FlatAppearance.BorderSize = 0;
            this.btnUpdateCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnUpdateCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCitas.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdateCitas.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCitas.Image = ((System.Drawing.Image) (resources.GetObject("btnUpdateCitas.Image")));
            this.btnUpdateCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCitas.Location = new System.Drawing.Point(12, 362);
            this.btnUpdateCitas.Name = "btnUpdateCitas";
            this.btnUpdateCitas.Size = new System.Drawing.Size(212, 67);
            this.btnUpdateCitas.TabIndex = 3;
            this.btnUpdateCitas.Text = "ACTUALIZACION DE DATOS";
            this.btnUpdateCitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCitas.UseVisualStyleBackColor = true;
            this.btnUpdateCitas.Click += this.btnUpdateDataView_click;
            // 
            // btnCitas
            // 
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.Image = ((System.Drawing.Image) (resources.GetObject("btnCitas.Image")));
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(11, 289);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(223, 67);
            this.btnCitas.TabIndex = 2;
            this.btnCitas.Text = "  VERIFICACION DE CITAS";
            this.btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = ((System.Drawing.Image) (resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(12, 216);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(222, 67);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "REGISTRO";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new EventHandler(this.btnRegister_click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = ((System.Drawing.Image) (resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(11, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(223, 154);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnControlView
            // 
            this.pnControlView.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (29)))), ((int) (((byte) (29)))));
            this.pnControlView.Controls.Add(this.pnGrafics);
            this.pnControlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlView.Location = new System.Drawing.Point(240, 0);
            this.pnControlView.Name = "pnControlView";
            this.pnControlView.Size = new System.Drawing.Size(944, 611);
            this.pnControlView.TabIndex = 2;
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.pnControlView);
            this.Controls.Add(this.pnMenuVertical);
            this.Icon = new Icon(
                "./Resources/icoGobierno.ico");            
            this.Name = "FrmMainWindow";
            this.Text = "FrmMainWindow";
            this.pnMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button btnCitas;

        private System.Windows.Forms.Button btnRegister;
        

        private System.Windows.Forms.Button btnUpdateCitas;

        private System.Windows.Forms.PictureBox picLogo;

        private System.Windows.Forms.Panel pnMenuVertical;
        
        private System.Windows.Forms.Panel pnControlView;

        private System.Windows.Forms.Panel pnGrafics;

        #endregion
    }
}