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
    public partial class F_alta_alumnos : Form
    {
        public F_alta_alumnos()
        {
            InitializeComponent();
        }

        private void BT_nuevoA_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tb_alumno (nombre, ap_paterno, ap_materno, matricula_alumno, fecha_ingreso, email, telefono) VALUES ('"+ TB_nombre.Text + "','" + TB_ap +"','" + TB_am.Text + "'," +TB_matricula.Text + ", GETDATE(),'" + TB_email + "'," +TB_Tel +");";
            MessageBox.Show("Alumno registrado");
            this.Hide();
            F_list_alumnos v1 = new F_list_alumnos();
            v1.Show();

        }
    }
}
