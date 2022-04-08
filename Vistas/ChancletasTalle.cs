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
    public partial class ChancletasTalle : Form
    {
        public ChancletasTalle()
        {
            InitializeComponent();
        }

        private void ChancletasTalle_Load(object sender, EventArgs e)
        {
            cbxTalles.Items.Add(30);
            cbxTalles.Items.Add(31);
            cbxTalles.Items.Add(32);
            cbxTalles.Items.Add(34);
            cbxTalles.Items.Add(35);
            cbxTalles.Items.Add(36);

            cbxTalles.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string talle=cbxTalles.Text;
            negChancletas neg = new negChancletas();
            dataGridView1.DataSource = neg.obtenerChancletaPorTalle(talle);


        }
    }
}
