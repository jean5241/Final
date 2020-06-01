using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Reporte : Form
    {
        string nombre;
        DateTime fecha = DateTime.Now.Date;
        public Reporte(string nombreCentro)
        {
            InitializeComponent();
            nombre = nombreCentro;
        }
       // public DateTime Fecha { get; set; }
       // public string nombre { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosInforme.ConsultarNumeroReservas' Puede moverla o quitarla según sea necesario.
            this.ConsultarNumeroReservasTableAdapter.Fill(this.DatosInforme.ConsultarNumeroReservas, Convert.ToDateTime(fecha.ToString("yyyy-MM-dd")), nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
