using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Presentacion
{
    public partial class Inicio : Form
    {
      
        public Inicio()
        {
            InitializeComponent();
            AbrirFormInPanel(new Introduccion());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg,int wparam,int lparam);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BnOpciones_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 205)
            {
                MenuVertical.Width = 60;
            }
            else
            {
                MenuVertical.Width = 205;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnRestaurar.Visible = true;
            BtnMax.Visible = false;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMax.Visible = true;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void PanelHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
        
        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new LoginPacientes());
        }
     
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }



        private void BtnEps_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new LoginEps());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new LoginCentroMedico());

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }
        public void Cerrar()
        {
            this.Close();
            PanelHorizontal.Visible = false;
            PanelContenedor.Visible = false;
            MenuVertical.Visible=false;
           
           // Inicio.
           
        }

        private void PanelHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Inicio_FormClosing( FormClosingEventArgs e)
        {
            this.Visible = false;
           
        }

      

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelHorizontal_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Introduccion());
        }
    }
}
