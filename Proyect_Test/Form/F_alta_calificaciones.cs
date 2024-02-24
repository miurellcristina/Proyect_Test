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
    public partial class F_alta_calificaciones : Form
    {
        public F_alta_calificaciones()
        {
            InitializeComponent();
        }

        private void F_alta_calificaciones_Load(object sender, EventArgs e)
        {

        }

        private void BT_agregar_calificacion_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tb_calificaciones (fk_maestro, fk_alumno, fk_materia, calificacion, observaciones) VALUES ();";
            MessageBox.Show("Calificacion registrada");
            this.Hide();
            F_list_alumnos v1 = new F_list_alumnos();
            v1.Show();
        }
    }
}
