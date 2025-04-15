using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void cbx_tipo_habitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoHabitacion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando aplicación", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Close();
        }
    }
}
