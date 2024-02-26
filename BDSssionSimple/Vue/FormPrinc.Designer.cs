namespace BDSssionSimple {
    partial class FormPrinc {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.listBParticipants = new System.Windows.Forms.ListBox();
            this.btAfficheParticipant = new System.Windows.Forms.Button();
            this.btDeconnexion = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBParticipants
            // 
            this.listBParticipants.FormattingEnabled = true;
            this.listBParticipants.ItemHeight = 20;
            this.listBParticipants.Location = new System.Drawing.Point(70, 172);
            this.listBParticipants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBParticipants.Name = "listBParticipants";
            this.listBParticipants.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBParticipants.Size = new System.Drawing.Size(320, 284);
            this.listBParticipants.TabIndex = 18;
            this.listBParticipants.SelectedIndexChanged += new System.EventHandler(this.listBParticipants_SelectedIndexChanged);
            // 
            // btAfficheParticipant
            // 
            this.btAfficheParticipant.Location = new System.Drawing.Point(70, 88);
            this.btAfficheParticipant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAfficheParticipant.Name = "btAfficheParticipant";
            this.btAfficheParticipant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btAfficheParticipant.Size = new System.Drawing.Size(274, 35);
            this.btAfficheParticipant.TabIndex = 20;
            this.btAfficheParticipant.Text = "Afficher les participants";
            this.btAfficheParticipant.UseVisualStyleBackColor = true;
            this.btAfficheParticipant.Click += new System.EventHandler(this.btAfficheParticipant_Click);
            // 
            // btDeconnexion
            // 
            this.btDeconnexion.Location = new System.Drawing.Point(418, 494);
            this.btDeconnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeconnexion.Name = "btDeconnexion";
            this.btDeconnexion.Size = new System.Drawing.Size(237, 34);
            this.btDeconnexion.TabIndex = 21;
            this.btDeconnexion.Text = "Déconnexion";
            this.btDeconnexion.UseVisualStyleBackColor = true;
            this.btDeconnexion.Click += new System.EventHandler(this.btDeconnexion_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(497, 233);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 43);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(497, 172);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(158, 28);
            this.comboBoxCategorie.TabIndex = 22;
            // 
            // FormPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.btDeconnexion);
            this.Controls.Add(this.btAfficheParticipant);
            this.Controls.Add(this.listBParticipants);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrinc";
            this.Text = "Form Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrinc_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBParticipants;
        private System.Windows.Forms.Button btAfficheParticipant;
        private System.Windows.Forms.Button btDeconnexion;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
    }
}

