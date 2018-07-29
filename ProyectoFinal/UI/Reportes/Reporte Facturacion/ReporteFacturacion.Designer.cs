namespace ProyectoFinal.UI.Reportes.Reporte_Facturacion
{
    partial class ReporteFacturacion
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
            this.FacturacioncrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FacturacioncrystalReportViewer
            // 
            this.FacturacioncrystalReportViewer.ActiveViewIndex = -1;
            this.FacturacioncrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacturacioncrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.FacturacioncrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacturacioncrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.FacturacioncrystalReportViewer.Name = "FacturacioncrystalReportViewer";
            this.FacturacioncrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.FacturacioncrystalReportViewer.TabIndex = 0;
            // 
            // ReporteFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FacturacioncrystalReportViewer);
            this.Name = "ReporteFacturacion";
            this.Text = "ReporteFacturacion";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer FacturacioncrystalReportViewer;
    }
}