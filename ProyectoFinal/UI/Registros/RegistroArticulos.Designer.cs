namespace ProyectoFinal.UI.Registros
{
    partial class RegistroArticulos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ArticuloIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MarcatextBox = new System.Windows.Forms.TextBox();
            this.FechaEntradadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.VigenciatextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PrecioCompratextBox = new System.Windows.Forms.TextBox();
            this.PrecioVentatextBox = new System.Windows.Forms.TextBox();
            this.GananciatextBox = new System.Windows.Forms.TextBox();
            this.ArticuloerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArticuloerrorProvider.SetIconAlignment(this.label1, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "ArticuloID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(59, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Marca Del Articulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(59, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha De Entrada";
            // 
            // ArticuloIDnumericUpDown
            // 
            this.ArticuloIDnumericUpDown.Location = new System.Drawing.Point(162, 45);
            this.ArticuloIDnumericUpDown.Name = "ArticuloIDnumericUpDown";
            this.ArticuloIDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ArticuloIDnumericUpDown.TabIndex = 0;
            // 
            // MarcatextBox
            // 
            this.MarcatextBox.Location = new System.Drawing.Point(162, 121);
            this.MarcatextBox.Name = "MarcatextBox";
            this.MarcatextBox.Size = new System.Drawing.Size(120, 20);
            this.MarcatextBox.TabIndex = 2;
            // 
            // FechaEntradadateTimePicker
            // 
            this.FechaEntradadateTimePicker.CustomFormat = "dd/mm/aa";
            this.FechaEntradadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaEntradadateTimePicker.Location = new System.Drawing.Point(162, 160);
            this.FechaEntradadateTimePicker.Name = "FechaEntradadateTimePicker";
            this.FechaEntradadateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechaEntradadateTimePicker.TabIndex = 3;
            this.FechaEntradadateTimePicker.Value = new System.DateTime(2018, 7, 22, 0, 0, 0, 0);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoFinal.Properties.Resources.delete_32;
            this.Eliminarbutton.Location = new System.Drawing.Point(243, 395);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(89, 53);
            this.Eliminarbutton.TabIndex = 6;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoFinal.Properties.Resources.search_32;
            this.Buscarbutton.Location = new System.Drawing.Point(288, 28);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(89, 46);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinal.Properties.Resources.save_32;
            this.Guardarbutton.Location = new System.Drawing.Point(134, 395);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(89, 53);
            this.Guardarbutton.TabIndex = 4;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(59, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre Del Articulo";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(162, 83);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(120, 20);
            this.NombretextBox.TabIndex = 1;
            // 
            // VigenciatextBox
            // 
            this.VigenciatextBox.Location = new System.Drawing.Point(162, 305);
            this.VigenciatextBox.Name = "VigenciatextBox";
            this.VigenciatextBox.ReadOnly = true;
            this.VigenciatextBox.Size = new System.Drawing.Size(122, 20);
            this.VigenciatextBox.TabIndex = 19;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Location = new System.Drawing.Point(59, 310);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 15);
            this.label.TabIndex = 18;
            this.label.Text = "Vigencia Del Articulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(59, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio Compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(59, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Precio Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(59, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ganancia";
            // 
            // PrecioCompratextBox
            // 
            this.PrecioCompratextBox.Location = new System.Drawing.Point(162, 197);
            this.PrecioCompratextBox.Name = "PrecioCompratextBox";
            this.PrecioCompratextBox.ReadOnly = true;
            this.PrecioCompratextBox.Size = new System.Drawing.Size(120, 20);
            this.PrecioCompratextBox.TabIndex = 23;
            // 
            // PrecioVentatextBox
            // 
            this.PrecioVentatextBox.Location = new System.Drawing.Point(162, 229);
            this.PrecioVentatextBox.Name = "PrecioVentatextBox";
            this.PrecioVentatextBox.ReadOnly = true;
            this.PrecioVentatextBox.Size = new System.Drawing.Size(120, 20);
            this.PrecioVentatextBox.TabIndex = 24;
            // 
            // GananciatextBox
            // 
            this.GananciatextBox.Location = new System.Drawing.Point(162, 263);
            this.GananciatextBox.Name = "GananciatextBox";
            this.GananciatextBox.ReadOnly = true;
            this.GananciatextBox.Size = new System.Drawing.Size(120, 20);
            this.GananciatextBox.TabIndex = 25;
            // 
            // ArticuloerrorProvider
            // 
            this.ArticuloerrorProvider.ContainerControl = this;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoFinal.Properties.Resources.new_32;
            this.Nuevobutton.Location = new System.Drawing.Point(38, 395);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(90, 53);
            this.Nuevobutton.TabIndex = 5;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // RegistroArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.joyeria;
            this.ClientSize = new System.Drawing.Size(819, 460);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.GananciatextBox);
            this.Controls.Add(this.PrecioVentatextBox);
            this.Controls.Add(this.PrecioCompratextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VigenciatextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.FechaEntradadateTimePicker);
            this.Controls.Add(this.MarcatextBox);
            this.Controls.Add(this.ArticuloIDnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RegistroArticulos";
            this.Text = "RegistroArticulos";
            this.Load += new System.EventHandler(this.RegistroArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ArticuloIDnumericUpDown;
        private System.Windows.Forms.TextBox MarcatextBox;
        private System.Windows.Forms.DateTimePicker FechaEntradadateTimePicker;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox VigenciatextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PrecioCompratextBox;
        private System.Windows.Forms.TextBox PrecioVentatextBox;
        private System.Windows.Forms.TextBox GananciatextBox;
        private System.Windows.Forms.ErrorProvider ArticuloerrorProvider;
        private System.Windows.Forms.Button Nuevobutton;
    }
}