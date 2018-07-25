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
    public partial class frmConsultarRegistro : Form
    {
        public frmConsultarRegistro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"server=LENOVO-PC\SQLTABULAR; database=DemoSeccionB ; integrated security = true");
            conexion.Open();
            string strCodigo = txtCodigo.Text;

            string cadena = "select descripcion, precio from articulos where codigo=" + strCodigo;
            
            SqlCommand comando = new SqlCommand(cadena, conexion);

            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                lblDescripcion.Text = registro["descripcion"].ToString();
                lblPrecio.Text = registro["precio"].ToString();
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();
        }
    }
}
