namespace ProyectoFinal.UI.Registros
{
    partial class InversionEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.Montolabel = new System.Windows.Forms.Label();
            this.Refrescarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversion";
            // 
            // Montolabel
            // 
            this.Montolabel.AutoSize = true;
            this.Montolabel.Location = new System.Drawing.Point(96, 81);
            this.Montolabel.Name = "Montolabel";
            this.Montolabel.Size = new System.Drawing.Size(13, 13);
            this.Montolabel.TabIndex = 1;
            this.Montolabel.Text = "$";
            // 
            // Refrescarbutton
            // 
            this.Refrescarbutton.Location = new System.Drawing.Point(68, 116);
            this.Refrescarbutton.Name = "Refrescarbutton";
            this.Refrescarbutton.Size = new System.Drawing.Size(75, 23);
            this.Refrescarbutton.TabIndex = 2;
            this.Refrescarbutton.Text = "Refrescar";
            this.Refrescarbutton.UseVisualStyleBackColor = true;
            this.Refrescarbutton.Click += new System.EventHandler(this.Refrescarbutton_Click);
            // 
            // InversionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 221);
            this.Controls.Add(this.Refrescarbutton);
            this.Controls.Add(this.Montolabel);
            this.Controls.Add(this.label1);
            this.Name = "InversionEmpresa";
            this.Text = "Inversion";
            this.Load += new System.EventHandler(this.InversionEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Montolabel;
        private System.Windows.Forms.Button Refrescarbutton;
    }
}