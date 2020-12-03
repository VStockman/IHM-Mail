using Models;
using Provider.EntityFramework;
using Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class CampaignDetails : Form
    {
        private readonly Context context;
        private readonly ContactService contactService;
        public Models.Campaign currentCampagne;
        public List<Contact> contacts;

        public CampaignDetails(Models.Campaign campagneSelected)
        {
            context = new Context();
            contactService = new ContactService(context);
            InitializeComponent();
            currentCampagne = campagneSelected;
            campagneName.Text = currentCampagne.Name;
            LoadEmails();
        }

        public async void LoadEmails()
        {
            listEmailBox.Items.Clear();
            contacts = await contactService.ContactListByCampaign(currentCampagne.Id);
            contacts.ForEach(c =>
            {
                listEmailBox.Items.Add(c.Email);
            });
        }
        public void OpenDialog_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(fileDialog.FileName);
                    ReadFile(sr.ReadToEnd());
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        public async void ReadFile(string text)
        {
            var data = text;
            var emailList = data.Split("\r\n");
            await contactService.AddEmails(currentCampagne, emailList.ToList());
            LoadEmails();
        }

        public async void AddEmail_Click(object sender, EventArgs e)
        {
            var newContact = new Contact();
            newContact.Email = inputEmail.Text;
            newContact.CampaignId = currentCampagne.Id;
            await contactService.AddEmail(newContact);
            inputEmail.Text = null;
            LoadEmails();
        }

        public void MoreInformations_Click(object sender, EventArgs e)
        {
            contactInfoInput.Text = listEmailBox.SelectedItem.ToString();
        }

        public async void UpdateEmail_Click(object sender, EventArgs e)
        {
            await contactService.UpdateContact(contactInfoInput.Text, listEmailBox.SelectedItem.ToString());
            LoadEmails();
            contactInfoInput.Text = null;
        }

        public async void DeleteEmail_Click(object sender, EventArgs e)
        {
            await contactService.DeleteContactByEmail(listEmailBox.SelectedItem.ToString());
            contactInfoInput.Text = null;
            LoadEmails();
        }

        public async void ExportEmails_Click(object sender, EventArgs e)
        {
            var contacts = await contactService.ContactListByCampaign(currentCampagne.Id);
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var location = sfd.FileName;
                using (StreamWriter file = new StreamWriter(location + ".txt", true))
                {
                    contacts.ForEach(c =>
                    {
                        file.WriteLine(c.Email);
                    });
                    
                }
            }
        }

        public async void DeleteDuplicate_Click(object sender, EventArgs e)
        {
            await contactService.DeleteDuplicate(currentCampagne);
            LoadEmails();
        }
        public void SendMail_Click(object sender, EventArgs e)
        {
            var index = listEmailBox.SelectedIndex;
            var nextForm = new SendMail(currentCampagne);
            if (index != -1)
                nextForm = new SendMail(currentCampagne, contacts[index].Email);
            nextForm.Show();
            Hide();
        }

        private void CampaignDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
