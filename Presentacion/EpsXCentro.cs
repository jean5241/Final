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
    public partial class EpsXCentro : Form
    {
        GestorEps obj1 = new GestorEps();
        Gestorcentro obj2 = new Gestorcentro();
        string nombreEps;
        public EpsXCentro(string nombreEps)
        {
            InitializeComponent();
            this.nombreEps = nombreEps;
            comboBoxNombreCentro.DataSource = obj2.MostrarInfocentros();
            comboBoxNombreCentro.DisplayMember = "Nombre";
            comboBoxNombreCentro.ValueMember = "Nombre";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            obj1.AsignarEpsACentroMedico(nombreEps, comboBoxNombreCentro.Text);
            MessageBox.Show("Se asigno correctamente");
        }
    }
}
