namespace ProyectoFinal.UI.Registros
{
    partial class RegistroPagoCliente
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
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Consultabutton = new System.Windows.Forms.Button();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Deuda = new System.Windows.Forms.Label();
            this.AbonadotextBox = new System.Windows.Forms.TextBox();
            this.DeudatextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(240, 64);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.HastadateTimePicker.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Fecha Hasta";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(41, 65);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.DesdedateTimePicker.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Fecha Desde";
            // 
            // Consultabutton
            // 
            this.Consultabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultabutton.Location = new System.Drawing.Point(496, 13);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(108, 49);
            this.Consultabutton.TabIndex = 71;
            this.Consultabutton.Text = "Consultar";
            this.Consultabutton.UseVisualStyleBackColor = true;
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Items.AddRange(new object[] {
            "ID",
            "Codigo del Articulo",
            "Nombre del Articulo",
            "Marca del Articulo",
            "Fecha",
            "Listar Todo"});
            this.TipocomboBox.Location = new System.Drawing.Point(41, 12);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(121, 21);
            this.TipocomboBox.TabIndex = 70;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(240, 13);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(128, 20);
            this.CriteriotextBox.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Criterio";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(6, 20);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(29, 13);
            this.Tipo.TabIndex = 67;
            this.Tipo.Text = "Filtro";
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 104);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(592, 324);
            this.ConsultadataGridView.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Abonado";
            // 
            // Deuda
            // 
            this.Deuda.AutoSize = true;
            this.Deuda.Location = new System.Drawing.Point(637, 434);
            this.Deuda.Name = "Deuda";
            this.Deuda.Size = new System.Drawing.Size(39, 13);
            this.Deuda.TabIndex = 77;
            this.Deuda.Text = "Deuda";
            // 
            // AbonadotextBox
            // 
            this.AbonadotextBox.Location = new System.Drawing.Point(520, 431);
            this.AbonadotextBox.Name = "AbonadotextBox";
            this.AbonadotextBox.Size = new System.Drawing.Size(100, 20);
            this.AbonadotextBox.TabIndex = 78;
            // 
            // DeudatextBox
            // 
            this.DeudatextBox.Location = new System.Drawing.Point(679, 434);
            this.DeudatextBox.Name = "DeudatextBox";
            this.DeudatextBox.Size = new System.Drawing.Size(100, 20);
            this.DeudatextBox.TabIndex = 79;
            // 
            // RegistroPagoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.DeudatextBox);
            this.Controls.Add(this.AbonadotextBox);
            this.Controls.Add(this.Deuda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.TipocomboBox);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "RegistroPagoCliente";
            this.Text = "RegistroPagoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Deuda;
        private System.Windows.Forms.TextBox AbonadotextBox;
        private System.Windows.Forms.TextBox DeudatextBox;
    }
}