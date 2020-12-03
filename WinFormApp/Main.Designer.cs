using Provider.EntityFramework;
using System;

namespace WinFormApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.campagneLabel = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campagneLabel
            // 
            this.campagneLabel.AutoSize = true;
            this.campagneLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneLabel.Location = new System.Drawing.Point(150, 115);
            this.campagneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.campagneLabel.Name = "campagneLabel";
            this.campagneLabel.Size = new System.Drawing.Size(516, 31);
            this.campagneLabel.TabIndex = 0;
            this.campagneLabel.Text = "Bienvenue sur votre logiciel de campagne de mails !";
            this.campagneLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.campagneLabel.Click += new System.EventHandler(this.CampagneLabel_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.AutoSize = true;
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextBtn.Location = new System.Drawing.Point(298, 228);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(178, 30);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Cliquez ici pour continuer";
            this.nextBtn.Click += new System.EventHandler(this.NextIHM_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 361);
            this.Controls.Add(this.campagneLabel);
            this.Controls.Add(this.nextBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "IHM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label campagneLabel;
        private System.Windows.Forms.Button nextBtn;
    }
}

