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
            MtdPrecioTotalDias();
            MtdTotalFacturar();
            TipoHabitacion();
            CostoTipoHabitacion();
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
            if (cbx_tipo_habitacion != null)
            {
                lbl_costoTipo_habitacion.Text = c_logica.MtdCostoTipoHabitación(posicion).ToString();
            }
            else
            {
                cbx_tipo_habitacion.Text = "0";
            }
        }

        private void cbx_tipo_habitacion_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
                CostoTipoHabitacion();
                MtdTotalFacturar();
            
            
        }

        private void txt_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoHabitacion();
            MtdPrecioTotalDias();
            MtdTotalFacturar();
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
            MtdTotalFacturar();
            TipoHabitacion();
            MtdPrecioTotalDias();
            CostoTipoHabitacion();


        }

        public void MtdTotalFacturar()
        {
            double precioTotalDias, costoTipoHabitacion;

            // convertir ambos valores de los labels
            bool esPrecioValido = double.TryParse(lbl_precio_total_dias.Text, out precioTotalDias);
            bool esCostoValido = double.TryParse(lbl_costoTipo_habitacion.Text, out costoTipoHabitacion);

            // Si ambos valores son válidos, procedemos
            if (esPrecioValido && esCostoValido)
            {
                double resultado = c_logica.MtdTotalFacturar(precioTotalDias, costoTipoHabitacion);
                lbl_total_factura.Text = resultado.ToString();
            }
            else
            {
                // Si alguno es inválido, mostramos 0
                lbl_total_factura.Text = "0";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCancelar()
        {
            txt_codigoReservacion.Text = "";
            txt_dias.Text = "";
            cbx_size_habitac.Text = "";
            cbx_tipo_habitacion.Text = "";
            lbl_precio_dia.Text = "";
            lbl_precio_total_dias.Text = "";
            lbl_costoTipo_habitacion.Text = "";
            lbl_total_factura.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCancelar();
        }
    }
}
