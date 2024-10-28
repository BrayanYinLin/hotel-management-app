﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//agregar 
using ProyHotel_BE;
using ProyHotel_BL;

namespace ProyHotel_GUI
{
    public partial class FrmAgregarHabitacion : Form
    {
        HabitacionesBL objHabitacionBL = new HabitacionesBL();
        HabitacionBE objHabitacionBE = new HabitacionBE();
        TipoHabitacionesBL objTipoHabitacionesBL = new TipoHabitacionesBL();


        public FrmAgregarHabitacion()
        {
            InitializeComponent();
        }

        //mostrar combobox de habitaciones
        private void FrmAgregarHabitacion_Load(object sender, EventArgs e)
        {
            try
            {
                //codigo
                DataTable dt = objTipoHabitacionesBL.ListarTipoHabitaciones();
                DataRow dr;


                dr = dt.NewRow();
                dr["tipo_habitacion_id"] = 0;
                dr["tipo_habitacion_descripcion"] = "--seleccione--";
                dt.Rows.InsertAt(dr, 0);

                cboTipo.DataSource = dt;
                cboTipo.ValueMember = "tipo_habitacion_id";
                cboTipo.DisplayMember = "tipo_habitacion_descripcion";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //grabar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //codigo 
                //validamos

                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El campo de nombre es obligatoria");
                }
                if (cboTipo.SelectedIndex == 0)
                {
                    throw new Exception("El campo de Tipo es obligatoria");
                }
                if (txtPrecioPorNoche.Text.Trim() == String.Empty)
                {
                    throw new Exception("El Precio es obligatorio");
                }
                
                //si todo esta OK .. . cargamos el obj 

                objHabitacionBE.habitacion_nombre = txtNombre.Text.Trim();
                objHabitacionBE.tipo_habitacion_id = Convert.ToInt16(cboTipo.SelectedIndex);
                objHabitacionBE.precio_noche = Convert.ToSingle(txtPrecioPorNoche.Text);
                objHabitacionBE.estado_habitacion = Convert.ToInt16(chkActivo.Checked);
                objHabitacionBE.habitacion_aforo = Convert.ToInt16(txtAforo.Text);


                //usuario que registro
                //objHabitacionBE.Usuario_registro = "vincent";
                if (objHabitacionBL.InsertarHabitacion(objHabitacionBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("no se realizo la insercion contactate con soporte");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecioPorNoche_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                || e.KeyChar == (char)Keys.Back
                || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void txtAforo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAforo.Text.Length >= 1 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada si ya hay un carácter
            }
            else
            {
                e.Handled = !(e.KeyChar >= '1' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back);
            }

        }
    }
}