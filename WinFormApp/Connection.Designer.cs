using Provider.EntityFramework;
using System;

namespace WinFormApp
{
    partial class Setting
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.emailFromLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.serverInput = new System.Windows.Forms.TextBox();
            this.emailFromInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(175, 18);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(330, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Paramètres SMTP";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serverLabel.Location = new System.Drawing.Point(14, 90);
            this.serverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(101, 19);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "Serveur SMTP :";
            // 
            // emailFromLabel
            // 
            this.emailFromLabel.AutoSize = true;
            this.emailFromLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailFromLabel.Location = new System.Drawing.Point(15, 120);
            this.emailFromLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailFromLabel.Name = "emailFromLabel";
            this.emailFromLabel.Size = new System.Drawing.Size(112, 19);
            this.emailFromLabel.TabIndex = 0;
            this.emailFromLabel.Text = "Adresse d\'envoi :";
            this.emailFromLabel.Click += new System.EventHandler(this.EmailFromLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(14, 150);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 19);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Mot de passe :";
            // 
            // serverInput
            // 
            this.serverInput.Location = new System.Drawing.Point(210, 90);
            this.serverInput.Margin = new System.Windows.Forms.Padding(2);
            this.serverInput.Name = "serverInput";
            this.serverInput.Size = new System.Drawing.Size(211, 23);
            this.serverInput.TabIndex = 1;
            // 
            // emailFromInput
            // 
            this.emailFromInput.Location = new System.Drawing.Point(210, 120);
            this.emailFromInput.Margin = new System.Windows.Forms.Padding(2);
            this.emailFromInput.Name = "emailFromInput";
            this.emailFromInput.Size = new System.Drawing.Size(211, 23);
            this.emailFromInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(210, 150);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(211, 23);
            this.passwordInput.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(210, 210);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(210, 30);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Envoyer";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 361);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.emailFromLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.serverInput);
            this.Controls.Add(this.emailFromInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.sendBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Setting";
            this.Text = "Se connecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label emailFromLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox serverInput;
        private System.Windows.Forms.TextBox emailFromInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button sendBtn;

    }
}

