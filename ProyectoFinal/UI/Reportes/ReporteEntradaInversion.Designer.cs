namespace ProyectoFinal.UI.Reportes
{
    partial class ReporteEntradaInversion
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
            this.EntradaInversioncrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // EntradaInversioncrystalReportViewer
            // 
            this.EntradaInversioncrystalReportViewer.ActiveViewIndex = -1;
            this.EntradaInversioncrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntradaInversioncrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.EntradaInversioncrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntradaInversioncrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.EntradaInversioncrystalReportViewer.Name = "EntradaInversioncrystalReportViewer";
            this.EntradaInversioncrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.EntradaInversioncrystalReportViewer.TabIndex = 0;
            this.EntradaInversioncrystalReportViewer.Load += new System.EventHandler(this.EntradaInversioncrystalReportViewer_Load);
            // 
            // ReporteEntradaInversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EntradaInversioncrystalReportViewer);
            this.Name = "ReporteEntradaInversion";
            this.Text = "ReporteEntradaInversion";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer EntradaInversioncrystalReportViewer;
    }
}