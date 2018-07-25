using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNFV.DemoCRUD
{
    public partial class frmListarRegistros : Form
    {
        public frmListarRegistros()
        {
            InitializeComponent();
        }

        private void btnVerArticulos_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"server=LENOVO-PC\SQLTABULAR; database=DemoSeccionB ; integrated security = true");
            conexion.Open();

            string cadena = "select codigo, descripcion, precio from articulos";
            
            SqlCommand comando = new SqlCommand(cadena, conexion);

            SqlDataReader registros = comando.ExecuteReader();


            while (registros.Read())
            {
                txtArticulos.AppendText(registros["codigo"].ToString());
                txtArticulos.AppendText(" - ");
                txtArticulos.AppendText(registros["descripcion"].ToString());
                txtArticulos.AppendText(" - ");
                txtArticulos.AppendText(registros["precio"].ToString());
                txtArticulos.AppendText("\n");
            }
            conexion.Close();
        }

    }
}
