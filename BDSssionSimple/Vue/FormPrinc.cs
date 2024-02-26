using BDSssionSimple.Vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDSssionSimple {
    public partial class FormPrinc : Form {
        public FormPrinc() {
            InitializeComponent();
            comboBoxCategorie.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> categories = AppliBD.GetTousLesCatégorie();
            foreach (var item in categories)
            {
                comboBoxCategorie.Items.Add(item);
                
            }
            comboBoxCategorie.SelectedIndex = 0;
        }

        private void btAfficheParticipant_Click(object sender, EventArgs e) {
            listBParticipants.Items.Clear();
            List<Participant> listeP = AppliBD.GetTousLesParticipants();
            listBParticipants.Items.AddRange(listeP.ToArray());
        }

        private void listBParticipants_SelectedIndexChanged(object sender, EventArgs e) {
            Participant p = (Participant)listBParticipants.SelectedItem;
            if (p != null) {
                Session.SetParticipantModif(p);
                Session.SetFormPrinc(this);
                this.Hide();
                new FormModifParticipant().Show();
            }
        }

      

        private void btDeconnexion_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show(" Voulez-vous vraiment vous déconnecter  ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) {
                Session.GetGetFormConnexion().Show();
                Session.GetGetFormConnexion().Focus();
                this.Dispose();
            }
            
           
        }

        private void FormPrinc_FormClosing(object sender, FormClosingEventArgs e) {
            MessageBox.Show("Pour quitter déconnectez-vous");
            e.Cancel = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxCategorie.SelectedItem.ToString());
            string selectedCategorie = comboBoxCategorie.SelectedItem.ToString();
            if(selectedCategorie != null)
            {
                Session.SetSelectedCategorie(selectedCategorie);
                this.Hide();
                new FormSearch().Show();

            }
        }

       
    }
}
