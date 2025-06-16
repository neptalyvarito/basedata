using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_Conexion;

namespace aerolinea
{
    public partial class BuscarVuelo : Form
    {
        private string cod_AeropuertoOrigen;
        private string cod_AeropuertoLlegada;
        private DateTime fecha;

        public BuscarVuelo(string Cod_Origen, string cod_LLega, DateTime fecha)
        {
            InitializeComponent();
            this.cod_AeropuertoOrigen = Cod_Origen;
            this.cod_AeropuertoLlegada = cod_LLega;
            this.fecha = fecha;
        } 

        private void btnCliente_Click(object sender, EventArgs e)
        {
            BuscarAsiento buscarAsientos = new BuscarAsiento();
            buscarAsientos.Show();
            this.Hide();
        }

        private void BuscarVuelo_Load(object sender, EventArgs e)
        {
            dtgVuelosDisponibles.DataSource = Conexion.Obtener_Vuelo_Por_Fecha(cod_AeropuertoOrigen, cod_AeropuertoLlegada, fecha);
        }
    }
}
