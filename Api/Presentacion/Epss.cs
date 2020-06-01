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
    public partial class Epss : Form
    {
        string nombreEps;
        public Epss(string nombreEps)
        {
            InitializeComponent();
            this.nombreEps = nombreEps;
           AbrirFormInPanel(new IntroduccionEps());
        }
        public Epss()
        {
            InitializeComponent();
            AbrirFormInPanel(new IntroduccionEps());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new eEPS(nombreEps));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new aiEPS(nombreEps));
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

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new aEPS(nombreEps));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new EpsXCentro(nombreEps));
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new IntroduccionEps());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new IntroduccionEps());
        }
    }
}
