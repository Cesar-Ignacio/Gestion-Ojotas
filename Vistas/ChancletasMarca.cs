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
using Chancletas.Vistas;
namespace Chancletas.Vistas
{
    public partial class ChancletasMarca : Form
    {
        private Form formulario;

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
            this.Hide();
            formulario = new ChancletasTalle();
            formulario.Show();

        }

        private void btBuscarPorColor_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario = new ChancletasPorColor();
            formulario.Show();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            string marca = cbxMarca.Text;
            
            negChancletas neg = new negChancletas();

            dataGridView1.DataSource = neg.obtenerChancletasPorMarca(marca);

        }

        private void btBusColTallMar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario = new ChancletasColorMarcaTalle();
            formulario.Show();

        }

        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbfecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
