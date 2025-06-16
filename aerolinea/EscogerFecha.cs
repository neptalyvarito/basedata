using Libreria_Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aerolinea
{
    public partial class EscogerFecha : Form
    {
        public EscogerFecha()
        {
            InitializeComponent();
        }

        private void btnIda_Click(object sender, EventArgs e)
        {
            EscogerFecha form2 = new EscogerFecha();
            form2.Show();
            this.Hide();
        }

        private void btnBuscarVuelos_Click(object sender, EventArgs e)
        {
            BuscarVuelo form3 = new BuscarVuelo(cmbDesdeOrigen.SelectedValue.ToString(), cmbHaciaDestino.SelectedValue.ToString(), fechaIda.Value, cmbCabina.SelectedValue.ToString());
            form3.Show();
            this.Hide();
        }

        private void tabpane1_Click(object sender, EventArgs e)
        {

        }

        private void EscogerFecha_Load(object sender, EventArgs e)
        {
            cmbDesdeOrigen.DataSource = Conexion.Obtener_Aeropuertos();
            cmbDesdeOrigen.DisplayMember = "DescripcionCompleta";
            cmbDesdeOrigen.ValueMember = "Cod_Aeropuerto";
            cmbCabina.DataSource = Conexion.Obtener_Cabinas();
            cmbCabina.DisplayMember = "Tipo_Cabina";
            cmbCabina.ValueMember = "Cod_Cabina";
        }

        private void cmbDesdeOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod = cmbDesdeOrigen.SelectedValue.ToString();
            cmbHaciaDestino.DataSource = Conexion.Obtener_Aeropuerto_Excepto(cod);
            cmbHaciaDestino.DisplayMember = "DescripcionCompleta";
            cmbHaciaDestino.ValueMember = "Cod_Aeropuerto";
        }
    }
}
