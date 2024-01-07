namespace GestionDeStock.PL
{
    partial class User_list_Commande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnajouterCatgeorie = new System.Windows.Forms.Button();
            this.dvgcategorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifie = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imprimer_tout = new System.Windows.Forms.Button();
            this.sauvgarder = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnajouterCatgeorie
            // 
            this.btnajouterCatgeorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouterCatgeorie.FlatAppearance.BorderSize = 0;
            this.btnajouterCatgeorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterCatgeorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnajouterCatgeorie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnajouterCatgeorie.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnajouterCatgeorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterCatgeorie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnajouterCatgeorie.Location = new System.Drawing.Point(27, 6);
            this.btnajouterCatgeorie.Margin = new System.Windows.Forms.Padding(6);
            this.btnajouterCatgeorie.Name = "btnajouterCatgeorie";
            this.btnajouterCatgeorie.Size = new System.Drawing.Size(251, 56);
            this.btnajouterCatgeorie.TabIndex = 36;
            this.btnajouterCatgeorie.Text = "Ajouter";
            this.btnajouterCatgeorie.UseVisualStyleBackColor = false;
            // 
            // dvgcategorie
            // 
            this.dvgcategorie.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgcategorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgcategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgcategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgcategorie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgcategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgcategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgcategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Modifie,
            this.Supprimer});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgcategorie.DefaultCellStyle = dataGridViewCellStyle11;
            this.dvgcategorie.EnableHeadersVisualStyles = false;
            this.dvgcategorie.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dvgcategorie.Location = new System.Drawing.Point(84, 108);
            this.dvgcategorie.Name = "dvgcategorie";
            this.dvgcategorie.RowHeadersVisible = false;
            this.dvgcategorie.RowHeadersWidth = 30;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dvgcategorie.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dvgcategorie.RowTemplate.Height = 24;
            this.dvgcategorie.Size = new System.Drawing.Size(1042, 377);
            this.dvgcategorie.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom Categorie";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Modifie
            // 
            this.Modifie.HeaderText = "Modifie";
            this.Modifie.MinimumWidth = 6;
            this.Modifie.Name = "Modifie";
            this.Modifie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modifie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modifie.Text = "Modifie";
            this.Modifie.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.MinimumWidth = 6;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(40, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 2);
            this.panel2.TabIndex = 37;
            // 
            // imprimer_tout
            // 
            this.imprimer_tout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imprimer_tout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.imprimer_tout.FlatAppearance.BorderSize = 0;
            this.imprimer_tout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimer_tout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.imprimer_tout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imprimer_tout.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.imprimer_tout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimer_tout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imprimer_tout.Location = new System.Drawing.Point(13, 471);
            this.imprimer_tout.Margin = new System.Windows.Forms.Padding(6);
            this.imprimer_tout.Name = "imprimer_tout";
            this.imprimer_tout.Size = new System.Drawing.Size(265, 56);
            this.imprimer_tout.TabIndex = 41;
            this.imprimer_tout.Text = "imprimer tout";
            this.imprimer_tout.UseVisualStyleBackColor = false;
            // 
            // sauvgarder
            // 
            this.sauvgarder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sauvgarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.sauvgarder.FlatAppearance.BorderSize = 0;
            this.sauvgarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sauvgarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.sauvgarder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sauvgarder.Image = global::GestionDeStock.Properties.Resources.Excel_icon1;
            this.sauvgarder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sauvgarder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sauvgarder.Location = new System.Drawing.Point(946, 471);
            this.sauvgarder.Margin = new System.Windows.Forms.Padding(6);
            this.sauvgarder.Name = "sauvgarder";
            this.sauvgarder.Size = new System.Drawing.Size(245, 56);
            this.sauvgarder.TabIndex = 40;
            this.sauvgarder.Text = "sauvgarder";
            this.sauvgarder.UseVisualStyleBackColor = false;
            // 
            // txtrecherche
            // 
            this.txtrecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrecherche.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtrecherche.ForeColor = System.Drawing.Color.DimGray;
            this.txtrecherche.Location = new System.Drawing.Point(541, 19);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(535, 36);
            this.txtrecherche.TabIndex = 38;
            this.txtrecherche.Text = "Recherche";
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            // 
            // User_list_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnajouterCatgeorie);
            this.Controls.Add(this.dvgcategorie);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.imprimer_tout);
            this.Controls.Add(this.sauvgarder);
            this.Controls.Add(this.txtrecherche);
            this.Name = "User_list_Commande";
            this.Size = new System.Drawing.Size(1197, 527);
            this.Load += new System.EventHandler(this.User_list_Commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajouterCatgeorie;
        private System.Windows.Forms.DataGridView dvgcategorie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Modifie;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button imprimer_tout;
        private System.Windows.Forms.Button sauvgarder;
        private System.Windows.Forms.TextBox txtrecherche;
    }
}
