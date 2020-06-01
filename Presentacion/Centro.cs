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
    public partial class Centro : Form
    {
        string nombreCentro;
       
            
        public Centro()
        {
            InitializeComponent();
            Inicio inicio = new Inicio();
            inicio.Visible = false;
            AbrirFormInPanel(new IntroduccionCentro());
        }
        public Centro(string nombreCentro)
        {
            InitializeComponent();
            this.nombreCentro = nombreCentro;
            Inicio inicio = new Inicio();
            inicio.Visible = false;
            inicio.Cerrar();
            AbrirFormInPanel(new IntroduccionCentro());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void PanelHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new aiCENTRO(nombreCentro));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new eCENTRO(nombreCentro));
        }
        public void AbrirFormInPanel(object Formhijo)
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
            AbrirFormInPanel(new aCENTRO(nombreCentro));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new InsertarCita(nombreCentro));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new EliminarCita(nombreCentro));
        }

        private void PanelHorizontal_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMax.Visible = true;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnRestaurar.Visible = true;
            BtnMax.Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reporte(nombreCentro));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new IntroduccionCentro());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new IntroduccionCentro());
        }
    }
    }

