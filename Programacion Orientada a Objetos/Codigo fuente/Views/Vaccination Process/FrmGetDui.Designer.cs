using System.ComponentModel;
using System.Drawing;

namespace VaccinationManagement.Views
{
    partial class FrmGetDui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGetDui));
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDui
            // 
            this.txtDui.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (60)))), ((int) (((byte) (68)))));
            this.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDui.ForeColor = System.Drawing.Color.White;
            this.txtDui.Location = new System.Drawing.Point(317, 275);
            this.txtDui.Margin = new System.Windows.Forms.Padding(2);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(157, 13);
            this.txtDui.TabIndex = 0;
            this.txtDui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DUI del Ciudadano";
            // 
            // btnVerification
            // 
            this.btnVerification.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerification.ForeColor = System.Drawing.Color.White;
            this.btnVerification.Location = new System.Drawing.Point(349, 301);
            this.btnVerification.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerification.Name = "btnVerification";
            this.btnVerification.Size = new System.Drawing.Size(93, 32);
            this.btnVerification.TabIndex = 2;
            this.btnVerification.Text = "Comprobar";
            this.btnVerification.UseVisualStyleBackColor = true;
            this.btnVerification.Click += new System.EventHandler(this.btnVerification_Click);
            // 
            // FrmGetDui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (29)))), ((int) (((byte) (29)))));
            this.ClientSize = new System.Drawing.Size(769, 615);
            this.Controls.Add(this.btnVerification);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGetDui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUI del ciudadano";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        //private System.Windows.Forms.Button btnVerification;

        private System.Windows.Forms.Label label1;
        
        public System.Windows.Forms.TextBox txtDui;

        #endregion
    }
}