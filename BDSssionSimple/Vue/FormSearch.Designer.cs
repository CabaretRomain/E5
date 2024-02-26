namespace BDSssionSimple.Vue
{
    partial class FormSearch
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
            this.listBParticipants = new System.Windows.Forms.ListBox();
            this.txtCategorie = new System.Windows.Forms.Label();
            this.btnLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBParticipants
            // 
            this.listBParticipants.FormattingEnabled = true;
            this.listBParticipants.ItemHeight = 20;
            this.listBParticipants.Location = new System.Drawing.Point(234, 74);
            this.listBParticipants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBParticipants.Name = "listBParticipants";
            this.listBParticipants.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBParticipants.Size = new System.Drawing.Size(320, 284);
            this.listBParticipants.TabIndex = 19;
            // 
            // txtCategorie
            // 
            this.txtCategorie.AutoSize = true;
            this.txtCategorie.Location = new System.Drawing.Point(374, 25);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(51, 20);
            this.txtCategorie.TabIndex = 20;
            this.txtCategorie.Text = "label1";
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(29, 25);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(147, 47);
            this.btnLeave.TabIndex = 21;
            this.btnLeave.Text = "Retour";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.listBParticipants);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrinc_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBParticipants;
        private System.Windows.Forms.Label txtCategorie;
        private System.Windows.Forms.Button btnLeave;
    }
}