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
    public partial class F_maestros : Form
    {
        public F_maestros()
        {
            InitializeComponent();
        }
        private void F_maestros_Load(object sender, EventArgs e)
        {
            i

        }

        private void agregar_Maestro_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_new_maestro v1= new F_new_maestro();
            v1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID_maestro;
            string query = "UPDATE tb_maestro SET nombre= '" + TB_nombre + "', ap_paterno='" + TB_ap + "',ap_materno='" + TB_am.Text + "', matricula_empleado=" + TB_matricula.Text + ", email='" + TB_email + "', telefono=" + TB_tel.Text + "WHERE pk_maestro =" + ID_maestro + ";";
            MessageBox.Show("Datos actualizados"); 


        }
    }
}
