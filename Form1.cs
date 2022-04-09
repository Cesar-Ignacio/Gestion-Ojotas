using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chancletas.Vistas;
namespace Chancletas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          


        }

        private void cbxColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string modificarIndiceColor(int indice)
        {
            if(indice == 1)
            {
                return "col01";
            }

            return "0";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            ChancletasColorMarcaTalle fm = new ChancletasColorMarcaTalle();
            fm.Show();


        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbfecha.Text = DateTime.Now.ToLongDateString();

        }
    }
}
