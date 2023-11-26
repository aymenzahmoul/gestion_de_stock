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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.dvgproduit.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgproduit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgproduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dvgproduit.Location = new System.Drawing.Point(29, 209);
            this.dvgproduit.Name = "dvgproduit";
            this.dvgproduit.RowHeadersVisible = false;
            this.dvgproduit.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dvgproduit.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgproduit.RowTemplate.Height = 24;
            this.dvgproduit.Size = new System.Drawing.Size(1002, 403);
            this.dvgproduit.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
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
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Categorie";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nom",
            "Categorie"});
            this.comboBox1.Location = new System.Drawing.Point(132, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(649, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 2);
            this.panel3.TabIndex = 17;
            // 
            // txtrecherche
            // 
            this.txtrecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrecherche.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.Color.DimGray;
            this.txtrecherche.Location = new System.Drawing.Point(649, 125);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(266, 36);
            this.txtrecherche.TabIndex = 16;
            this.txtrecherche.Text = "Recherche";
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(6, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 2);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(6, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 2);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imprimer_tout
            // 
            this.imprimer_tout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imprimer_tout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.imprimer_tout.FlatAppearance.BorderSize = 0;
            this.imprimer_tout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimer_tout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimer_tout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imprimer_tout.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.imprimer_tout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimer_tout.Location = new System.Drawing.Point(420, 633);
            this.imprimer_tout.Margin = new System.Windows.Forms.Padding(6);
            this.imprimer_tout.Name = "imprimer_tout";
            this.imprimer_tout.Size = new System.Drawing.Size(282, 56);
            this.imprimer_tout.TabIndex = 23;
            this.imprimer_tout.Text = "imprimer tout";
            this.imprimer_tout.UseVisualStyleBackColor = false;
            // 
            // imprimer_PR
            // 
            this.imprimer_PR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imprimer_PR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.imprimer_PR.FlatAppearance.BorderSize = 0;
            this.imprimer_PR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimer_PR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimer_PR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imprimer_PR.Image = global::GestionDeStock.Properties.Resources.Imprimer;
            this.imprimer_PR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimer_PR.Location = new System.Drawing.Point(29, 633);
            this.imprimer_PR.Margin = new System.Windows.Forms.Padding(6);
            this.imprimer_PR.Name = "imprimer_PR";
            this.imprimer_PR.Size = new System.Drawing.Size(260, 56);
            this.imprimer_PR.TabIndex = 21;
            this.imprimer_PR.Text = "imprimer PR";
            this.imprimer_PR.UseVisualStyleBackColor = false;
            // 
            // sauvgarder
            // 
            this.sauvgarder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sauvgarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.sauvgarder.FlatAppearance.BorderSize = 0;
            this.sauvgarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sauvgarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sauvgarder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sauvgarder.Image = global::GestionDeStock.Properties.Resources.Excel_icon1;
            this.sauvgarder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sauvgarder.Location = new System.Drawing.Point(786, 633);
            this.sauvgarder.Margin = new System.Windows.Forms.Padding(6);
            this.sauvgarder.Name = "sauvgarder";
            this.sauvgarder.Size = new System.Drawing.Size(245, 56);
            this.sauvgarder.TabIndex = 22;
            this.sauvgarder.Text = "sauvgarder";
            this.sauvgarder.UseVisualStyleBackColor = false;
            // 
            // btnmodifer
            // 
            this.btnmodifer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodifer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnmodifer.FlatAppearance.BorderSize = 0;
            this.btnmodifer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmodifer.Image = global::GestionDeStock.Properties.Resources.Recycle_iconaaa;
            this.btnmodifer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifer.Location = new System.Drawing.Point(445, 19);
            this.btnmodifer.Margin = new System.Windows.Forms.Padding(6);
            this.btnmodifer.Name = "btnmodifer";
            this.btnmodifer.Size = new System.Drawing.Size(201, 56);
            this.btnmodifer.TabIndex = 13;
            this.btnmodifer.Text = "Modifier";
            this.btnmodifer.UseVisualStyleBackColor = false;
            this.btnmodifer.Click += new System.EventHandler(this.btnmodifer_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnajouter.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(29, 19);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(6);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(193, 56);
            this.btnajouter.TabIndex = 11;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsuprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnsuprimer.FlatAppearance.BorderSize = 0;
            this.btnsuprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuprimer.Image = global::GestionDeStock.Properties.Resources.Close_2_icon;
            this.btnsuprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuprimer.Location = new System.Drawing.Point(828, 19);
            this.btnsuprimer.Margin = new System.Windows.Forms.Padding(6);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(203, 56);
            this.btnsuprimer.TabIndex = 12;
            this.btnsuprimer.Text = "Supprimer";
            this.btnsuprimer.UseVisualStyleBackColor = false;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // User_liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imprimer_tout);
            this.Controls.Add(this.imprimer_PR);
            this.Controls.Add(this.sauvgarder);
            this.Controls.Add(this.btnmodifer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.dvgproduit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsuprimer);
            this.Name = "User_liste_Produit";
            this.Size = new System.Drawing.Size(1064, 705);
            this.Load += new System.EventHandler(this.User_liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmodifer;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.DataGridView dvgproduit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button imprimer_tout;
        private System.Windows.Forms.Button imprimer_PR;
        private System.Windows.Forms.Button sauvgarder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
