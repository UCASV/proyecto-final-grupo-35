using System.ComponentModel;

namespace VaccinationManagement.Views.Main_Window
{
    partial class FrmGraphics
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
            this.pnlWindow = new System.Windows.Forms.Panel();
            this.tmrHour = new System.Windows.Forms.Timer(this.components);
            this.lblHour = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEffects = new System.Windows.Forms.Label();
            this.btnShowGraphics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlWindow
            // 
            this.pnlWindow.Location = new System.Drawing.Point(35, 62);
            this.pnlWindow.Name = "pnlWindow";
            this.pnlWindow.Size = new System.Drawing.Size(703, 429);
            this.pnlWindow.TabIndex = 0;
            // 
            // tmrHour
            // 
            this.tmrHour.Enabled = true;
            this.tmrHour.Tick += new System.EventHandler(this.tmrHour_Tick);
            // 
            // lblHour
            // 
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHour.ForeColor = System.Drawing.Color.White;
            this.lblHour.Location = new System.Drawing.Point(246, 505);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(318, 62);
            this.lblHour.TabIndex = 1;
            this.lblHour.Text = "label1";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(271, 557);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(257, 39);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEffects
            // 
            this.lblEffects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEffects.ForeColor = System.Drawing.Color.White;
            this.lblEffects.Location = new System.Drawing.Point(114, 9);
            this.lblEffects.Name = "lblEffects";
            this.lblEffects.Size = new System.Drawing.Size(577, 50);
            this.lblEffects.TabIndex = 3;
            this.lblEffects.Text = "GRAFICO DE DATOS DE EFECTOS SECUNDARIOS";
            this.lblEffects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowGraphics
            // 
            this.btnShowGraphics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGraphics.ForeColor = System.Drawing.Color.White;
            this.btnShowGraphics.Location = new System.Drawing.Point(648, 497);
            this.btnShowGraphics.Name = "btnShowGraphics";
            this.btnShowGraphics.Size = new System.Drawing.Size(90, 36);
            this.btnShowGraphics.TabIndex = 4;
            this.btnShowGraphics.Text = "Mostrar mas";
            this.btnShowGraphics.UseVisualStyleBackColor = true;
            // 
            // FrmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (28)))), ((int) (((byte) (29)))), ((int) (((byte) (29)))));
            this.ClientSize = new System.Drawing.Size(769, 615);
            this.Controls.Add(this.btnShowGraphics);
            this.Controls.Add(this.lblEffects);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.pnlWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGraphics";
            this.Text = "FrmGraphics";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnShowGraphics;

        private System.Windows.Forms.Label lblEffects;

        private System.Windows.Forms.Label lblDate;

        private System.Windows.Forms.Label lblHour;

        private System.Windows.Forms.Timer tmrHour;

        private System.Windows.Forms.Panel pnlWindow;

        #endregion
    }
}