using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Test
{
    public partial class F_list_alumnos : Form
    {
        public F_list_alumnos()
        {
            InitializeComponent();
        }

        private void BT_agregarA_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_alta_alumnos v1 = new F_alta_alumnos();
            v1.Show();
        }

        private void BT_RegistrarC_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_alta_calificaciones v1 = new F_alta_calificaciones();
            v1.Show();
        }
    }
}
