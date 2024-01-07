namespace GestionDeStock.PL
{
    partial class FRM_Photo_Produit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.produitimage = new System.Windows.Forms.Panel();
            this.btnquitte = new System.Windows.Forms.Button();
            this.Produitname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 2);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 408);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(552, 2);
            this.panel6.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(550, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 406);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 406);
            this.panel3.TabIndex = 5;
            // 
            // produitimage
            // 
            this.produitimage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produitimage.BackColor = System.Drawing.Color.White;
            this.produitimage.Location = new System.Drawing.Point(8, 61);
            this.produitimage.Name = "produitimage";
            this.produitimage.Size = new System.Drawing.Size(536, 341);
            this.produitimage.TabIndex = 6;
            this.produitimage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnquitte
            // 
            this.btnquitte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnquitte.FlatAppearance.BorderSize = 0;
            this.btnquitte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitte.Image = global::GestionDeStock.Properties.Resources.Button_Delete_icon;
            this.btnquitte.Location = new System.Drawing.Point(508, 12);
            this.btnquitte.Name = "btnquitte";
            this.btnquitte.Size = new System.Drawing.Size(32, 23);
            this.btnquitte.TabIndex = 63;
            this.btnquitte.UseVisualStyleBackColor = true;
            this.btnquitte.Click += new System.EventHandler(this.btnquitte_Click);
            // 
            // Produitname
            // 
            this.Produitname.AutoSize = true;
            this.Produitname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produitname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Produitname.Location = new System.Drawing.Point(171, 12);
            this.Produitname.Name = "Produitname";
            this.Produitname.Size = new System.Drawing.Size(195, 32);
            this.Produitname.TabIndex = 64;
            this.Produitname.Text = "ProduitImage";
            // 
            // FRM_Photo_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(552, 410);
            this.Controls.Add(this.Produitname);
            this.Controls.Add(this.btnquitte);
            this.Controls.Add(this.produitimage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Photo_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Photo_Produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnquitte;
        public System.Windows.Forms.Panel produitimage;
        public System.Windows.Forms.Label Produitname;
    }
}