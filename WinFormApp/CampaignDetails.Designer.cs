using Provider.EntityFramework;
using System;

namespace WinFormApp
{
    partial class CampaignDetails
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
            this.campagneName = new System.Windows.Forms.Label();
            this.listEmailBox = new System.Windows.Forms.ListBox();
            this.importBtn = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.importEmail = new System.Windows.Forms.Button();
            this.contactInfoInput = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.doublonBtn = new System.Windows.Forms.Button();
            this.sendMailBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campagneLabel
            // 
            this.campagneLabel.AutoSize = true;
            this.campagneLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneLabel.Location = new System.Drawing.Point(350, 18);
            this.campagneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.campagneLabel.Name = "campagneLabel";
            this.campagneLabel.Size = new System.Drawing.Size(234, 54);
            this.campagneLabel.TabIndex = 0;
            this.campagneLabel.Text = "Campagne :";
            // 
            // campagneName
            // 
            this.campagneName.AutoSize = true;
            this.campagneName.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneName.Location = new System.Drawing.Point(595, 18);
            this.campagneName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.campagneName.Name = "campagneName";
            this.campagneName.Size = new System.Drawing.Size(0, 54);
            this.campagneName.TabIndex = 0;
            // 
            // listEmailBox
            // 
            this.listEmailBox.FormattingEnabled = true;
            this.listEmailBox.ItemHeight = 15;
            this.listEmailBox.Location = new System.Drawing.Point(14, 120);
            this.listEmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.listEmailBox.Name = "listEmailBox";
            this.listEmailBox.Size = new System.Drawing.Size(736, 229);
            this.listEmailBox.TabIndex = 4;
            this.listEmailBox.Click += new System.EventHandler(this.MoreInformations_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(599, 88);
            this.importBtn.Margin = new System.Windows.Forms.Padding(2);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(70, 24);
            this.importBtn.TabIndex = 5;
            this.importBtn.Text = "Importer";
            this.importBtn.Click += new System.EventHandler(this.OpenDialog_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addLabel.Location = new System.Drawing.Point(14, 87);
            this.addLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(95, 19);
            this.addLabel.TabIndex = 6;
            this.addLabel.Text = "Nouvel email :";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(126, 90);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(2);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(211, 23);
            this.inputEmail.TabIndex = 7;
            // 
            // importEmail
            // 
            this.importEmail.Location = new System.Drawing.Point(350, 87);
            this.importEmail.Margin = new System.Windows.Forms.Padding(2);
            this.importEmail.Name = "importEmail";
            this.importEmail.Size = new System.Drawing.Size(77, 24);
            this.importEmail.TabIndex = 8;
            this.importEmail.Text = "Ajouter";
            this.importEmail.Click += new System.EventHandler(this.AddEmail_Click);
            // 
            // contactInfoInput
            // 
            this.contactInfoInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactInfoInput.Location = new System.Drawing.Point(760, 180);
            this.contactInfoInput.Margin = new System.Windows.Forms.Padding(2);
            this.contactInfoInput.Name = "contactInfoInput";
            this.contactInfoInput.Size = new System.Drawing.Size(281, 25);
            this.contactInfoInput.TabIndex = 9;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(760, 240);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(70, 24);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Modifier";
            this.updateBtn.Click += new System.EventHandler(this.UpdateEmail_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(959, 240);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(77, 24);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Supprimer";
            this.deleteBtn.Click += new System.EventHandler(this.DeleteEmail_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(673, 87);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(77, 24);
            this.exportBtn.TabIndex = 11;
            this.exportBtn.Text = "Exporter";
            this.exportBtn.Click += new System.EventHandler(this.ExportEmails_Click);
            // 
            // doublonBtn
            // 
            this.doublonBtn.Location = new System.Drawing.Point(441, 87);
            this.doublonBtn.Margin = new System.Windows.Forms.Padding(2);
            this.doublonBtn.Name = "doublonBtn";
            this.doublonBtn.Size = new System.Drawing.Size(140, 24);
            this.doublonBtn.TabIndex = 12;
            this.doublonBtn.Text = "Supprimer Doublons";
            this.doublonBtn.Click += new System.EventHandler(this.DeleteDuplicate_Click);
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.Location = new System.Drawing.Point(840, 87);
            this.sendMailBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(140, 24);
            this.sendMailBtn.TabIndex = 12;
            this.sendMailBtn.Text = "Envoyer Email";
            this.sendMailBtn.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // CampaignDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 360);
            this.Controls.Add(this.campagneLabel);
            this.Controls.Add(this.campagneName);
            this.Controls.Add(this.listEmailBox);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.importEmail);
            this.Controls.Add(this.contactInfoInput);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.doublonBtn);
            this.Controls.Add(this.sendMailBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CampaignDetails";
            this.Text = "Liste de campagnes";
            this.Load += new System.EventHandler(this.CampaignDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label campagneLabel;
        private System.Windows.Forms.Label campagneName;
        private System.Windows.Forms.ListBox listEmailBox;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Button importEmail;
        private System.Windows.Forms.TextBox contactInfoInput;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button doublonBtn;
        private System.Windows.Forms.Button sendMailBtn;

    }
}

