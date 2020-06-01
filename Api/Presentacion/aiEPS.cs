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
    public partial class aiEPS : Form
    {
        string nombreEps;
        public aiEPS(string nombreEps)
        {
            InitializeComponent();
            this.nombreEps = nombreEps;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
           
                
        }

        public void verificarLetra(KeyPressEventArgs parametro )
        {
            if (!(char.IsLetter(parametro.KeyChar)) && (parametro.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("No se permiten campos vacios ni con espacios, solo se permiten letras");
                parametro.Handled = true;
                return;
            }
           
        }

        private void textNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarLetra(e);
        }

        private void textAPELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarLetra(e);
        }

        private void textCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void textDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarLetra(e);
        }

        private void textNombreEps_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarLetra(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestorPaciente paciente = new GestorPaciente();
            GestorEps eps = new GestorEps();
            if (eps.verificarNumero(textCEDULA.Text) == true )
            {
                try
                {
                    paciente.InsertarPaciente(textNOMBRE.Text, textAPELLIDO.Text, Convert.ToInt32(textCEDULA.Text), Convert.ToInt32(textTelefono.Text), textDireccion.Text, nombreEps, txtContrasena.Text.ToString());
                    MessageBox.Show("Registrado Correctamente");
                    textNOMBRE.Text = string.Empty;
                    textAPELLIDO.Text = string.Empty;
                    textCEDULA.Text = string.Empty;
                    txtContrasena.Text = string.Empty;
                    textDireccion.Text = string.Empty;
                    textTelefono.Text = string.Empty;
                }catch(Exception l)
                {
                    MessageBox.Show("Se presento un error: "+ l.Message);
                }

            }
            else
            {
                MessageBox.Show("Algunos de los campos tienen entradas de texto incorrectas o estan vacios, verifiquelos e intente de nuevo");
            }

        }
    }
}
