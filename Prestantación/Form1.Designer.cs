namespace Prestantación
{
    partial class frm_hotel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_total_factura = new System.Windows.Forms.Label();
            this.lbl_costoTipo_habitacion = new System.Windows.Forms.Label();
            this.lbl_precio_total_dias = new System.Windows.Forms.Label();
            this.lbl_precio_dia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_tipo_habitacion = new System.Windows.Forms.ComboBox();
            this.cbx_size_habitac = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.txt_codigoReservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.dgvDatosHoteles = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_total_factura);
            this.groupBox1.Controls.Add(this.lbl_costoTipo_habitacion);
            this.groupBox1.Controls.Add(this.lbl_precio_total_dias);
            this.groupBox1.Controls.Add(this.lbl_precio_dia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_tipo_habitacion);
            this.groupBox1.Controls.Add(this.cbx_size_habitac);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txt_dias);
            this.groupBox1.Controls.Add(this.txt_codigoReservacion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(40, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(779, 135);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lbl_total_factura
            // 
            this.lbl_total_factura.AutoSize = true;
            this.lbl_total_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_factura.Location = new System.Drawing.Point(506, 109);
            this.lbl_total_factura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total_factura.Name = "lbl_total_factura";
            this.lbl_total_factura.Size = new System.Drawing.Size(40, 17);
            this.lbl_total_factura.TabIndex = 30;
            this.lbl_total_factura.Text = "- - - -";
            // 
            // lbl_costoTipo_habitacion
            // 
            this.lbl_costoTipo_habitacion.AutoSize = true;
            this.lbl_costoTipo_habitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costoTipo_habitacion.Location = new System.Drawing.Point(506, 78);
            this.lbl_costoTipo_habitacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_costoTipo_habitacion.Name = "lbl_costoTipo_habitacion";
            this.lbl_costoTipo_habitacion.Size = new System.Drawing.Size(40, 17);
            this.lbl_costoTipo_habitacion.TabIndex = 29;
            this.lbl_costoTipo_habitacion.Text = "- - - -";
            // 
            // lbl_precio_total_dias
            // 
            this.lbl_precio_total_dias.AutoSize = true;
            this.lbl_precio_total_dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_total_dias.Location = new System.Drawing.Point(506, 46);
            this.lbl_precio_total_dias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_precio_total_dias.Name = "lbl_precio_total_dias";
            this.lbl_precio_total_dias.Size = new System.Drawing.Size(16, 17);
            this.lbl_precio_total_dias.TabIndex = 28;
            this.lbl_precio_total_dias.Text = "0";
            // 
            // lbl_precio_dia
            // 
            this.lbl_precio_dia.AutoSize = true;
            this.lbl_precio_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_dia.Location = new System.Drawing.Point(506, 15);
            this.lbl_precio_dia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_precio_dia.Name = "lbl_precio_dia";
            this.lbl_precio_dia.Size = new System.Drawing.Size(44, 17);
            this.lbl_precio_dia.TabIndex = 27;
            this.lbl_precio_dia.Text = "- - - - ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Total factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tipo Habitación";
            // 
            // cbx_tipo_habitacion
            // 
            this.cbx_tipo_habitacion.FormattingEnabled = true;
            this.cbx_tipo_habitacion.Items.AddRange(new object[] {
            "Bronce",
            "Oro",
            "Diamante",
            "Exclusiva"});
            this.cbx_tipo_habitacion.Location = new System.Drawing.Point(162, 109);
            this.cbx_tipo_habitacion.Name = "cbx_tipo_habitacion";
            this.cbx_tipo_habitacion.Size = new System.Drawing.Size(119, 21);
            this.cbx_tipo_habitacion.TabIndex = 24;
            this.cbx_tipo_habitacion.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_habitacion_SelectedIndexChanged);
            // 
            // cbx_size_habitac
            // 
            this.cbx_size_habitac.FormattingEnabled = true;
            this.cbx_size_habitac.Items.AddRange(new object[] {
            "Individual",
            "Compartida",
            "Suite",
            "Presidencial"});
            this.cbx_size_habitac.Location = new System.Drawing.Point(161, 78);
            this.cbx_size_habitac.Name = "cbx_size_habitac";
            this.cbx_size_habitac.Size = new System.Drawing.Size(119, 21);
            this.cbx_size_habitac.TabIndex = 23;
            this.cbx_size_habitac.SelectedIndexChanged += new System.EventHandler(this.txt_estado_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.Location = new System.Drawing.Point(629, 87);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 31);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(629, 51);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 31);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 25;
            this.btnGuardar.Location = new System.Drawing.Point(629, 15);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 31);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(161, 46);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(120, 20);
            this.txt_dias.TabIndex = 15;
            this.txt_dias.TextChanged += new System.EventHandler(this.txt_dias_TextChanged);
            // 
            // txt_codigoReservacion
            // 
            this.txt_codigoReservacion.Enabled = false;
            this.txt_codigoReservacion.Location = new System.Drawing.Point(161, 12);
            this.txt_codigoReservacion.Name = "txt_codigoReservacion";
            this.txt_codigoReservacion.Size = new System.Drawing.Size(120, 20);
            this.txt_codigoReservacion.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Costo tipo habitación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio total dias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio por día";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tamaño Habitación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Día de Hospedaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Reservación";
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.Location = new System.Drawing.Point(698, 388);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 31);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(609, 388);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 31);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvDatosHoteles
            // 
            this.dgvDatosHoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosHoteles.Location = new System.Drawing.Point(41, 188);
            this.dgvDatosHoteles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosHoteles.Name = "dgvDatosHoteles";
            this.dgvDatosHoteles.ReadOnly = true;
            this.dgvDatosHoteles.RowHeadersWidth = 51;
            this.dgvDatosHoteles.RowTemplate.Height = 24;
            this.dgvDatosHoteles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosHoteles.Size = new System.Drawing.Size(776, 196);
            this.dgvDatosHoteles.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(310, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "Sistema Hoteles";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(689, 30);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(106, 17);
            this.lbl_fecha.TabIndex = 32;
            this.lbl_fecha.Text = "fechas_sistema";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(624, 30);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Fecha:";
            // 
            // frm_hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvDatosHoteles);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_hotel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_hotel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosHoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_size_habitac;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.TextBox txt_codigoReservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.DataGridView dgvDatosHoteles;
        private System.Windows.Forms.Label lbl_total_factura;
        private System.Windows.Forms.Label lbl_costoTipo_habitacion;
        private System.Windows.Forms.Label lbl_precio_total_dias;
        private System.Windows.Forms.Label lbl_precio_dia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_tipo_habitacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label label15;
    }
}

