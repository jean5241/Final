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
    public partial class eCENTRO : Form
    {
        public eCENTRO()
        {
            InitializeComponent();
        }
        string nombre;
        public eCENTRO(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }
        GestorMedico med = new GestorMedico();

        private void buttonE_Click(object sender, EventArgs e)
        {

            if ((MessageBox.Show("Esta seguro que desea eliminar el Medico con cedula "
                + textCedulaE.Text, "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes) && (med.MostrarInfomedico(Convert.ToInt32(textCedulaE.Text),nombre).Rows.Count>0))
            {
                med.Eliminarrmedico(Convert.ToInt32(textCedulaE.Text),nombre);
                MessageBox.Show("Se elimino correctamente");
                textCedulaE.Text = string.Empty;
            }
            else
            {
                if (MessageBox.Show("No se pudo eliminar, la cedula " + textCedulaE.Text + " no se encentra en la base de datos",
                    "ERROR", MessageBoxButtons.OK) == DialogResult.OK)
                {
                   
                }

            }
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            textCedulaE.Clear();

            Centro centro = new Centro();
            centro.Visible = true;
            Visible = false;
        }

        private void eCENTRO_Load(object sender, EventArgs e)
        {

        }
    }
}
