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
    public partial class aEPS : Form
    {
        public aEPS()
        {
            InitializeComponent();
        }
        string nombreEps;

        public aEPS(string nombreEps)
        {
            InitializeComponent();
            this.nombreEps = nombreEps;
        }
        GestorPaciente pac = new GestorPaciente();
        GestorEps eps = new GestorEps();
        private void button1BUSCAR_Click(object sender, EventArgs e)
        {
            if (eps.verificarNumero(textBuscar.Text) == true)
            {
                DataTable dt = new DataTable();
                dt = pac.MostrarPacienteXCedula(Convert.ToInt32(textBuscar.Text),nombreEps);
                if (dt.Rows.Count >0)
                {
                    DGbuscar.DataSource = pac.MostrarPacienteXCedula(Convert.ToInt32(textBuscar.Text),nombreEps);
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
        }

        
    }
}
