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
    public partial class ReservarCita : Form
    {
        Gestorcentro obj1 = new Gestorcentro();
        GestorCita obj2 = new GestorCita();
        int cedula;
        public ReservarCita(int cedula)
        {
            InitializeComponent();
            comboBoxNombreCentro.DataSource = obj1.MostrarNombreCentroMedico(cedula);
            comboBoxNombreCentro.ValueMember = "Nombre";
           comboBoxNombreCentro.DisplayMember = "Nombre";
            this.cedula = cedula;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCitas_Click(object sender, EventArgs e)
        {
            if (obj2.ObtenerCita(comboBoxNombreCentro.Text).Rows.Count > 0)
            {
                dataGridViewCitas.DataSource = obj2.ObtenerCita(comboBoxNombreCentro.Text);
            }
            else
            {
                obj2.NoCita(cedula);
                MessageBox.Show("No se encuentran citas disponibles en este momento intentalo mas tarde");
                buttonReservarCita.Enabled = false;
            }
        }

        private void buttonReservarCita_Click(object sender, EventArgs e)
        {
            obj2.ReservarCita(Convert.ToInt32(dataGridViewCitas.CurrentRow.Cells[0].Value.ToString()), cedula);
            if (obj2.ObtenerCita(comboBoxNombreCentro.Text).Rows.Count > 0)
            {
                dataGridViewCitas.DataSource = obj2.ObtenerCita(comboBoxNombreCentro.Text);
            }
            else
            {
                obj2.NoCita(cedula);
                MessageBox.Show("No se encuentran citas disponibles en este momento intentalo mas tarde");
                buttonReservarCita.Enabled = false;
            }
        }
    }
}
