using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chancletas.Negocio;

namespace Chancletas.Vistas
{
    public partial class ChancletasMarca : Form
    {
        public ChancletasMarca()
        {
            InitializeComponent();
        }
        private void ChancletasMarca_Load(object sender, EventArgs e)
        {
            cbxMarca.Items.Add("Selecciona Marca");
            cbxMarca.Items.Add("NIKE");
            cbxMarca.Items.Add("NEW BALANCE");

            cbxMarca.SelectedIndex = 0;
        }
        private void btBuscarPorTalle_Click(object sender, EventArgs e)
        {
            ChancletasTalle form = new ChancletasTalle();
            form.Show();

        }

        private void btBuscarPorColor_Click(object sender, EventArgs e)
        {
            
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            string marca = cbxMarca.Text;
            
            negChancletas neg = new negChancletas();

            dataGridView1.DataSource = neg.obtenerChancletasPorMarca(marca);

        }
    }
}
