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
    public partial class InsertarCita : Form
    {
        Gestorcentro centro = new Gestorcentro();
        GestorCita cita = new GestorCita();
        public InsertarCita()
        {
            InitializeComponent();
          
        }
        string nombreCentro;
        public InsertarCita(string nombreCentro)
        {
            InitializeComponent();
            this.nombreCentro = nombreCentro;
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if((textHoraFin.Text != string.Empty) && (textHoraIn.Text != string.Empty) && (textFecha.Text != string.Empty) && textConsultorio.Text != string.Empty)
            try
            {
                cita.InsertarCita(nombreCentro,Convert.ToDateTime(textHoraIn.Text), Convert.ToDateTime(textHoraFin.Text), Convert.ToDateTime(textFecha.Text),textConsultorio.Text);
                MessageBox.Show("Registrado Correctamente");
                    textConsultorio.Text = string.Empty;
                    textHoraIn.Text = string.Empty;
                    textFecha.Text = string.Empty;
                    textHoraFin.Text = string.Empty;
                }
            catch(Exception l)
            {
                MessageBox.Show("Se presento un error al insertar los datos: " + l.Message);
                  
                }
            else
            {
                MessageBox.Show("Ingrese todos los datos");
            }
        
        }
        public void verificarLetra(KeyPressEventArgs parametro)
        {
            if (!(char.IsLetter(parametro.KeyChar)) && (parametro.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("No se permiten campos vacios ni con espacios, ingrese letras");
                parametro.Handled = true;
                return;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void textConsultorio_TextChanged(object sender, KeyPressEventArgs e)
        {
            verificarLetra(e);
        }

        private void InsertarCita_Load(object sender, EventArgs e)
        {

        }
    }
}
