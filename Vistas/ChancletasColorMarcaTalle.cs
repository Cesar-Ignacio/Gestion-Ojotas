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

    public partial class ChancletasColorMarcaTalle : Form
    {

        private Form formulario;
        
        public ChancletasColorMarcaTalle()
        {
            InitializeComponent();
        }


        private void ChancletasColorMarcaTalle_Load(object sender, EventArgs e)
        {
            cbxSelecColor.Items.Add("Seleccionar Color");
            cbxSelecColor.Items.Add("Blanco");
            cbxSelecColor.Items.Add("Negro");
            cbxSelecColor.Items.Add("Rojo");
            cbxSelecColor.Items.Add("Rosa");

            cbxSelecColor.SelectedIndex = 0;

            cbxSelecTalle.Items.Add("Seleccionar Talle");
            cbxSelecTalle.Items.Add(30);
            cbxSelecTalle.Items.Add(31);
            cbxSelecTalle.Items.Add(32);
            cbxSelecTalle.Items.Add(33);
            cbxSelecTalle.Items.Add(34);

            cbxSelecTalle.SelectedIndex = 0;

            cbxSelecMarca.Items.Add("Seleccionar Marca");
            cbxSelecMarca.Items.Add("NIKE");
            cbxSelecMarca.Items.Add("NEW BALANCE");
            cbxSelecMarca.Items.Add("PUMA");

            cbxSelecMarca.SelectedIndex = 0;

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

            string color = cbxSelecColor.Text;
            string talle = cbxSelecTalle.Text;
            string marca = cbxSelecMarca.Text;

            negChancletas neg = new negChancletas();

            dataGridView1.DataSource = neg.obtenerChancletasPorColorTallMarca(color, talle, marca);

        }

        private void btBusColor_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario = new ChancletasPorColor();
            formulario.Show();
        }

        private void btBusMarca_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario = new ChancletasMarca();
            formulario.Show();
        }

        private void btBuscarTalle_Click(object sender, EventArgs e)
        {
            this.Hide();
            formulario = new ChancletasTalle();
            formulario.Show();
        }

        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text= DateTime.Now.ToString("hh:mm:ss");
            lbfecha.Text=DateTime.Now.ToLongDateString();
        }
    }
}