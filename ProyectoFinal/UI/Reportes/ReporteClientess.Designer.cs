namespace ProyectoFinal.UI.Reportes.Reporte_Clientes
{
    partial class ReporteClientess
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
            this.ClientecrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ClientecrystalReportViewer
            // 
            this.ClientecrystalReportViewer.ActiveViewIndex = -1;
            this.ClientecrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientecrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientecrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientecrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ClientecrystalReportViewer.Name = "ClientecrystalReportViewer";
            this.ClientecrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ClientecrystalReportViewer.TabIndex = 0;
            this.ClientecrystalReportViewer.Load += new System.EventHandler(this.ClientecrystalReportViewer_Load);
            // 
            // ReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientecrystalReportViewer);
            this.Name = "ReporteClientes";
            this.Text = "ReporteClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ClientecrystalReportViewer;
    }
}