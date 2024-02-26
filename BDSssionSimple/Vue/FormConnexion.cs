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
    public partial class FormConnexion : Form {
        public FormConnexion() {
            InitializeComponent();
           
        }

        private void btConnexionU_Click(object sender, EventArgs e) {
            
            char typeU = AppliBD.ConnexionUtilisateur(txtNomConn.Text, txtPassConn.Text);
       
            if (typeU == 'I') {
              
                MessageBox.Show("Erreur d'identification");
            }
            else {
                Session.SetTypeU(typeU);
                new FormPrinc().Show();
                Session.SetformConnexion(this);
                this.Hide();
            }
        }


    }
}
