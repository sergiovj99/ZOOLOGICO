using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOOLOGICO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnMamiferos_Click(object sender, EventArgs e)
        {
            LisMamiferos mamifero = new LisMamiferos();
            mamifero.Show();
        }

        private void btnAves_Click(object sender, EventArgs e)
        {
            LisAves aves = new LisAves();
            aves.Show();
        }

        private void btnAcuaticos_Click(object sender, EventArgs e)
        {
            LisAcuaticos acuaticos = new LisAcuaticos();
            acuaticos.Show();
        }

        private void btnRegistroani_Click(object sender, EventArgs e)
        {
            Registraranimal registro = new Registraranimal();
            registro.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();

        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            Precios precios = new Precios();
            precios.Show();
        }

        private void btnEnfermeria_Click(object sender, EventArgs e)
        {
            Enfermeria enfermeria = new Enfermeria();
            enfermeria.Show();

        }
    }
}
