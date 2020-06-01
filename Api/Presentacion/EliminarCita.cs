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
    public partial class EliminarCita : Form
    {
        GestorCita obj1 = new GestorCita();
        string nombre;
        public EliminarCita(string nombreCentro)
        {
            InitializeComponent();
            nombre = nombreCentro;
            if (obj1.ObtenerCita(nombreCentro).Rows.Count > 0)
            {
                dataGridCitas.DataSource = obj1.ObtenerCita(nombreCentro);
            }
            else
            {
                MessageBox.Show("No hay citas agregadas");
                Eliminar.Enabled = false;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
           
                try
                {
                    obj1.EliminarCita(Convert.ToInt32(dataGridCitas.CurrentRow.Cells[0].Value.ToString()));
                    dataGridCitas.DataSource = obj1.ObtenerCita(nombre);
                    MessageBox.Show("Se elimino correctamente");
                }
                catch (Exception l)
                {
                    MessageBox.Show("se presento un error al eliminar: " + l.Message);
                }
            
         
        }
        
    }
}
