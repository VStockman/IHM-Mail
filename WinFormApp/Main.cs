using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void NextIHM_Click(object sender, EventArgs e)
        {
            Hide();
            var nextForm = new Campaign();
            nextForm.Show();
        }

        private void CampagneLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
