using Proyect_Test.Clases;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyect_Test
{
    public partial class F_alta_materia : Form
    {
        SqlCommand comando;
        DataTable datos;
        private void F_alta_materia_Load(object sender, EventArgs e)
        {
            
            string query = "Select * from tb_materia;";
            SqlDataAdapter adap =new SqlDataAdapter(query,);
        }
        public F_alta_materia()
        {
            InitializeComponent();
            
        }      

        private void BT_agregarMateria_Click(object sender, EventArgs e)
        {
            string query= "INSERT INTO tb_materia (nombre_materia) VALUES (" + TB_nom_materia.Text + ");";
            MessageBox.Show("Materia Registrada");

        }
    }
}
