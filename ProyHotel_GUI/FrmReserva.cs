﻿using ProyHotel_BL;
using ProyHotel_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyHotel_GUI
{
    public partial class FrmReserva : Form
    {
        public int usuarioId;
        ReservasBL reservasBL = new();

        public FrmReserva()
        {
            InitializeComponent();
        }

        private void CargarDatos(string filtro)
        {
            DataView dataView = new DataView(reservasBL.ListarReserva());
            dataView.RowFilter = $"[DNI] like '%{filtro}%'";
            gridReservas.AutoGenerateColumns = false;
            gridReservas.DataSource = dataView;
            labelResultado.Text = gridReservas.RowCount.ToString();
        }

        private void FrmReserva_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos(textboxBuscar.Text.Trim());
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            FrmCrearReserva frmCrearReserva = new();
            frmCrearReserva.ShowDialog();
            CargarDatos("");
        }

        private void gridReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ReservaBE reservaBE = new();
                reservaBE.reservaId = Convert.ToInt16(gridReservas.Rows[e.RowIndex].Cells[0].Value);
                reservaBE.reservaNombre = gridReservas.Rows[e.RowIndex].Cells[5].Value.ToString();
                reservaBE.usuarioTelefono = gridReservas.Rows[e.RowIndex].Cells[4].Value.ToString();
                reservaBE.usuarioDni = gridReservas.Rows[e.RowIndex].Cells[3].Value.ToString();
                reservaBE.precioTotal = Convert.ToSingle(gridReservas.Rows[e.RowIndex].Cells[6].Value.ToString());
                var cellValue = gridReservas.Rows[e.RowIndex].Cells[0].Value;
                DialogResult dialog = MessageBox.Show("¿Desea abrir el detalle de esta reserva?", "Abrir Detalle Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    FrmDetalleReserva frmDetalleReserva = new FrmDetalleReserva(reservaBE);
                    frmDetalleReserva.Show();
                }
            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmActualizarReserva frmActualizarReserva = new();
                frmActualizarReserva.Codigo = int.Parse(gridReservas.CurrentRow.Cells[0].Value.ToString());
                frmActualizarReserva.ShowDialog();
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
