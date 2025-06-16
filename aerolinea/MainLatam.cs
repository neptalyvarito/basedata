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
    public partial class MainLatam : Form
    {
        public MainLatam()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            EscogerFecha form2 = new EscogerFecha();  
            form2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MainLatam_Load(object sender, EventArgs e)
        {

        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {

        }
    }
}
