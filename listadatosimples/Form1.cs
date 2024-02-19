using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listadatosimples
{
    public partial class Form1 : Form
    {
        //Lista declarada como global
        List<int> listaEnteros = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<int> listaEnteros = new List<int>();
            listaEnteros.Add(Convert.ToInt32(textBox1.Text));
        }
        private void mostrar()
        {
            //Opcion 1: manual
            //for (int i = 0; i < listaEnteros.Count; i++)
            //{
            //    listBox1.Items.Add(listaEnteros[i]);
            //}
            //Opcion 2: automatico
            //funciona con: comboBox, ListBox, Datagriview
            listBox1.DataSource = null;
            listBox1.Refresh();
            listBox1.DataSource = listaEnteros;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mostrar();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaEnteros.Sort();
            mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaEnteros.Sort();
            listaEnteros.Reverse();
            mostrar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numero = 0;

            bool seConvirtio = int.TryParse(textBox1.Text, out numero);

            if (seConvirtio)
            {
                listaEnteros.Remove(numero);
                mostrar();
            }
            else
            {
                MessageBox.Show("Debe: Ingrear un numero")
            }
        }
    }
}
