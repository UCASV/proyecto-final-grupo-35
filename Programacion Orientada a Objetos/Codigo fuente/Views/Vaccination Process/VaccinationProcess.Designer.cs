using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace VaccinationManagement.Views
{
    partial class VaccinationProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinationProcess));
            this.cmbMinuteStep2 = new System.Windows.Forms.ComboBox();
            this.cmbHourStep2 = new System.Windows.Forms.ComboBox();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.cmbHourVaccination = new System.Windows.Forms.ComboBox();
            this.cmbMinuteVaccination = new System.Windows.Forms.ComboBox();
            this.lblAppointmentDate = new System.Windows.Forms.TextBox();
            this.lblAppointmentDate2 = new System.Windows.Forms.TextBox();
            this.btnActualHour1 = new System.Windows.Forms.Button();
            this.btnActualhour2 = new System.Windows.Forms.Button();
            this.btnSideEffects = new System.Windows.Forms.Button();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimized = new System.Windows.Forms.PictureBox();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picMinimized)).BeginInit();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMinuteStep2
            // 
            this.cmbMinuteStep2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.cmbMinuteStep2.FormattingEnabled = true;
            this.cmbMinuteStep2.Location = new System.Drawing.Point(573, 124);
            this.cmbMinuteStep2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMinuteStep2.Name = "cmbMinuteStep2";
            this.cmbMinuteStep2.Size = new System.Drawing.Size(41, 21);
            this.cmbMinuteStep2.TabIndex = 16;
            this.cmbMinuteStep2.DropDownClosed += new System.EventHandler(this.cmbTimeSelection_Event);
            // 
            // cmbHourStep2
            // 
            this.cmbHourStep2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.cmbHourStep2.FormattingEnabled = true;
            this.cmbHourStep2.Location = new System.Drawing.Point(522, 125);
            this.cmbHourStep2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHourStep2.Name = "cmbHourStep2";
            this.cmbHourStep2.Size = new System.Drawing.Size(47, 21);
            this.cmbHourStep2.TabIndex = 15;
            this.cmbHourStep2.DropDownClosed += new System.EventHandler(this.cmbTimeSelection_Event);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateData.Enabled = false;
            this.btnUpdateData.FlatAppearance.BorderSize = 0;
            this.btnUpdateData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdateData.ForeColor = System.Drawing.Color.White;
            this.btnUpdateData.Image = ((System.Drawing.Image) (resources.GetObject("btnUpdateData.Image")));
            this.btnUpdateData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateData.Location = new System.Drawing.Point(350, 197);
            this.btnUpdateData.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(223, 34);
            this.btnUpdateData.TabIndex = 14;
            this.btnUpdateData.Text = "Actualizar datos";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateDataClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Aplicación de la vacuna";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Entrada a la Fila";
            // 
            // lbl01
            // 
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl01.ForeColor = System.Drawing.Color.White;
            this.lbl01.Location = new System.Drawing.Point(333, 41);
            this.lbl01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(263, 60);
            this.lbl01.TabIndex = 11;
            this.lbl01.Text = "Citas";
            this.lbl01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToResizeColumns = false;
            this.dgvAppointment.AllowUserToResizeRows = false;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(193, 235);
            this.dgvAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointment.MultiSelect = false;
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowTemplate.Height = 28;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.ShowCellErrors = false;
            this.dgvAppointment.Size = new System.Drawing.Size(488, 168);
            this.dgvAppointment.TabIndex = 10;
            this.dgvAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellClicked);
            // 
            // cmbHourVaccination
            // 
            this.cmbHourVaccination.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.cmbHourVaccination.FormattingEnabled = true;
            this.cmbHourVaccination.Location = new System.Drawing.Point(522, 160);
            this.cmbHourVaccination.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHourVaccination.Name = "cmbHourVaccination";
            this.cmbHourVaccination.Size = new System.Drawing.Size(47, 21);
            this.cmbHourVaccination.TabIndex = 17;
            this.cmbHourVaccination.DropDownClosed += new System.EventHandler(this.cmbTimeSelection_Event);
            // 
            // cmbMinuteVaccination
            // 
            this.cmbMinuteVaccination.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.cmbMinuteVaccination.FormattingEnabled = true;
            this.cmbMinuteVaccination.Location = new System.Drawing.Point(573, 160);
            this.cmbMinuteVaccination.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMinuteVaccination.Name = "cmbMinuteVaccination";
            this.cmbMinuteVaccination.Size = new System.Drawing.Size(41, 21);
            this.cmbMinuteVaccination.TabIndex = 18;
            this.cmbMinuteVaccination.DropDownClosed += new System.EventHandler(this.cmbTimeSelection_Event);
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.lblAppointmentDate.Location = new System.Drawing.Point(328, 125);
            this.lblAppointmentDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.ReadOnly = true;
            this.lblAppointmentDate.Size = new System.Drawing.Size(190, 20);
            this.lblAppointmentDate.TabIndex = 19;
            // 
            // lblAppointmentDate2
            // 
            this.lblAppointmentDate2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.lblAppointmentDate2.Location = new System.Drawing.Point(328, 160);
            this.lblAppointmentDate2.Margin = new System.Windows.Forms.Padding(2);
            this.lblAppointmentDate2.Name = "lblAppointmentDate2";
            this.lblAppointmentDate2.ReadOnly = true;
            this.lblAppointmentDate2.Size = new System.Drawing.Size(190, 20);
            this.lblAppointmentDate2.TabIndex = 20;
            // 
            // btnActualHour1
            // 
            this.btnActualHour1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualHour1.FlatAppearance.BorderSize = 0;
            this.btnActualHour1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnActualHour1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualHour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualHour1.ForeColor = System.Drawing.Color.White;
            this.btnActualHour1.Location = new System.Drawing.Point(618, 120);
            this.btnActualHour1.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualHour1.Name = "btnActualHour1";
            this.btnActualHour1.Size = new System.Drawing.Size(55, 31);
            this.btnActualHour1.TabIndex = 21;
            this.btnActualHour1.Text = "Ahora";
            this.btnActualHour1.UseVisualStyleBackColor = true;
            this.btnActualHour1.Click += new System.EventHandler(this.btnNowButtonStep2Event);
            // 
            // btnActualhour2
            // 
            this.btnActualhour2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualhour2.FlatAppearance.BorderSize = 0;
            this.btnActualhour2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnActualhour2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualhour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnActualhour2.ForeColor = System.Drawing.Color.White;
            this.btnActualhour2.Location = new System.Drawing.Point(618, 155);
            this.btnActualhour2.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualhour2.Name = "btnActualhour2";
            this.btnActualhour2.Size = new System.Drawing.Size(55, 32);
            this.btnActualhour2.TabIndex = 22;
            this.btnActualhour2.Text = "Ahora";
            this.btnActualhour2.UseVisualStyleBackColor = true;
            this.btnActualhour2.Click += new System.EventHandler(this.btnNowButtonVaccinationEvent);
            // 
            // btnSideEffects
            // 
            this.btnSideEffects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideEffects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideEffects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSideEffects.ForeColor = System.Drawing.Color.White;
            this.btnSideEffects.Location = new System.Drawing.Point(324, 427);
            this.btnSideEffects.Name = "btnSideEffects";
            this.btnSideEffects.Size = new System.Drawing.Size(290, 31);
            this.btnSideEffects.TabIndex = 23;
            this.btnSideEffects.Text = "Agregar Efectos Secundarios";
            this.btnSideEffects.UseVisualStyleBackColor = true;
            this.btnSideEffects.Click += new System.EventHandler(this.btnSideEffectsClick);
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image) (resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(644, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(52, 28);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 24;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click_1);
            // 
            // picMinimized
            // 
            this.picMinimized.Image = ((System.Drawing.Image) (resources.GetObject("picMinimized.Image")));
            this.picMinimized.Location = new System.Drawing.Point(618, 0);
            this.picMinimized.Name = "picMinimized";
            this.picMinimized.Size = new System.Drawing.Size(32, 28);
            this.picMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimized.TabIndex = 25;
            this.picMinimized.TabStop = false;
            this.picMinimized.Click += new System.EventHandler(this.picMinimized_Click_1);
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.pnlLateral.Controls.Add(this.picLogo);
            this.pnlLateral.Controls.Add(this.picAdd);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(170, 498);
            this.pnlLateral.TabIndex = 26;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image) (resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(164, 215);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // picAdd
            // 
            this.picAdd.Image = ((System.Drawing.Image) (resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(25, 224);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(122, 179);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 0;
            this.picAdd.TabStop = false;
            // 
            // VaccinationProcess
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (29)))), ((int) (((byte) (29)))));
            this.ClientSize = new System.Drawing.Size(692, 498);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.picMinimized);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.btnSideEffects);
            this.Controls.Add(this.btnActualhour2);
            this.Controls.Add(this.btnActualHour1);
            this.Controls.Add(this.lblAppointmentDate2);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.cmbMinuteVaccination);
            this.Controls.Add(this.cmbHourVaccination);
            this.Controls.Add(this.cmbMinuteStep2);
            this.Controls.Add(this.cmbHourStep2);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.dgvAppointment);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VaccinationProcess";
            this.Text = "VaccinationProcess";
            this.Load += new System.EventHandler(this.VaccinationProcess_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VaccinationProcess_MouseDown);
            ((System.ComponentModel.ISupportInitialize) (this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picMinimized)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picAdd;

       

        private System.Windows.Forms.Panel pnlLateral;

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimized;

        

        private System.Windows.Forms.Button btnSideEffects;

        private System.Windows.Forms.Button btnUpdateData;

        private System.Windows.Forms.Button btnActualHour1;

        public System.Windows.Forms.ComboBox cmbHourStep2;
        public System.Windows.Forms.ComboBox cmbMinuteStep2;
        public System.Windows.Forms.ComboBox cmbHourVaccination;
        public System.Windows.Forms.ComboBox cmbMinuteVaccination; 

        private System.Windows.Forms.Button btnActualhour2;

        private System.Windows.Forms.TextBox lblAppointmentDate2;
        private System.Windows.Forms.TextBox lblAppointmentDate;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label lbl01;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView dgvAppointment;
        
        #endregion
    }
}