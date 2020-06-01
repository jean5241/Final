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
    public partial class MostrarCita : Form
    {
        GestorCita obj1 = new GestorCita();
        int cedula;
        public MostrarCita(int cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            if (obj1.CitaXPaciente(cedula).Rows.Count > 0)
            {
                dataGridViewCitas.DataSource = obj1.CitaXPaciente(cedula);
            }
            else
            {
                MessageBox.Show("No tiene ninguna cita agendada");
                buttonCancelar.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(obj1.CancelarCita(Convert.ToInt32(dataGridViewCitas.CurrentRow.Cells[0].Value.ToString()), Convert.ToDateTime(dataGridViewCitas.CurrentRow.Cells[5].Value.ToString()), dataGridViewCitas.CurrentRow.Cells[3].Value.ToString()));
                dataGridViewCitas.DataSource = obj1.CitaXPaciente(cedula);
            }
            catch (Exception l)
            {
                MessageBox.Show("No se pudo cancelar: " + l.Message);
            }
        }
    }
}
