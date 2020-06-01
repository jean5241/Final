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
    public partial class LoginCentroMedico : Form
    {
        public LoginCentroMedico()
        {
            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            GestorAdminCentro obj3 = new GestorAdminCentro();
         /* Centro centro = new Centro(USUARIO.Text);
            centro.Visible = true;
            this.Visible = false;*/

          // int temp2 = 0;



           if (USUARIO.Text!=String.Empty && CONTRASENA.Text!=String.Empty)
             {
                 bool si3 = obj3.ValidarAdminCentro(USUARIO.Text, CONTRASENA.Text.ToString());
                 if (si3 == true)
                 {
                   
                    
                    Centro centro = new Centro(USUARIO.Text);
                    centro.Visible = true;
                    this.Visible = false;

                 }
                 else
                 {
                     USUARIO.Text = "";
                     CONTRASENA.Text = "";
                     MessageBox.Show("Lo sentimos, sus credenciales no se encuentran registradas "
                         + " Verifiquelas e intentelo de nuevo");
                 }
             }
             else
             {
                 MessageBox.Show("Por favor ingrese todos los campos");
             }

           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Lo sentimos si olvido su contraseña para obtener una nueva dirijase a su centro de atencion medica " +
               " y alla le daran una nueva");
        }

        private void CONTRASENA_TextChanged(object sender, EventArgs e)
        {
            CONTRASENA.PasswordChar = '*';
            CONTRASENA.MaxLength = 14;
            if (CONTRASENA.MaxLength > 14)
            {
                MessageBox.Show("La contraseña no puede superar los 14 caracteres");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void USUARIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
