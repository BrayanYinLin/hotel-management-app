﻿namespace ProyHotel_GUI
{
    partial class FrmDetalleReserva
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
            botonAgregarHabitacion = new Button();
            botonAgregarServicio = new Button();
            tituloDetalleReserva = new Label();
            labelIdReserva = new Label();
            labelTitularReserva = new Label();
            labelDocumento = new Label();
            labelTelefono = new Label();
            groupBox1 = new GroupBox();
            labelResultadoTelefono = new Label();
            labelResultadoDocumento = new Label();
            labelResultadoNombre = new Label();
            labelResultadoId = new Label();
            groupboxHabitacion = new GroupBox();
            listView1 = new ListView();
            groupboxServicio = new GroupBox();
            listView2 = new ListView();
            groupBox1.SuspendLayout();
            groupboxHabitacion.SuspendLayout();
            groupboxServicio.SuspendLayout();
            SuspendLayout();
            // 
            // botonAgregarHabitacion
            // 
            botonAgregarHabitacion.Location = new Point(338, 22);
            botonAgregarHabitacion.Name = "botonAgregarHabitacion";
            botonAgregarHabitacion.Size = new Size(23, 23);
            botonAgregarHabitacion.TabIndex = 0;
            botonAgregarHabitacion.Text = "+";
            botonAgregarHabitacion.UseVisualStyleBackColor = true;
            botonAgregarHabitacion.Click += botonAgregarHabitacion_Click;
            // 
            // botonAgregarServicio
            // 
            botonAgregarServicio.Location = new Point(325, 22);
            botonAgregarServicio.Name = "botonAgregarServicio";
            botonAgregarServicio.Size = new Size(23, 23);
            botonAgregarServicio.TabIndex = 1;
            botonAgregarServicio.Text = "+";
            botonAgregarServicio.UseVisualStyleBackColor = true;
            botonAgregarServicio.Click += botonAgregarServicio_Click;
            // 
            // tituloDetalleReserva
            // 
            tituloDetalleReserva.AutoSize = true;
            tituloDetalleReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloDetalleReserva.Location = new Point(12, 9);
            tituloDetalleReserva.Name = "tituloDetalleReserva";
            tituloDetalleReserva.Size = new Size(152, 21);
            tituloDetalleReserva.TabIndex = 2;
            tituloDetalleReserva.Text = "Detalle de Reserva";
            // 
            // labelIdReserva
            // 
            labelIdReserva.AutoSize = true;
            labelIdReserva.Location = new Point(6, 34);
            labelIdReserva.Name = "labelIdReserva";
            labelIdReserva.Size = new Size(79, 15);
            labelIdReserva.TabIndex = 3;
            labelIdReserva.Text = "Id de Reserva:";
            // 
            // labelTitularReserva
            // 
            labelTitularReserva.AutoSize = true;
            labelTitularReserva.Location = new Point(373, 34);
            labelTitularReserva.Name = "labelTitularReserva";
            labelTitularReserva.Size = new Size(54, 15);
            labelTitularReserva.TabIndex = 4;
            labelTitularReserva.Text = "Nombre:";
            // 
            // labelDocumento
            // 
            labelDocumento.AutoSize = true;
            labelDocumento.Location = new Point(6, 77);
            labelDocumento.Name = "labelDocumento";
            labelDocumento.Size = new Size(73, 15);
            labelDocumento.TabIndex = 5;
            labelDocumento.Text = "Documento:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(373, 77);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(55, 15);
            labelTelefono.TabIndex = 6;
            labelTelefono.Text = "Telefono:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelResultadoTelefono);
            groupBox1.Controls.Add(labelResultadoDocumento);
            groupBox1.Controls.Add(labelResultadoNombre);
            groupBox1.Controls.Add(labelResultadoId);
            groupBox1.Controls.Add(labelIdReserva);
            groupBox1.Controls.Add(labelTelefono);
            groupBox1.Controls.Add(labelTitularReserva);
            groupBox1.Controls.Add(labelDocumento);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(727, 117);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Titular:";
            // 
            // labelResultadoTelefono
            // 
            labelResultadoTelefono.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoTelefono.Location = new Point(433, 76);
            labelResultadoTelefono.Name = "labelResultadoTelefono";
            labelResultadoTelefono.Size = new Size(276, 23);
            labelResultadoTelefono.TabIndex = 10;
            labelResultadoTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResultadoDocumento
            // 
            labelResultadoDocumento.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoDocumento.Location = new Point(91, 76);
            labelResultadoDocumento.Name = "labelResultadoDocumento";
            labelResultadoDocumento.Size = new Size(276, 23);
            labelResultadoDocumento.TabIndex = 9;
            labelResultadoDocumento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResultadoNombre
            // 
            labelResultadoNombre.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoNombre.Location = new Point(433, 33);
            labelResultadoNombre.Name = "labelResultadoNombre";
            labelResultadoNombre.Size = new Size(276, 23);
            labelResultadoNombre.TabIndex = 8;
            labelResultadoNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResultadoId
            // 
            labelResultadoId.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoId.Location = new Point(91, 33);
            labelResultadoId.Name = "labelResultadoId";
            labelResultadoId.Size = new Size(276, 23);
            labelResultadoId.TabIndex = 7;
            labelResultadoId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupboxHabitacion
            // 
            groupboxHabitacion.Controls.Add(listView1);
            groupboxHabitacion.Controls.Add(botonAgregarHabitacion);
            groupboxHabitacion.Location = new Point(12, 179);
            groupboxHabitacion.Name = "groupboxHabitacion";
            groupboxHabitacion.Size = new Size(367, 259);
            groupboxHabitacion.TabIndex = 8;
            groupboxHabitacion.TabStop = false;
            groupboxHabitacion.Text = "Habitaciones";
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(326, 231);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupboxServicio
            // 
            groupboxServicio.Controls.Add(listView2);
            groupboxServicio.Controls.Add(botonAgregarServicio);
            groupboxServicio.Location = new Point(385, 179);
            groupboxServicio.Name = "groupboxServicio";
            groupboxServicio.Size = new Size(354, 259);
            groupboxServicio.TabIndex = 9;
            groupboxServicio.TabStop = false;
            groupboxServicio.Text = "Servicios";
            // 
            // listView2
            // 
            listView2.Location = new Point(6, 22);
            listView2.Name = "listView2";
            listView2.Size = new Size(313, 231);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // FrmDetalleReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 450);
            Controls.Add(groupboxServicio);
            Controls.Add(groupboxHabitacion);
            Controls.Add(groupBox1);
            Controls.Add(tituloDetalleReserva);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmDetalleReserva";
            Text = "Gestionar Detalle de Reserva";
            Load += FrmDetalleReserva_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupboxHabitacion.ResumeLayout(false);
            groupboxServicio.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonAgregarHabitacion;
        private Button botonAgregarServicio;
        private Label tituloDetalleReserva;
        private Label labelIdReserva;
        private Label labelTitularReserva;
        private Label labelDocumento;
        private Label labelTelefono;
        private GroupBox groupBox1;
        private Label labelResultadoTelefono;
        private Label labelResultadoDocumento;
        private Label labelResultadoNombre;
        private Label labelResultadoId;
        private GroupBox groupboxHabitacion;
        private GroupBox groupboxServicio;
        private ListView listView1;
        private ListView listView2;
    }
}