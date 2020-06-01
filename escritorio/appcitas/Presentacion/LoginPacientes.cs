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
using System.Net;
using System.Net.NetworkInformation;
namespace Presentacion
{
    public partial class LoginPacientes : Form
    {
        public LoginPacientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GestorPaciente obj = new GestorPaciente();
          
            int temp = 0;
         
                        if (int.TryParse(USUARIO.Text, out temp))
                        {
                            bool si = obj.ValidarPaciente(Convert.ToInt32(USUARIO.Text), CONTRASENA.Text.ToString());
                            if (si == true)
                            {
                                 obj.LoginRegistro(Convert.ToInt32(USUARIO.Text));
                                 Pacientes pacientes = new Pacientes(Convert.ToInt32(USUARIO.Text));
                                 pacientes.Visible = true;
                                 this.Visible = false;
                                 Inicio inicio = new Inicio();
                                 inicio.Visible = false;
                            }
                            else
                            {
                                IPHostEntry host;
                                string localIP = "";
                                 host = Dns.GetHostEntry(Dns.GetHostName());
                                foreach (IPAddress ip in host.AddressList)
                                 {
                                  if (ip.AddressFamily.ToString() == "InterNetwork")
                                    {
                                     localIP = ip.ToString();
                                 }
                                 }
                                obj.LoginError(Convert.ToInt32(USUARIO.Text),localIP);
                                USUARIO.Text = "";
                                CONTRASENA.Text = "";
                                MessageBox.Show("Lo sentimos, sus credenciales no se encuentran registradas "
                                    + " Verifiquelas e intentelo de nuevo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo Usuario esta incorrecto, deben ser numeros");
                        }
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            //textContraseña.Text = "";
            CONTRASENA.PasswordChar='*';
            CONTRASENA.MaxLength = 14;
            if (CONTRASENA.MaxLength > 14)
            {
                MessageBox.Show("La contraseña no puede superar los 14 caracteres");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Lo sentimos si olvido su contraseña para obtener una nueva dirijase a su centro de atencion medica " +
                " y alla le daran una nueva");
        }
    }
}
