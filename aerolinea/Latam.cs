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
    public partial class Latam : Form
    {
        public Latam()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MainLatam form1 = new MainLatam();
            form1.Show();
            this.Hide();
        }
    }
}
