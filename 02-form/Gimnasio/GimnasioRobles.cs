using Gimnasio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class GimnasioRobles : Form
    {
        public GimnasioRobles()
        {
            InitializeComponent();
        }

        public void GimnasioRobles_Load(object sender, EventArgs e)
        {
            btn_calcule.Cursor = Cursors.Hand;
            btn_close.Cursor = Cursors.Hand;
            btn_register.Cursor = Cursors.Hand;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            txt_identification.Clear();
            txt_name.Clear();
            txt_salary.Clear();
            txt_stratum.Clear();
            txt_total.Clear();
        }

        private void btn_calcule_Click(object sender, EventArgs e)
        {
            calcularMensualidad();
        }

        private void calcularMensualidad()
        {
            Usuario usuario = new Usuario();
            usuario.Identificacion = txt_identification.Text;
            usuario.Nombre = txt_name.Text;
            usuario.Sueldo = float.Parse(txt_salary.Text);
            usuario.Estrato = int.Parse(txt_stratum.Text);
            usuario.Genero = rbtn_male.Checked ? 'M' : 'F';

            usuario.Mensualidad = usuario.calcularMensualidad();
            usuario.Descuento = usuario.calcularDescuento(usuario.Mensualidad);
            usuario.TotalMensualidad = usuario.Mensualidad - usuario.Descuento;

            Report report = new Report();
            report.usuario = usuario;
            report.Show();
            txt_total.Text = usuario.TotalMensualidad.ToString("c");

        }


    }
}
