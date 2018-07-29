namespace ProyectoFinal.UI.Reportes
{
    partial class ReporteArticulos
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
            this.ReporteArticulocrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReporteArticulocrystalReportViewer
            // 
            this.ReporteArticulocrystalReportViewer.ActiveViewIndex = -1;
            this.ReporteArticulocrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteArticulocrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteArticulocrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteArticulocrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ReporteArticulocrystalReportViewer.Name = "ReporteArticulocrystalReportViewer";
            this.ReporteArticulocrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ReporteArticulocrystalReportViewer.TabIndex = 0;
            this.ReporteArticulocrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ReporteArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReporteArticulocrystalReportViewer);
            this.Name = "ReporteArticulos";
            this.Text = "ReporteArticulos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteArticulocrystalReportViewer;
    }
}