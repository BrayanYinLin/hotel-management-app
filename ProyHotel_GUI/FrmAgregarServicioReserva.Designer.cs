﻿namespace ProyHotel_GUI
{
    partial class FrmAgregarServicioReserva
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
            botonAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            comboboxServicios = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            labelResultadoReservaId = new Label();
            botonCancelar = new Button();
            numericoCantidad = new NumericUpDown();
            precioTotal = new Label();
            labelPrecioTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)numericoCantidad).BeginInit();
            SuspendLayout();
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(223, 219);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(79, 30);
            botonAgregar.TabIndex = 2;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 3;
            label1.Text = "Agregar Servicios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 126);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad:";
            // 
            // comboboxServicios
            // 
            comboboxServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxServicios.FormattingEnabled = true;
            comboboxServicios.Location = new Point(98, 86);
            comboboxServicios.Name = "comboboxServicios";
            comboboxServicios.Size = new Size(204, 23);
            comboboxServicios.TabIndex = 0;
            comboboxServicios.SelectedIndexChanged += comboboxServicios_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 86);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 7;
            label3.Text = "Categoria:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 50);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 8;
            label4.Text = "Id:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // labelResultadoReservaId
            // 
            labelResultadoReservaId.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoReservaId.Location = new Point(98, 46);
            labelResultadoReservaId.Name = "labelResultadoReservaId";
            labelResultadoReservaId.Size = new Size(204, 23);
            labelResultadoReservaId.TabIndex = 9;
            labelResultadoReservaId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(138, 219);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(79, 30);
            botonCancelar.TabIndex = 10;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // numericoCantidad
            // 
            numericoCantidad.Location = new Point(98, 126);
            numericoCantidad.Name = "numericoCantidad";
            numericoCantidad.Size = new Size(204, 23);
            numericoCantidad.TabIndex = 11;
            numericoCantidad.TextAlign = HorizontalAlignment.Right;
            numericoCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericoCantidad.ValueChanged += numericoCantidad_ValueChanged;
            // 
            // precioTotal
            // 
            precioTotal.AutoSize = true;
            precioTotal.Location = new Point(12, 169);
            precioTotal.Name = "precioTotal";
            precioTotal.Size = new Size(71, 15);
            precioTotal.TabIndex = 12;
            precioTotal.Text = "Precio Total:";
            // 
            // labelPrecioTotal
            // 
            labelPrecioTotal.BorderStyle = BorderStyle.FixedSingle;
            labelPrecioTotal.Location = new Point(98, 165);
            labelPrecioTotal.Name = "labelPrecioTotal";
            labelPrecioTotal.Size = new Size(204, 23);
            labelPrecioTotal.TabIndex = 13;
            labelPrecioTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmAgregarServicioReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 261);
            Controls.Add(labelPrecioTotal);
            Controls.Add(precioTotal);
            Controls.Add(numericoCantidad);
            Controls.Add(botonCancelar);
            Controls.Add(labelResultadoReservaId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboboxServicios);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonAgregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgregarServicioReserva";
            Text = "Agregar servicio a la reserva";
            Load += SeleccionarServicio_Load;
            ((System.ComponentModel.ISupportInitialize)numericoCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button botonAgregar;
        private Label label1;
        private Label label2;
        private ComboBox comboboxServicios;
        private Label label3;
        private Label label4;
        private Label labelResultadoReservaId;
        private Button botonCancelar;
        private NumericUpDown numericoCantidad;
        private Label precioTotal;
        private Label labelPrecioTotal;
    }
}