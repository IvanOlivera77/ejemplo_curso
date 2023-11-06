using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento =txtNombre.Text;
            lwElementos.Items.Add(elemento);
        }

         private void Form1_Load(object sender, EventArgs e)
        {
            cbxColorfavorito.Items.Add("Rojo");
            cbxColorfavorito.Items.Add("Verde");
            cbxColorfavorito.Items.Add("Azul");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechanacimiento.Value;
            // Operador ternario
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else 
                tipo = "Squibs";
            string colorFavorito = cbxColorfavorito.SelectedItem.ToString();
            string numeroFavorito = numNumerofavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su numero es " + numeroFavorito;
            MessageBox.Show("Nombre; " + nombre + " fecha; " + fecha + ", " + mensaje);

        }

        //private void btnAgregar_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //}

        //private void btnAgregar_Enter(object sender, EventArgs e)
        //{
        //    string elemento = txtElemento.Text;
        //    lwElementos.Items.Add(elemento);
        //}
    }
}
