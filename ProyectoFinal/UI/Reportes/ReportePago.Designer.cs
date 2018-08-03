namespace ProyectoFinal.UI.Reportes
{
    partial class ReportePago
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
            this.PagocrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PagocrystalReportViewer
            // 
            this.PagocrystalReportViewer.ActiveViewIndex = -1;
            this.PagocrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PagocrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PagocrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagocrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PagocrystalReportViewer.Name = "PagocrystalReportViewer";
            this.PagocrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.PagocrystalReportViewer.TabIndex = 0;
            this.PagocrystalReportViewer.Load += new System.EventHandler(this.PagocrystalReportViewer_Load);
            // 
            // ReportePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PagocrystalReportViewer);
            this.Name = "ReportePago";
            this.Text = "ReportePago";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer PagocrystalReportViewer;
    }
}