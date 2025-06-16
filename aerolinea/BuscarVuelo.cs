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
        private string cod_Cabina;

        public BuscarVuelo(string Cod_Origen, string cod_LLega, DateTime fecha, string cod_Cabina)
        {
            InitializeComponent();
            this.cod_AeropuertoOrigen = Cod_Origen;
            this.cod_AeropuertoLlegada = cod_LLega;
            this.fecha = fecha;
            this.cod_Cabina = cod_Cabina;
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

        private void dtgVuelosDisponibles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0) return;
            DataTable dt = Conexion.Tarifa_Mas_Costo_Vuelo(dtgVuelosDisponibles["Cod_Vuelo", e.RowIndex].Value.ToString(), cod_Cabina);
            dtgTarifas.DataSource = dt;
        }

      
    }
}
