using System.ComponentModel;

namespace VaccinationManagement.Views
{
    partial class FrnSideEffects
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
            this.cmbEffectTypess = new System.Windows.Forms.ComboBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEffectTypess
            // 
            this.cmbEffectTypess.FormattingEnabled = true;
            this.cmbEffectTypess.Location = new System.Drawing.Point(99, 137);
            this.cmbEffectTypess.Name = "cmbEffectTypess";
            this.cmbEffectTypess.Size = new System.Drawing.Size(242, 28);
            this.cmbEffectTypess.TabIndex = 0;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(144, 212);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(56, 26);
            this.txtMinutes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(104, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Efecto secundario desarrollado";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(144, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Retraso de aparicion";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(99, 279);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(90, 29);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Terminar";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(117, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Agregar efectos secundarios ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(206, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "(En minutos)";
            // 
            // FrnSideEffects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 343);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.cmbEffectTypess);
            this.Name = "FrnSideEffects";
            this.Text = "Agregar Efectos Secundarios";
            this.Load += new System.EventHandler(this.FrnSideEffects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ComboBox cmbEffectTypess;
        private System.Windows.Forms.TextBox txtMinutes;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}