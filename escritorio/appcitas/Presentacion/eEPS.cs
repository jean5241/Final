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
    public partial class eEPS : Form
    {
        public eEPS()
        {
            InitializeComponent();

        }
        string nombreEps;
        public eEPS(string nombreEps)
        {
            InitializeComponent();
            this.nombreEps = nombreEps;
        }

        GestorPaciente pac = new GestorPaciente();
        GestorEps eps = new GestorEps();

        private void eEPS_Load(object sender, EventArgs e)
        {

        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            Epss eps = new Epss();
            eps.Visible = true;
            Visible = false;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (eps.verificarNumero(textCedulaE.Text)==true)
            {


                if ((MessageBox.Show("Esta seguro que desea eliminar el Paciente con cedula"
                    + textCedulaE.Text, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes) && (pac.MostrarPacienteXCedula(Convert.ToInt32(textCedulaE.Text),nombreEps).Rows.Count >0))
                {
                    pac.EliminarPaciente(Convert.ToInt32(textCedulaE.Text),nombreEps);
                    MessageBox.Show("Se elimino correctamente");
                    textCedulaE.Text = string.Empty;
                }
                else if (MessageBox.Show("No se pudo eliminar la cedula" + textCedulaE.Text + "no se encentra en la base de datos",
                        "ERROR", MessageBoxButtons.OK) == DialogResult.OK)
                {
                   
                }
            }
            else
            {
                MessageBox.Show("El campo Cedula tienen entrada de texto incorrecta o esta vacio, verifiquelo e intente de nuevo");
            }
            
        }

    }
}
