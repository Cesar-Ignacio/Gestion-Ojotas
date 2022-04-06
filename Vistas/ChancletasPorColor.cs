using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chancletas.Datos;
using Chancletas.Negocio;

namespace Chancletas.Vistas
{
    public partial class btChanMarca : Form
    {
        public btChanMarca()
        {
            InitializeComponent();
        }

        private void ChancletasPorColor_Load(object sender, EventArgs e)
        {
            cbxColor.Items.Add("Seleccionee Color");
            cbxColor.Items.Add("Rojo");
            cbxColor.Items.Add("Blanco");
            cbxColor.Items.Add("Negro");

            cbxColor.SelectedIndex = 0;
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {

            String color;

            color = cbxColor.Text;
            negChancletas neg = new negChancletas();

            dataGridView1.DataSource = neg.ObtenerChancletas(color);

            
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            ChancletasTalle fomr = new ChancletasTalle();
            fomr.Show();
        }
    }
}
