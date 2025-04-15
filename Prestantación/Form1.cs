using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Logica;

namespace Prestantación
{
    public partial class frm_hotel : Form
    {
        public frm_hotel()
        {
            InitializeComponent();
        }
        c_logica ob_c_logica = new c_logica();

        private void frm_hotel_Load(object sender, EventArgs e)
        {
            fechas();
            TipoHabitacion();
            MtdPrecioTotalDias();
        }
        public void fechas ()
        {
            lbl_fecha.Text = ob_c_logica.MtdFechaHoy().ToString();
        }


        public void TipoHabitacion()
        {
            int posicion= cbx_size_habitac.SelectedIndex;
            lbl_precio_dia.Text = c_logica.MtdPrecioPorDia(posicion).ToString();
  
        }
        public void CostoTipoHabitacion()
        {
            int posicion = cbx_tipo_habitacion.SelectedIndex;
            lbl_costoTipo_habitacion.Text = c_logica.MtdPrecioPorDia(posicion).ToString();

        }

        private void cbx_tipo_habitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CostoTipoHabitacion();
        }

        private void txt_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoHabitacion();
            MtdPrecioTotalDias();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando aplicación", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Close();
        }

        public void MtdPrecioTotalDias()
        {
            int posicion = cbx_size_habitac.SelectedIndex;
            double precio = c_logica.MtdPrecioPorDia(posicion);
            // Validación correcta del texto ingresado
            if (string.IsNullOrWhiteSpace(txt_dias.Text))
            {
                txt_dias.Text = ""; // Si está vacío o contiene solo espacios
            }
            else
            {
                double diashospedaje = double.Parse(txt_dias.Text);
                lbl_precio_total_dias.Text = c_logica.MtdPrecioTotalDias(diashospedaje, precio).ToString();

            }
        }

        private void txt_dias_TextChanged(object sender, EventArgs e)
        {
            MtdPrecioTotalDias();
        }
    }
}
