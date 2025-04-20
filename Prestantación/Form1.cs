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
using Datos;

namespace Prestantación
{
    public partial class frm_hotel : Form
    {
        public frm_hotel()
        {
            InitializeComponent();
        }
        c_logica ob_c_logica = new c_logica();
        Cd_hotel ob_cd_hotel = new Cd_hotel(); //instancia de toda la clase

        private void frm_hotel_Load(object sender, EventArgs e)
        {
            MostrarDataHotel();// query de la vista.
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

        #region = "Agregar Usuario parte 2";
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación correcta del texto ingresado
            if (string.IsNullOrWhiteSpace(txt_dias.Text))
            {
                txt_dias.Text = ""; // Si está vacío o contiene solo espacios
                MessageBox.Show("Ingrese el número de días porfavor no se permiten datos null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double dias_hospedaje = double.Parse(txt_dias.Text);
                string tamano_habitacion = cbx_size_habitac.Text;
                string tipo_habitacion = cbx_tipo_habitacion.Text;
                double precio_dia = double.Parse(lbl_precio_dia.Text);
                double precio_total_dia = double.Parse(lbl_precio_total_dias.Text);
                double costo_tipo_habitacion = double.Parse(lbl_costoTipo_habitacion.Text);
                double total_factura = double.Parse(lbl_total_factura.Text);
                DateTime Fecha_factura = ob_c_logica.MtdFechaHoy();
                Boolean estado_codigo = true;
            
            try
            {
                ob_cd_hotel.MtdAgregarData_Hotel(dias_hospedaje,tamano_habitacion,tipo_habitacion,precio_dia,precio_total_dia,costo_tipo_habitacion,total_factura,Fecha_factura,estado_codigo);
                MessageBox.Show("Registro guardado correctamente","Status",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MostrarDataHotel();
                LimpiarCancelar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
          
        }
        #endregion

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

        #region = "Comunicación del metodo capa datos esta es el query de la vista 😊";
        public void MostrarDataHotel() //cargar en load para que muestre la información
        {
            dgvDatosHoteles.DataSource = ob_cd_hotel.MtdConsultarHotel();
        }

        #endregion

        #region = "retonar los datos de dtv los cbox, txt y label desde el evento CELLCLICK"
        private void dgvDatosHoteles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_codigoReservacion.Text = dgvDatosHoteles.SelectedCells[0].Value.ToString();
            txt_dias.Text = dgvDatosHoteles.SelectedCells[1].Value.ToString();
            cbx_size_habitac.Text = dgvDatosHoteles.SelectedCells[2].Value.ToString();
            cbx_tipo_habitacion.Text = dgvDatosHoteles.SelectedCells[3].Value.ToString();
            lbl_precio_dia.Text = dgvDatosHoteles.SelectedCells[4].Value.ToString();
            lbl_precio_total_dias.Text = dgvDatosHoteles.SelectedCells[5].Value.ToString();
            lbl_costoTipo_habitacion.Text = dgvDatosHoteles.SelectedCells[6].Value.ToString();
            lbl_total_factura.Text = dgvDatosHoteles.SelectedCells[7].Value.ToString();
        }

        #endregion

        #region = "Boton Editar"
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validación correcta del texto ingresado
            if (string.IsNullOrWhiteSpace(txt_dias.Text))
            {
                txt_dias.Text = ""; // Si está vacío o contiene solo espacios
                MessageBox.Show("Ingrese el número de días porfavor no se permiten datos null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigo_reservacion = int.Parse(txt_codigoReservacion.Text);
                double dias_hospedaje = double.Parse(txt_dias.Text);
                string tamano_habitacion = cbx_size_habitac.Text;
                string tipo_habitacion = cbx_tipo_habitacion.Text;
                double precio_dia = double.Parse(lbl_precio_dia.Text);
                double precio_total_dia = double.Parse(lbl_precio_total_dias.Text);
                double costo_tipo_habitacion = double.Parse(lbl_costoTipo_habitacion.Text);
                double total_factura = double.Parse(lbl_total_factura.Text);
                DateTime Fecha_factura = ob_c_logica.MtdFechaHoy();
                Boolean estado_codigo = true;

                try
                {
                    ob_cd_hotel.MtdActualizar_Data_Hotel(codigo_reservacion, dias_hospedaje, tamano_habitacion, tipo_habitacion, precio_dia, precio_total_dia, costo_tipo_habitacion, total_factura, Fecha_factura, estado_codigo);
                    MessageBox.Show("Registro actualizaro correctamente", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDataHotel();
                    LimpiarCancelar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
    }
}
