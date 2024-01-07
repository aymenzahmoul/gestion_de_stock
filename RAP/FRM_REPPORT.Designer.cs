namespace GestionDeStock.RAP
{
    partial class FRM_REPPORT
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
            this.RPAffiche = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPAffiche
            // 
            this.RPAffiche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPAffiche.Location = new System.Drawing.Point(0, 0);
            this.RPAffiche.Name = "RPAffiche";
            this.RPAffiche.ServerReport.BearerToken = null;
            this.RPAffiche.Size = new System.Drawing.Size(1021, 540);
            this.RPAffiche.TabIndex = 0;
            // 
            // FRM_REPPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 540);
            this.Controls.Add(this.RPAffiche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_REPPORT";
            this.Text = "Rapporte";
            this.Load += new System.EventHandler(this.FRM_REPPORT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RPAffiche;
    }
}