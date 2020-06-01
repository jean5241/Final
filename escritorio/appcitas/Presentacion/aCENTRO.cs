using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Presentacion
{
    public partial class aCENTRO : Form
    {
        public aCENTRO()
        {
            InitializeComponent();
        }
        string nombre;
        public aCENTRO(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }
        GestorMedico med = new GestorMedico();
        Gestorcentro centro = new Gestorcentro();
        private void button1BUSCAR_Click(object sender, EventArgs e)
        {
            if (centro.verificarNumero(textBuscar.Text) == true)
            {
                if (med.MostrarInfomedico(Convert.ToInt32(textBuscar.Text),nombre).Rows.Count>0)
                {
                    DGbuscar.DataSource = med.MostrarInfomedico(Convert.ToInt32(textBuscar.Text),nombre);
                    textBuscar.Text = string.Empty;
                }
                else
                {
                    if (MessageBox.Show("la cedula " + textBuscar.Text + " no se encentra en la base de datos",
                        "ERROR", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        
                    }

                }
            }
            else
            {
                MessageBox.Show("El campo Cedula tienen entrada de texto incorrecta o esta vacio, verifiquelo e intente de nuevo");
            }
           
        }

        private void buttonVOLVER_Click(object sender, EventArgs e)
        {
            Centro centro = new Centro();
            centro.Visible = true;
            Visible = false;
        }
    }
}
