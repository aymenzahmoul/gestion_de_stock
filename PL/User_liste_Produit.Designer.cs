namespace GestionDeStock.PL
{
    partial class User_liste_Produit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_liste_Produit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgproduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.imprimer_tout = new System.Windows.Forms.Button();
            this.imprimer_PR = new System.Windows.Forms.Button();
            this.sauvgarder = new System.Windows.Forms.Button();
            this.btnmodifer = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgproduit
            // 
            resources.ApplyResources(this.dvgproduit, "dvgproduit");
            this.dvgproduit.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgproduit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgproduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgproduit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgproduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgproduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgproduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgproduit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgproduit.EnableHeadersVisualStyles = false;
            this.dvgproduit.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dvgproduit.Name = "dvgproduit";
            this.dvgproduit.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dvgproduit.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgproduit.RowTemplate.Height = 24;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            resources.ApplyResources(this.Column9, "Column9");
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Name = "panel3";
            // 
            // txtrecherche
            // 
            resources.ApplyResources(this.txtrecherche, "txtrecherche");
            this.txtrecherche.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.ForeColor = System.Drawing.Color.DimGray;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::GestionDeStock.Properties.Resources.Pictures_icon;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imprimer_tout
            // 
            resources.ApplyResources(this.imprimer_tout, "imprimer_tout");
            this.imprimer_tout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.imprimer_tout.FlatAppearance.BorderSize = 0;
            this.imprimer_tout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imprimer_tout.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.imprimer_tout.Name = "imprimer_tout";
            this.imprimer_tout.UseVisualStyleBackColor = false;
            this.imprimer_tout.Click += new System.EventHandler(this.imprimer_tout_Click);
            // 
            // imprimer_PR
            // 
            resources.ApplyResources(this.imprimer_PR, "imprimer_PR");
            this.imprimer_PR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.imprimer_PR.FlatAppearance.BorderSize = 0;
            this.imprimer_PR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imprimer_PR.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.imprimer_PR.Name = "imprimer_PR";
            this.imprimer_PR.UseVisualStyleBackColor = false;
            this.imprimer_PR.Click += new System.EventHandler(this.imprimer_PR_Click);
            // 
            // sauvgarder
            // 
            resources.ApplyResources(this.sauvgarder, "sauvgarder");
            this.sauvgarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.sauvgarder.FlatAppearance.BorderSize = 0;
            this.sauvgarder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sauvgarder.Image = global::GestionDeStock.Properties.Resources.Excel_icon1;
            this.sauvgarder.Name = "sauvgarder";
            this.sauvgarder.UseVisualStyleBackColor = false;
            this.sauvgarder.Click += new System.EventHandler(this.sauvgarder_Click);
            // 
            // btnmodifer
            // 
            resources.ApplyResources(this.btnmodifer, "btnmodifer");
            this.btnmodifer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnmodifer.FlatAppearance.BorderSize = 0;
            this.btnmodifer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmodifer.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btnmodifer.Name = "btnmodifer";
            this.btnmodifer.UseVisualStyleBackColor = false;
            this.btnmodifer.Click += new System.EventHandler(this.btnmodifer_Click);
            // 
            // btnajouter
            // 
            resources.ApplyResources(this.btnajouter, "btnajouter");
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnajouter.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnsuprimer
            // 
            resources.ApplyResources(this.btnsuprimer, "btnsuprimer");
            this.btnsuprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnsuprimer.FlatAppearance.BorderSize = 0;
            this.btnsuprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuprimer.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.UseVisualStyleBackColor = false;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // User_liste_Produit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imprimer_tout);
            this.Controls.Add(this.imprimer_PR);
            this.Controls.Add(this.sauvgarder);
            this.Controls.Add(this.btnmodifer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.dvgproduit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsuprimer);
            this.Name = "User_liste_Produit";
            this.Load += new System.EventHandler(this.User_liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmodifer;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.DataGridView dvgproduit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button imprimer_PR;
        private System.Windows.Forms.Button sauvgarder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.Button imprimer_tout;
        private System.Windows.Forms.Button button1;
    }
}
