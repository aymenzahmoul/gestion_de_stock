namespace GestionDeStock.PL
{
    partial class USER_list_Categorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_list_Categorie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgcategorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifie = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.imprimer_tout = new System.Windows.Forms.Button();
            this.sauvgarder = new System.Windows.Forms.Button();
            this.btnajouterCatgeorie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgcategorie
            // 
            resources.ApplyResources(this.dvgcategorie, "dvgcategorie");
            this.dvgcategorie.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgcategorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgcategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgcategorie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgcategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgcategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Modifie,
            this.Supprimer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgcategorie.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgcategorie.EnableHeadersVisualStyles = false;
            this.dvgcategorie.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dvgcategorie.Name = "dvgcategorie";
            this.dvgcategorie.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dvgcategorie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgcategorie.RowTemplate.Height = 24;
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // Modifie
            // 
            resources.ApplyResources(this.Modifie, "Modifie");
            this.Modifie.Name = "Modifie";
            this.Modifie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modifie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modifie.Text = "Modifie";
            this.Modifie.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            resources.ApplyResources(this.Supprimer, "Supprimer");
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Name = "panel2";
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
            // imprimer_tout
            // 
            resources.ApplyResources(this.imprimer_tout, "imprimer_tout");
            this.imprimer_tout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.imprimer_tout.FlatAppearance.BorderSize = 0;
            this.imprimer_tout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imprimer_tout.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.imprimer_tout.Name = "imprimer_tout";
            this.imprimer_tout.UseVisualStyleBackColor = false;
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
            // 
            // btnajouterCatgeorie
            // 
            resources.ApplyResources(this.btnajouterCatgeorie, "btnajouterCatgeorie");
            this.btnajouterCatgeorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouterCatgeorie.FlatAppearance.BorderSize = 0;
            this.btnajouterCatgeorie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnajouterCatgeorie.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnajouterCatgeorie.Name = "btnajouterCatgeorie";
            this.btnajouterCatgeorie.UseVisualStyleBackColor = false;
            // 
            // USER_list_Categorie
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imprimer_tout);
            this.Controls.Add(this.sauvgarder);
            this.Controls.Add(this.btnajouterCatgeorie);
            this.Controls.Add(this.dvgcategorie);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtrecherche);
            this.Name = "USER_list_Categorie";
            this.Load += new System.EventHandler(this.USER_list_Categorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button imprimer_tout;
        private System.Windows.Forms.Button sauvgarder;
        private System.Windows.Forms.Button btnajouterCatgeorie;
        private System.Windows.Forms.DataGridView dvgcategorie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Modifie;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}
