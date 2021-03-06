﻿namespace ProyectoFinal.UI.Registros
{
    partial class RegistroFacturacion
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FacturaIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VentacomboBox = new System.Windows.Forms.ComboBox();
            this.ArticulocomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.FacturaciondataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.MontonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.FacturacionerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.DevueltanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaciondataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevueltanumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FacturaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(84, 102);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(121, 21);
            this.ClientecomboBox.TabIndex = 2;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(273, 102);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechadateTimePicker.TabIndex = 5;
            // 
            // FacturaIDnumericUpDown
            // 
            this.FacturaIDnumericUpDown.Location = new System.Drawing.Point(84, 13);
            this.FacturaIDnumericUpDown.Name = "FacturaIDnumericUpDown";
            this.FacturaIDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.FacturaIDnumericUpDown.TabIndex = 0;
            // 
            // VentacomboBox
            // 
            this.VentacomboBox.FormattingEnabled = true;
            this.VentacomboBox.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.VentacomboBox.Location = new System.Drawing.Point(84, 56);
            this.VentacomboBox.Name = "VentacomboBox";
            this.VentacomboBox.Size = new System.Drawing.Size(121, 21);
            this.VentacomboBox.TabIndex = 1;
            this.VentacomboBox.SelectedIndexChanged += new System.EventHandler(this.VentacomboBox_SelectedIndexChanged);
            // 
            // ArticulocomboBox
            // 
            this.ArticulocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArticulocomboBox.FormattingEnabled = true;
            this.ArticulocomboBox.Location = new System.Drawing.Point(2, 155);
            this.ArticulocomboBox.Name = "ArticulocomboBox";
            this.ArticulocomboBox.Size = new System.Drawing.Size(121, 21);
            this.ArticulocomboBox.TabIndex = 3;
            this.ArticulocomboBox.SelectedIndexChanged += new System.EventHandler(this.ArticulocomboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Articulo";
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(292, 156);
            this.PrecionumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.ReadOnly = true;
            this.PrecionumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PrecionumericUpDown.TabIndex = 5;
            this.PrecionumericUpDown.ValueChanged += new System.EventHandler(this.PrecionumericUpDown_ValueChanged);
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(145, 156);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CantidadnumericUpDown.TabIndex = 4;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Precio Venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Subtotal";
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Location = new System.Drawing.Point(542, 371);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.ReadOnly = true;
            this.SubtotaltextBox.Size = new System.Drawing.Size(118, 20);
            this.SubtotaltextBox.TabIndex = 78;
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::ProyectoFinal.Properties.Resources.restar_16;
            this.Removerbutton.Location = new System.Drawing.Point(595, 154);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(74, 30);
            this.Removerbutton.TabIndex = 8;
            this.Removerbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = global::ProyectoFinal.Properties.Resources.Sumar_16;
            this.Agregarbutton.Location = new System.Drawing.Point(595, 123);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(74, 30);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // FacturaciondataGridView
            // 
            this.FacturaciondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturaciondataGridView.Location = new System.Drawing.Point(2, 186);
            this.FacturaciondataGridView.Name = "FacturaciondataGridView";
            this.FacturaciondataGridView.Size = new System.Drawing.Size(667, 180);
            this.FacturaciondataGridView.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "Total";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(542, 410);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 83;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinal.Properties.Resources.save_32;
            this.Guardarbutton.Location = new System.Drawing.Point(316, 464);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(84, 54);
            this.Guardarbutton.TabIndex = 85;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoFinal.Properties.Resources.search_32;
            this.Buscarbutton.Location = new System.Drawing.Point(221, 2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(84, 53);
            this.Buscarbutton.TabIndex = 86;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoFinal.Properties.Resources.delete_32;
            this.Eliminarbutton.Location = new System.Drawing.Point(425, 464);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(84, 54);
            this.Eliminarbutton.TabIndex = 87;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoFinal.Properties.Resources.new_32;
            this.Nuevobutton.Location = new System.Drawing.Point(221, 464);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(84, 54);
            this.Nuevobutton.TabIndex = 84;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "Monto";
            // 
            // MontonumericUpDown
            // 
            this.MontonumericUpDown.Location = new System.Drawing.Point(64, 375);
            this.MontonumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MontonumericUpDown.Name = "MontonumericUpDown";
            this.MontonumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MontonumericUpDown.TabIndex = 89;
            this.MontonumericUpDown.ValueChanged += new System.EventHandler(this.MontonumericUpDown_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 90;
            this.label11.Text = "Devuelta";
            // 
            // FacturacionerrorProvider
            // 
            this.FacturacionerrorProvider.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(491, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 92;
            this.label12.Text = "Importe";
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(470, 155);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportetextBox.TabIndex = 6;
            // 
            // DevueltanumericUpDown
            // 
            this.DevueltanumericUpDown.Location = new System.Drawing.Point(247, 375);
            this.DevueltanumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.DevueltanumericUpDown.Name = "DevueltanumericUpDown";
            this.DevueltanumericUpDown.ReadOnly = true;
            this.DevueltanumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DevueltanumericUpDown.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.Image = global::ProyectoFinal.Properties.Resources.Print_32;
            this.button1.Location = new System.Drawing.Point(574, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 54);
            this.button1.TabIndex = 95;
            this.button1.Text = "Recibo ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.joyeria;
            this.ClientSize = new System.Drawing.Size(698, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DevueltanumericUpDown);
            this.Controls.Add(this.ImportetextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MontonumericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FacturaciondataGridView);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ArticulocomboBox);
            this.Controls.Add(this.VentacomboBox);
            this.Controls.Add(this.FacturaIDnumericUpDown);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroFacturacion";
            this.Text = "RegistroFacturacion";
            this.Load += new System.EventHandler(this.RegistroFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaciondataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturacionerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevueltanumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown FacturaIDnumericUpDown;
        private System.Windows.Forms.ComboBox VentacomboBox;
        private System.Windows.Forms.ComboBox ArticulocomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SubtotaltextBox;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DataGridView FacturaciondataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown MontonumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider FacturacionerrorProvider;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown DevueltanumericUpDown;
        private System.Windows.Forms.Button button1;
    }
}