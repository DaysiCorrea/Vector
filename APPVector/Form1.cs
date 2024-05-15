using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APPVector
{
    public partial class Form1 : Form
    {   
        //Creando uns instancia de mi clase vector
        clsVector v = new clsVector();
        public Form1()
        {
            InitializeComponent();
        }
        void mostrarVector() {
            lblResultado.Text = "[ ";
             for ( int i = 0; i < v.longitud(); i++) {
                 
                 lblResultado.Text = lblResultado.Text + v.obtenervalor(i) + " , ";
             }
            lblResultado.Text = lblResultado.Text + "]";

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
         int ele = Convert.ToInt16( txtValor.Text );
             v.adicionar(ele);
              mostrarVector();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ele = Convert.ToInt16(txtValor.Text);
             v.adicionar(ele);
             mostrarVector();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertir();
            mostrarVector();
        }

        private void cantDeParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.cantPares();
            MessageBox.Show("Cant. de Elementos pares: " + c.ToString());
        }

        private void ordenarMenorAMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.OrdenarMenorAmayor();
            mostrarVector();
        }

        private void eliminarElementoPoscPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt16(txtValor.Text);
            v.EliminarElementoPos(p);
            mostrarVector();
        }

        private void invertirCadaElementoVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.InvertirCadaElementoVector();
            mostrarVector();
        }

        private void cantElementoCapicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.CantElementoCapicua();
            MessageBox.Show("Cant. de Elementos Capicua: " + c.ToString());
        }

        private void cantElementoPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.CantElementoPrimo();
            MessageBox.Show("Cant. de Elementos Primos: " + c.ToString());
        }

    }
}
