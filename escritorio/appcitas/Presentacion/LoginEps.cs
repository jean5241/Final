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
    public partial class LoginEps : Form
    {
        public LoginEps()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestorAdminEps obj4 = new GestorAdminEps();
            /* this.Visible = false;
             Inicio inicio = new Inicio();
             inicio.Visible = false;
             Epss eps = new Epss(USUARIO.Text);
             eps.Visible = true;*/
            // int temp4 = 0;

            

             if (USUARIO.Text != String.Empty && CONTRASENA.Text != String.Empty)
             {
                 bool si4 = obj4.ValidarAdminEps(USUARIO.Text, CONTRASENA.Text.ToString());
                 if (si4 == true)
                 {
                    
                    Epss eps = new Epss(USUARIO.Text);
                    this.Visible = false;
                    eps.Visible = true;

                   
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
                 MessageBox.Show("Porfavor ingrese todos los campos");
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
