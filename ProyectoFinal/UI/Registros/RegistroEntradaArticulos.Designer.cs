namespace ProyectoFinal.UI.Registros
{
    partial class RegistroEntradaArticulos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.EntradaArticuloIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ArticulocomboBox = new System.Windows.Forms.ComboBox();
            this.CantidadArticulonumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaArticuloIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadArticulonumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EntradaArticuloID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad Del Articulo";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(137, 165);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(84, 46);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(329, 0);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(84, 46);
            this.Buscarbutton.TabIndex = 12;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(246, 165);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(84, 46);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(42, 165);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(84, 46);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // EntradaArticuloIDnumericUpDown
            // 
            this.EntradaArticuloIDnumericUpDown.Location = new System.Drawing.Point(190, 26);
            this.EntradaArticuloIDnumericUpDown.Name = "EntradaArticuloIDnumericUpDown";
            this.EntradaArticuloIDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.EntradaArticuloIDnumericUpDown.TabIndex = 14;
            // 
            // ArticulocomboBox
            // 
            this.ArticulocomboBox.FormattingEnabled = true;
            this.ArticulocomboBox.Location = new System.Drawing.Point(190, 67);
            this.ArticulocomboBox.Name = "ArticulocomboBox";
            this.ArticulocomboBox.Size = new System.Drawing.Size(121, 21);
            this.ArticulocomboBox.TabIndex = 15;
            // 
            // CantidadArticulonumericUpDown
            // 
            this.CantidadArticulonumericUpDown.Location = new System.Drawing.Point(190, 108);
            this.CantidadArticulonumericUpDown.Name = "CantidadArticulonumericUpDown";
            this.CantidadArticulonumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CantidadArticulonumericUpDown.TabIndex = 16;
            // 
            // RegistroEntradaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 226);
            this.Controls.Add(this.CantidadArticulonumericUpDown);
            this.Controls.Add(this.ArticulocomboBox);
            this.Controls.Add(this.EntradaArticuloIDnumericUpDown);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEntradaArticulos";
            this.Text = "RegistroEntradaArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.EntradaArticuloIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadArticulonumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.NumericUpDown EntradaArticuloIDnumericUpDown;
        private System.Windows.Forms.ComboBox ArticulocomboBox;
        private System.Windows.Forms.NumericUpDown CantidadArticulonumericUpDown;
    }
}