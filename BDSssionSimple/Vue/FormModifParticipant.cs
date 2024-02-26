using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDSssionSimple {
    public partial class FormModifParticipant : Form {
        public FormModifParticipant() {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) {

        }
        private void FormModifParticipant_Load(object sender, EventArgs e) {
            Participant p = Session.GetParticipantModif();
            lblId.Text = ""+p.GetId();
            txtNomP.Text = p.GetNom();
            txtMailP.Text = p.GetMail();
            txtBalanceP.Text = ""+ p.GetBalance();
        }
        private void btvaliderModif_Click(object sender, EventArgs e) {
            int id = Convert.ToInt32(lblId.Text); ;
            float bal = Convert.ToSingle(txtBalanceP.Text);
            Participant p = new Participant(id, txtNomP.Text, txtMailP.Text, bal);
            AppliBD.ModifParticipant(p);

            Session.GetFormPrinc().Show();
            this.Hide();
        }

        private void btAnnulerModif_Click(object sender, EventArgs e) {
            Session.GetFormPrinc().Show();
            this.Dispose();
        }

        private void FormModifParticipant_FormClosed(object sender, FormClosedEventArgs e) {
            MessageBox.Show("Test");
           
        }

        private void FormModifParticipant_FormClosing(object sender, FormClosingEventArgs e) {

            DialogResult dr = MessageBox.Show(" Voulez-vous quitter la modification ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) {
                Session.GetFormPrinc().Show();
                this.Dispose();
            }
            else {
                e.Cancel = true;
            }
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }


    }
}
