using System;
using System.ComponentModel;
using System.Windows.Forms;

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
            ((System.ComponentModel.ISupportInitialize) (this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMinuteStep2
            // 
            this.cmbMinuteStep2.FormattingEnabled = true;
            this.cmbMinuteStep2.Location = new System.Drawing.Point(223, 44);
            this.cmbMinuteStep2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMinuteStep2.Name = "cmbMinuteStep2";
            this.cmbMinuteStep2.Size = new System.Drawing.Size(34, 21);
            this.cmbMinuteStep2.TabIndex = 16;
            this.cmbMinuteStep2.DropDownClosed += new System.EventHandler(this.cmbTimeSelection);
            // 
            // cmbHourStep2
            // 
            this.cmbHourStep2.FormattingEnabled = true;
            this.cmbHourStep2.Location = new System.Drawing.Point(186, 44);
            this.cmbHourStep2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHourStep2.Name = "cmbHourStep2";
            this.cmbHourStep2.Size = new System.Drawing.Size(34, 21);
            this.cmbHourStep2.TabIndex = 15;
            this.cmbHourStep2.DropDownClosed += new System.EventHandler(this.cmbTimeSelection);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Enabled = false;
            this.btnUpdateData.Location = new System.Drawing.Point(129, 102);
            this.btnUpdateData.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(90, 20);
            this.btnUpdateData.TabIndex = 14;
            this.btnUpdateData.FlatAppearance.BorderSize = 0;
            this.btnUpdateData.ForeColor = System.Drawing.Color.White;
            this.btnUpdateData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateData.Text = "Actualizar datos";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateDataClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Aplicación de la vacuna";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 40);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.TabIndex = 12;
            this.label1.Text = "Entrada a la Fila";
            // 
            // lbl01
            // 
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl01.Location = new System.Drawing.Point(129, 8);
            this.lbl01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(263, 32);
            this.lbl01.TabIndex = 11;
            this.lbl01.ForeColor = System.Drawing.Color.White;
            this.lbl01.Text = "Citas";
            this.lbl01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToResizeColumns = false;
            this.dgvAppointment.AllowUserToResizeRows = false;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(9, 139);
            this.dgvAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointment.MultiSelect = false;
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowTemplate.Height = 28;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.ShowCellErrors = false;
            this.dgvAppointment.Size = new System.Drawing.Size(471, 145);
            this.dgvAppointment.TabIndex = 10;
            this.dgvAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellClicked);
            // 
            // cmbHourVaccination
            // 
            this.cmbHourVaccination.FormattingEnabled = true;
            this.cmbHourVaccination.Location = new System.Drawing.Point(186, 66);
            this.cmbHourVaccination.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHourVaccination.Name = "cmbHourVaccination";
            this.cmbHourVaccination.Size = new System.Drawing.Size(34, 21);
            this.cmbHourVaccination.TabIndex = 17;
            this.cmbHourVaccination.DropDownClosed += new System.EventHandler(this.cmbTimeSelection);
            // 
            // cmbMinuteVaccination
            // 
            this.cmbMinuteVaccination.FormattingEnabled = true;
            this.cmbMinuteVaccination.Location = new System.Drawing.Point(223, 66);
            this.cmbMinuteVaccination.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMinuteVaccination.Name = "cmbMinuteVaccination";
            this.cmbMinuteVaccination.Size = new System.Drawing.Size(34, 21);
            this.cmbMinuteVaccination.TabIndex = 18;
            this.cmbMinuteVaccination.DropDownClosed += new System.EventHandler(this.cmbTimeSelection);
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.Location = new System.Drawing.Point(113, 44);
            this.lblAppointmentDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.ReadOnly = true;
            this.lblAppointmentDate.Size = new System.Drawing.Size(71, 20);
            this.lblAppointmentDate.TabIndex = 19;
            // 
            // lblAppointmentDate2
            // 
            this.lblAppointmentDate2.Location = new System.Drawing.Point(113, 68);
            this.lblAppointmentDate2.Margin = new System.Windows.Forms.Padding(2);
            this.lblAppointmentDate2.Name = "lblAppointmentDate2";
            this.lblAppointmentDate2.ReadOnly = true;
            this.lblAppointmentDate2.Size = new System.Drawing.Size(71, 20);
            this.lblAppointmentDate2.TabIndex = 20;
            // 
            // btnActualHour1
            // 
            this.btnActualHour1.Location = new System.Drawing.Point(259, 42);
            this.btnActualHour1.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualHour1.Name = "btnActualHour1";
            this.btnActualHour1.Size = new System.Drawing.Size(44, 23);
            this.btnActualHour1.TabIndex = 21;
            this.btnActualHour1.Text = "Ahora";
            this.btnActualHour1.ForeColor = System.Drawing.Color.White;
            this.btnActualHour1.UseVisualStyleBackColor = true;
            this.btnActualHour1.FlatAppearance.BorderSize = 0;
            this.btnActualHour1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnActualHour1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualHour1.Click += new System.EventHandler(this.btnNowButtonStep2Event);
            // 
            // btnActualhour2
            // 
            this.btnActualhour2.Location = new System.Drawing.Point(259, 66);
            this.btnActualhour2.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualhour2.Name = "btnActualhour2";
            this.btnActualhour2.Size = new System.Drawing.Size(44, 22);
            this.btnActualhour2.TabIndex = 22;
            this.btnActualhour2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualhour2.ForeColor = System.Drawing.Color.White;
            this.btnActualhour2.Text = "Ahora";
            this.btnActualhour2.UseVisualStyleBackColor = true;
            this.btnActualhour2.Click += new System.EventHandler(this.btnNowButtonVaccinationEvent);

            this.btnActualhour2.FlatAppearance.BorderSize = 0;
            this.btnActualhour2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (58)))), ((int) (((byte) (59)))), ((int) (((byte) (61)))));
            this.btnActualhour2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // VaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.ClientSize = new System.Drawing.Size(734, 450);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VaccinationProcess";
            this.Text = "VaccinationProcess";
            this.Load += new System.EventHandler(this.VaccinationProcess_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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