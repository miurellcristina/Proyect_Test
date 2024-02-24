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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        private void BT_A_maestros_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_maestros v1 = new F_maestros();
            v1.Show();

        }
        private void BT_A_alumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_list_alumnos v1 = new F_list_alumnos();
            v1.Show();
        }
        private void BT_A_materias_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_alta_materia v1 = new F_alta_materia();
            v1.Show();
        }
    }
}
