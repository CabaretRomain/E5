using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDSssionSimple.Vue
{
    public partial class FormSearch : Form
    {
        private string categorie;
        public FormSearch()
        {
            InitializeComponent();

            categorie = Session.GetSelectedCategorie();
            txtCategorie.Text = categorie;

            listBParticipants.Items.Clear();
            List<Participant> listeP = AppliBD.SearchParticipant(categorie);
            listBParticipants.Items.AddRange(listeP.ToArray());

        }
        private void FormPrinc_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Pour quitter déconnectez-vous");
            e.Cancel = true;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormPrinc().Show();
        }
    }
}
