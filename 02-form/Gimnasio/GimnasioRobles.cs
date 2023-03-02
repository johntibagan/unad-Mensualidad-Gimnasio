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

        }

       
    }
}
