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
    public partial class Report : Form
    {
        public Usuario usuario = new Usuario();

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            lbl_identification.Text = usuario.Identificacion;
            lbl_name.Text = usuario.Nombre;
            lbl_salary.Text = usuario.Sueldo.ToString("c");
            lbl_stratum.Text = usuario.Estrato.ToString();
            lbl_gender.Text = usuario.Genero == 'M' ? "Masculino" : "Femenino";

            lbl_month.Text = usuario.Mensualidad.ToString("c");
            lbl_discount.Text = usuario.Descuento.ToString("c");
            lbl_total.Text = usuario.TotalMensualidad.ToString("c");
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
