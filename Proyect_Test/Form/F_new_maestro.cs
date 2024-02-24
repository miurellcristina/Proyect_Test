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
    public partial class F_new_maestro : Form
    {
        public F_new_maestro()
        {
            InitializeComponent();
        }

        private void agregar_M_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tb_maestro (nombre, ap_paterno, ap_materno, matricula_alumno, fecha_ingreso, email, telefono) VALUES ('" + TB_nombre.Text + "','" + TB_ap + "','" + TB_am.Text + "'," + TB_matricula.Text + ", GETDATE(),'" + TB_email + "'," + TB_Tel + ");";
            MessageBox.Show("Maestro registrado");
            this.Hide();
            F_maestros v1 = new F_maestros();
            v1.Show();
        }
    }
}
