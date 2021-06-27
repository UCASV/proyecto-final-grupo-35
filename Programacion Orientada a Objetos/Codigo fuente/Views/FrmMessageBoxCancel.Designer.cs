using System.ComponentModel;

namespace VaccinationManagement.Views
{
    partial class FrmMessageBoxCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageBoxCancel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Desea cancelar el evento?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(162, 125);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(72, 26);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "SI";
            this.btnYes.UseVisualStyleBackColor = true;
            
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (29)))), ((int) (((byte) (29)))));
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(25, 125);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(72, 26);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
          
            // 
            // FrmMessageBoxCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (29)))), ((int) (((byte) (29)))));
            this.ClientSize = new System.Drawing.Size(254, 163);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMessageBoxCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMessageBoxCancel";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}