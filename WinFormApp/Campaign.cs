using Provider.EntityFramework;
using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Campaign : Form
    {
        private readonly Context context;
        private readonly CampaignService campagneService;
        public List<Models.Campaign> listCampagne;
        public Campaign()
        {
            context = new Context();
            campagneService = new CampaignService(context);
            InitializeComponent();
            LoadCampagne();
            
        }
        public async void AddCampagne_Click(object sender, EventArgs e)
        {
            var newCampagne = new Models.Campaign();
            newCampagne.Name = inputName.Text;
            await campagneService.AddCampaign(newCampagne);
            inputName.Text = null;
            LoadCampagne();
        }        
        
        public void OpenIHMCampagne_Click(object sender, EventArgs e)
        {
            Hide();
            var index = listBoxEmailCampagne.SelectedIndex;
            var campagneSelected = listCampagne[index];
            var nextForm = new CampaignDetails(campagneSelected);
            nextForm.Show();
        }

        public async void LoadCampagne()
        {
            listBoxEmailCampagne.Items.Clear();
            listCampagne = await campagneService.CampaignList();
            listCampagne.ForEach(c =>
            {
                listBoxEmailCampagne.Items.Add(c.Name);
            });
        }
    }
}
