using System.ComponentModel;

namespace VaccinationManagement.Views
{
    partial class frmWelcomeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcomeUser));
            this.pnUser = new System.Windows.Forms.Panel();
            this.lblSystem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tmrOne = new System.Windows.Forms.Timer(this.components);
            this.tmrTwo = new System.Windows.Forms.Timer(this.components);
            this.pgrLoad = new System.Windows.Forms.ProgressBar();
            this.pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.pnUser.Controls.Add(this.lblSystem);
            this.pnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUser.Location = new System.Drawing.Point(0, 0);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(1000, 82);
            this.pnUser.TabIndex = 0;
            // 
            // lblSystem
            // 
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSystem.ForeColor = System.Drawing.Color.White;
            this.lblSystem.Location = new System.Drawing.Point(34, 27);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(347, 37);
            this.lblSystem.TabIndex = 0;
            this.lblSystem.Text = "SISTEMA DE REGISTRO DE VACUNACIÓN";
            this.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(574, 146);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(253, 37);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "BIENVENIDO";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(574, 210);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(253, 51);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "BIENVENIDO";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrOne
            // 
            this.tmrOne.Interval = 30;
            this.tmrOne.Tick += new System.EventHandler(this.tmrOne_Tick);
            // 
            // tmrTwo
            // 
            this.tmrTwo.Interval = 30;
            this.tmrTwo.Tick += new System.EventHandler(this.tmrTwo_Tick);
            // 
            // pgrLoad
            // 
            this.pgrLoad.Location = new System.Drawing.Point(435, 342);
            this.pgrLoad.Name = "pgrLoad";
            this.pgrLoad.Size = new System.Drawing.Size(540, 43);
            this.pgrLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgrLoad.TabIndex = 3;
            // 
            // frmWelcomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (29)))), ((int) (((byte) (29)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pgrLoad);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWelcomeUser";
            this.Text = "frmWelcomeUser";
            this.Load += new System.EventHandler(this.frmWelcomeUser_Load);
            this.pnUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ProgressBar pgrLoad;

        private System.Windows.Forms.Timer tmrTwo;

        private System.Windows.Forms.Timer tmrOne;

        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Label lblSystem;

        private System.Windows.Forms.Label lblUserName;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Panel pnUser;

        #endregion
    }
}