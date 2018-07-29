namespace ProyectoFinal.UI.Reportes.Reporte_Entrada_Articulos
{
    partial class ReporteEntrada
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
            this.EntradaArticulocrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // EntradaArticulocrystalReportViewer
            // 
            this.EntradaArticulocrystalReportViewer.ActiveViewIndex = -1;
            this.EntradaArticulocrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntradaArticulocrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.EntradaArticulocrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntradaArticulocrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.EntradaArticulocrystalReportViewer.Name = "EntradaArticulocrystalReportViewer";
            this.EntradaArticulocrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.EntradaArticulocrystalReportViewer.TabIndex = 0;
            this.EntradaArticulocrystalReportViewer.Load += new System.EventHandler(this.EntradaArticulocrystalReportViewer_Load);
            // 
            // ReporteEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EntradaArticulocrystalReportViewer);
            this.Name = "ReporteEntrada";
            this.Text = "ReporteEntrada";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer EntradaArticulocrystalReportViewer;
    }
}