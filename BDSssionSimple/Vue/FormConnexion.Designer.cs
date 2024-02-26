namespace BDSssionSimple {
    partial class FormConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConnexionU = new System.Windows.Forms.Button();
            this.txtPassConn = new System.Windows.Forms.TextBox();
            this.txtNomConn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConnexionU
            // 
            this.btConnexionU.Location = new System.Drawing.Point(24, 103);
            this.btConnexionU.Name = "btConnexionU";
            this.btConnexionU.Size = new System.Drawing.Size(169, 23);
            this.btConnexionU.TabIndex = 41;
            this.btConnexionU.Text = "Connexion utilisateur";
            this.btConnexionU.UseVisualStyleBackColor = true;
            this.btConnexionU.Click += new System.EventHandler(this.btConnexionU_Click);
            // 
            // txtPassConn
            // 
            this.txtPassConn.Location = new System.Drawing.Point(104, 55);
            this.txtPassConn.Name = "txtPassConn";
            this.txtPassConn.PasswordChar = '*';
            this.txtPassConn.Size = new System.Drawing.Size(100, 20);
            this.txtPassConn.TabIndex = 40;
            // 
            // txtNomConn
            // 
            this.txtNomConn.Location = new System.Drawing.Point(104, 28);
            this.txtNomConn.Name = "txtNomConn";
            this.txtNomConn.Size = new System.Drawing.Size(141, 20);
            this.txtNomConn.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Mot de passe :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "nom :";
            // 
            // lblNb
            // 
            this.lblNb.AutoSize = true;
            this.lblNb.Location = new System.Drawing.Point(71, 8);
            this.lblNb.Name = "lblNb";
            this.lblNb.Size = new System.Drawing.Size(35, 13);
            this.lblNb.TabIndex = 42;
            this.lblNb.Text = "label1";
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 144);
            this.Controls.Add(this.lblNb);
            this.Controls.Add(this.btConnexionU);
            this.Controls.Add(this.txtPassConn);
            this.Controls.Add(this.txtNomConn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Name = "FormConnexion";
            this.Text = "FormConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnexionU;
        private System.Windows.Forms.TextBox txtPassConn;
        private System.Windows.Forms.TextBox txtNomConn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNb;
    }
}