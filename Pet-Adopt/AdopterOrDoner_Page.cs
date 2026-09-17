using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pet_Adopt
{
    public partial class AdopterOrDoner_Page : Form
    {
        public AdopterOrDoner_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adopter_Page adopterPage = new Adopter_Page();
            adopterPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Donor_Page donorPage = new Donor_Page();
            donorPage.Show();
            this.Hide();
        }
    }
}
