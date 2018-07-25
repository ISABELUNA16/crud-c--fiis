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
    public partial class frmInsertarRegistro : Form
    {
        public frmInsertarRegistro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"server=LENOVO-PC\SQLTABULAR; database=DemoSeccionB ; integrated security = true");
            conexion.Open();


            string strDescripcionArticulo = txtDescripcionArticulo.Text;
            string strPrecio = txtPrecio.Text;

            string cadena = "insert into articulos(descripcion,precio) values ('" + strDescripcionArticulo + "'," + strPrecio + ")";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();


            MessageBox.Show("Los datos se guardaron correctamente");

            txtDescripcionArticulo.Text = "";
            txtPrecio.Text = "";
            
        }
    }
}
