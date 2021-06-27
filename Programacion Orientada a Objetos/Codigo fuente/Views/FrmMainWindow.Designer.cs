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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVerificationCita = new System.Windows.Forms.Button();
            this.UpdateDataView = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.picLogoGobierno = new System.Windows.Forms.PictureBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimized = new System.Windows.Forms.PictureBox();
            this.picCloseForm = new System.Windows.Forms.PictureBox();
            this.tmrHour = new System.Windows.Forms.Timer(this.components);
            this.pnlCentral.SuspendLayout();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogoGobierno)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (29)))), ((int) (((byte) (29)))));
            this.pnlCentral.Controls.Add(this.lblFecha);
            this.pnlCentral.Controls.Add(this.lblHour);
            this.pnlCentral.Controls.Add(this.pnlLateral);
            this.pnlCentral.Controls.Add(this.pnlSuperior);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 0);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1000, 650);
            this.pnlCentral.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(339, 326);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(168, 44);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "label1";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHour
            // 
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHour.ForeColor = System.Drawing.Color.White;
            this.lblHour.Location = new System.Drawing.Point(285, 251);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(270, 75);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "label1";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.pnlLateral.Controls.Add(this.btnExit);
            this.pnlLateral.Controls.Add(this.btnVerificationCita);
            this.pnlLateral.Controls.Add(this.UpdateDataView);
            this.pnlLateral.Controls.Add(this.btnRegister);
            this.pnlLateral.Controls.Add(this.picLogoGobierno);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 35);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(231, 615);
            this.pnlLateral.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image) (resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(12, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 53);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Cerrar Sesion";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVerificationCita
            // 
            this.btnVerificationCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificationCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificationCita.ForeColor = System.Drawing.Color.White;
            this.btnVerificationCita.Image = ((System.Drawing.Image) (resources.GetObject("btnVerificationCita.Image")));
            this.btnVerificationCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerificationCita.Location = new System.Drawing.Point(12, 292);
            this.btnVerificationCita.Name = "btnVerificationCita";
            this.btnVerificationCita.Size = new System.Drawing.Size(205, 53);
            this.btnVerificationCita.TabIndex = 3;
            this.btnVerificationCita.Text = "VERIFICACION DE CITA";
            this.btnVerificationCita.UseVisualStyleBackColor = true;
            this.btnVerificationCita.Click += new System.EventHandler(this.btnVerificationCita_Click);
            // 
            // UpdateDataView
            // 
            this.UpdateDataView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateDataView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataView.ForeColor = System.Drawing.Color.White;
            this.UpdateDataView.Image = ((System.Drawing.Image) (resources.GetObject("UpdateDataView.Image")));
            this.UpdateDataView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateDataView.Location = new System.Drawing.Point(12, 372);
            this.UpdateDataView.Name = "UpdateDataView";
            this.UpdateDataView.Size = new System.Drawing.Size(205, 53);
            this.UpdateDataView.TabIndex = 2;
            this.UpdateDataView.Text = "   ACTUALIZACION DE CITAS";
            this.UpdateDataView.UseVisualStyleBackColor = true;
            this.UpdateDataView.Click += new System.EventHandler(this.UpdateDataView_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = ((System.Drawing.Image) (resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(12, 207);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(205, 53);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "REGISTRO";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // picLogoGobierno
            // 
            this.picLogoGobierno.Image = ((System.Drawing.Image) (resources.GetObject("picLogoGobierno.Image")));
            this.picLogoGobierno.Location = new System.Drawing.Point(12, 6);
            this.picLogoGobierno.Name = "picLogoGobierno";
            this.picLogoGobierno.Size = new System.Drawing.Size(194, 143);
            this.picLogoGobierno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoGobierno.TabIndex = 0;
            this.picLogoGobierno.TabStop = false;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.pnlSuperior.Controls.Add(this.picClose);
            this.pnlSuperior.Controls.Add(this.picMinimized);
            this.pnlSuperior.Controls.Add(this.picCloseForm);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1000, 35);
            this.pnlSuperior.TabIndex = 0;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image) (resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(952, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(45, 27);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMinimized
            // 
            this.picMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimized.Image = ((System.Drawing.Image) (resources.GetObject("picMinimized.Image")));
            this.picMinimized.Location = new System.Drawing.Point(914, 5);
            this.picMinimized.Name = "picMinimized";
            this.picMinimized.Size = new System.Drawing.Size(32, 27);
            this.picMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimized.TabIndex = 1;
            this.picMinimized.TabStop = false;
            this.picMinimized.Click += new System.EventHandler(this.picMinimized_Click);
            // 
            // picCloseForm
            // 
            this.picCloseForm.Image = ((System.Drawing.Image) (resources.GetObject("picCloseForm.Image")));
            this.picCloseForm.Location = new System.Drawing.Point(1243, 8);
            this.picCloseForm.Name = "picCloseForm";
            this.picCloseForm.Size = new System.Drawing.Size(45, 24);
            this.picCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCloseForm.TabIndex = 0;
            this.picCloseForm.TabStop = false;
            // 
            // tmrHour
            // 
            this.tmrHour.Enabled = true;
            this.tmrHour.Tick += new System.EventHandler(this.tmrHour_Tick);
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "FrmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm";
            this.pnlCentral.ResumeLayout(false);
            this.pnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picLogoGobierno)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picCloseForm)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer tmrHour;

        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblFecha;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox picClose;

        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlLateral;

        private System.Windows.Forms.PictureBox picMinimized;

        private System.Windows.Forms.PictureBox picCloseForm;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button UpdateDataView;
        private System.Windows.Forms.Button btnVerificationCita;

        private System.Windows.Forms.PictureBox picLogoGobierno;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}