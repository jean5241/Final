using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumidorSOAP.WebServiceSOAPProducto;

namespace ConsumidorSOAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            WebServiceSOAPProducto.WebServiceProductoSoapClient cliente =
                new WebServiceProductoSoapClient();

            int precio = cliente.obtenerPrecioConIVAdeProducto(id);

            textBox2.Text = precio.ToString();
        }
    }
}
