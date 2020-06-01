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
    public partial class aiCENTRO : Form
    {
        public aiCENTRO()
        {
            InitializeComponent();
        }
        string nombre;
        public aiCENTRO(string nombreCentro)
        {
            InitializeComponent();
            nombre = nombreCentro;
        }

        GestorMedico medico = new GestorMedico();
        Gestorcentro centro = new Gestorcentro();

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if ((centro.verificarNumero(textCEDULA.Text)==true) && (textNOMBRE.Text!=string.Empty) && (textAPELLIDO.Text != string.Empty)&& (textCEDULA.Text != string.Empty))

            {
                medico.Insertarmedico(textNOMBRE.Text, textAPELLIDO.Text, Convert.ToInt32(textCEDULA.Text), nombre);
                MessageBox.Show("Registrado Correctamente");
                textNOMBRE.Text = string.Empty;
                textAPELLIDO.Text = string.Empty;
                textCEDULA.Text = string.Empty;
               
            }
            else
            {
                MessageBox.Show("Algunos de los campos tienen entradas de texto incorrectas o estan vacios, verifiquelos e intente de nuevo");
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
       

        private void button1_Click(object sender, EventArgs e)
        {
            Centro cmedico = new Centro();
            cmedico.Visible = true;
            Visible = false;
        }


        private void textNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarLetra(e);
        }

        private void textAPELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarLetra(e);
        }

        private void textNombreCentro_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarLetra(e);
        }

        private void textNombreCentro_TextChanged(object sender, EventArgs e)
        {

        }
        private void textNOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      
    }
}
