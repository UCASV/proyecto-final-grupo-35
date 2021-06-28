using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VaccinationManagement.Views
{
    partial class AppointmentProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentProcess));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txbx_DUI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_addres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbx_disease = new System.Windows.Forms.TextBox();
            this.btn_add_disease = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.cbx_institution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_pgroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_ICode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "*DUI:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "INFORMACIÓN DEL CIUDADANO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txbx_DUI
            // 
            this.Txbx_DUI.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.Txbx_DUI.ForeColor = System.Drawing.Color.White;
            this.Txbx_DUI.Location = new System.Drawing.Point(213, 80);
            this.Txbx_DUI.Name = "Txbx_DUI";
            this.Txbx_DUI.Size = new System.Drawing.Size(329, 20);
            this.Txbx_DUI.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "*Nombre:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_name
            // 
            this.txtb_name.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.txtb_name.ForeColor = System.Drawing.Color.White;
            this.txtb_name.Location = new System.Drawing.Point(213, 140);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(329, 20);
            this.txtb_name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(213, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "*Dirección de domicilio:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbx_addres
            // 
            this.txtbx_addres.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.txtbx_addres.ForeColor = System.Drawing.Color.White;
            this.txtbx_addres.Location = new System.Drawing.Point(213, 201);
            this.txtbx_addres.Name = "txtbx_addres";
            this.txtbx_addres.Size = new System.Drawing.Size(329, 20);
            this.txtbx_addres.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(213, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "*Teléfono de contacto:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbx_phone
            // 
            this.txtbx_phone.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.txtbx_phone.ForeColor = System.Drawing.Color.White;
            this.txtbx_phone.Location = new System.Drawing.Point(213, 254);
            this.txtbx_phone.Name = "txtbx_phone";
            this.txtbx_phone.Size = new System.Drawing.Size(144, 20);
            this.txtbx_phone.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(391, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Correo electrónico (opcional)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbx_email
            // 
            this.txtbx_email.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.txtbx_email.ForeColor = System.Drawing.Color.White;
            this.txtbx_email.Location = new System.Drawing.Point(391, 254);
            this.txtbx_email.Name = "txtbx_email";
            this.txtbx_email.Size = new System.Drawing.Size(156, 20);
            this.txtbx_email.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(213, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "*Enfermedades crónicas que padece:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbx_disease
            // 
            this.txtbx_disease.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.txtbx_disease.ForeColor = System.Drawing.Color.White;
            this.txtbx_disease.Location = new System.Drawing.Point(213, 312);
            this.txtbx_disease.Name = "txtbx_disease";
            this.txtbx_disease.Size = new System.Drawing.Size(144, 20);
            this.txtbx_disease.TabIndex = 15;
            // 
            // btn_add_disease
            // 
            this.btn_add_disease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_disease.ForeColor = System.Drawing.Color.White;
            this.btn_add_disease.Location = new System.Drawing.Point(362, 311);
            this.btn_add_disease.Name = "btn_add_disease";
            this.btn_add_disease.Size = new System.Drawing.Size(82, 21);
            this.btn_add_disease.TabIndex = 16;
            this.btn_add_disease.Text = "Añadir";
            this.btn_add_disease.UseVisualStyleBackColor = true;
            this.btn_add_disease.Click += new System.EventHandler(this.btn_add_disease_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(213, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "*Insititución  la que pertenece:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 577);
            this.panel1.TabIndex = 19;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image) (resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(3, 232);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(159, 194);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(421, 492);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(140, 34);
            this.Save.TabIndex = 20;
            this.Save.Text = "Guardar Información";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click_1);
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(230, 492);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(127, 34);
            this.Back.TabIndex = 21;
            this.Back.Text = "Cancelar";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // cbx_institution
            // 
            this.cbx_institution.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.cbx_institution.ForeColor = System.Drawing.Color.White;
            this.cbx_institution.FormattingEnabled = true;
            this.cbx_institution.Location = new System.Drawing.Point(213, 366);
            this.cbx_institution.Name = "cbx_institution";
            this.cbx_institution.Size = new System.Drawing.Size(144, 21);
            this.cbx_institution.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "*Grupo de prioridad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_pgroup
            // 
            this.cbx_pgroup.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.cbx_pgroup.ForeColor = System.Drawing.Color.White;
            this.cbx_pgroup.FormattingEnabled = true;
            this.cbx_pgroup.Location = new System.Drawing.Point(391, 366);
            this.cbx_pgroup.Name = "cbx_pgroup";
            this.cbx_pgroup.Size = new System.Drawing.Size(179, 21);
            this.cbx_pgroup.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(213, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "*Código Institución:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtb_ICode
            // 
            this.txtb_ICode.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.txtb_ICode.ForeColor = System.Drawing.Color.White;
            this.txtb_ICode.Location = new System.Drawing.Point(213, 429);
            this.txtb_ICode.Name = "txtb_ICode";
            this.txtb_ICode.Size = new System.Drawing.Size(144, 20);
            this.txtb_ICode.TabIndex = 26;
            // 
            // AppointmentProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (29)))), ((int) (((byte) (28)))), ((int) (((byte) (29)))));
            this.ClientSize = new System.Drawing.Size(610, 576);
            this.Controls.Add(this.txtb_ICode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_pgroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_institution);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_add_disease);
            this.Controls.Add(this.txtbx_disease);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbx_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbx_phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_addres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txbx_DUI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "AppointmentProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de cita";
            this.Load += new System.EventHandler(this.AppointmentProcess_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox picUser;

        private System.Windows.Forms.TextBox txtb_ICode;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.RadioButton Goberment;

        private System.Windows.Forms.RadioButton RB_Salubrity;

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Button btn_add_disease;

        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox Txbx_DUI;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        #endregion
    }
}