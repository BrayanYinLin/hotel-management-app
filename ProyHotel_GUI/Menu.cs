﻿using Microsoft.VisualBasic.Devices;
using ProyVentas_GUI;
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
    public partial class Menu : Form
    {
        Computer computer = new Computer();
        TimeSpan horaentrada = new TimeSpan();
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            horaentrada = DateTime.Now.TimeOfDay;
            tlblUsuario.Text = "Usuario: " + clsCredenciales.Usuario;

            if (computer.Network.IsAvailable)
            {
                tlblconexion.Text = "Equipo con conexion Disponible";
            }
            else
            {
                tlblconexion.Text = "Equipo sin conexion Disponible";
            }
            tlblComputer.Text = "Equipo: " + computer.Name + ".";
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm1 = new FrmUsuarios();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Menu Principal - Hotel   --  " + DateTime.Now.ToString();
            tlblsesion.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaentrada).ToString().Substring(0, 8);
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmUsuarios)
                {
                    formularioAbierto = true;
                    frm.Activate();
                    break;
                }
            }

            if (!formularioAbierto)
            {
                FrmUsuarios frmUsuarios = new FrmUsuarios();
                frmUsuarios.MdiParent = this;
                frmUsuarios.Show();
            }

            //FrmUsuarios usuarios = new FrmUsuarios();
            //usuarios.MdiParent = this;
            //usuarios.Show();
        }

        private void huespedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmHuespedes)
                {
                    formularioAbierto = true;
                    frm.Activate();
                    break;
                }
            }

            if (!formularioAbierto)
            {
                FrmHuespedes frmHuesped = new FrmHuespedes();
                frmHuesped.MdiParent = this;
                frmHuesped.Show();
            }

            //FrmHuespedes frmHuespedes = new();
            //frmHuespedes.MdiParent = this;
            //frmHuespedes.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmServicios)
                {
                    formularioAbierto = true;
                    frm.Activate();
                    break;
                }
            }

            if (!formularioAbierto)
            {
                FrmServicios frmServicios = new FrmServicios();
                frmServicios.MdiParent = this;
                frmServicios.Show();
            }

            //FrmServicios servicios = new();
            //servicios.MdiParent = this;
            //servicios.Show();
        }

        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmHabitaciones)
                {
                    formularioAbierto = true;
                    frm.Activate();
                    break;
                }
            }

            if (!formularioAbierto)
            {
                FrmHabitaciones frmHabitaciones = new FrmHabitaciones();
                frmHabitaciones.MdiParent = this;
                frmHabitaciones.Show();
            }

            //FrmHabitaciones frmHabitaciones = new FrmHabitaciones();
            //frmHabitaciones.MdiParent = this;
            //frmHabitaciones.Show();
        }

        private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmTipoUsuario)
                {
                    formularioAbierto = true;
                    frm.Activate();
                    break;
                }
            }

            if (!formularioAbierto)
            {
                FrmTipoUsuario frmTipoUsuario = new FrmTipoUsuario();
                frmTipoUsuario.MdiParent = this;
                frmTipoUsuario.Show();
            }

            //FrmTipoUsuario frmTipoUsuario = new();
            //frmTipoUsuario.MdiParent = this;
            //frmTipoUsuario.Show();
        }

        private void reservToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmReserva)
                {
                    formularioAbierto = true;
                    frm.Activate();
                    break;
                }
            }

            if (!formularioAbierto)
            {
                FrmReserva frmReservas = new FrmReserva();
                frmReservas.MdiParent = this;
                frmReservas.Show();
            }

            //FrmReserva frmReserva = new FrmReserva();
            //frmReserva.MdiParent = this;
            //frmReserva.Show();
        }

        private void crearReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmCrearReserva)
                {
                    formularioAbierto = true;
                    frm.Activate();
                    break;
                }
            }

            if (!formularioAbierto)
            {
                FrmCrearReserva frmCrearReservas = new FrmCrearReserva();
                frmCrearReservas.MdiParent = this;
                frmCrearReservas.Show();
            }


            //FrmCrearReserva frmCrearReserva = new FrmCrearReserva();
            //frmCrearReserva.MdiParent = this;
            //frmCrearReserva.Show();
        }

        private void reporteDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool formularioAbierto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmReportes)
                {
                    formularioAbierto = true;
                    frm.Activate();
                    break;
                }
            }

            if (!formularioAbierto)
            {
                FrmReportes frmReporte = new FrmReportes();
                frmReporte.MdiParent = this;
                frmReporte.Show();
            }

            //FrmReportes frmReportes = new FrmReportes();
            //frmReportes.MdiParent = this;
            //frmReportes.Show();
        }


        private void tipoDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool formularioAbierto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmTipoHabitacion)
                {
                    formularioAbierto = true;
                    frm.Activate();
                    break;
                }
            }

            if (!formularioAbierto)
            {
                FrmTipoHabitacion frmTipoHabitacioness = new FrmTipoHabitacion();
                frmTipoHabitacioness.MdiParent = this;
                frmTipoHabitacioness.Show();
            }


            //FrmTipoHabitacion frmTipoHabitacion = new FrmTipoHabitacion();
            //frmTipoHabitacion.MdiParent = this;
            //frmTipoHabitacion.Show();
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmarCierre = MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmarCierre != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
