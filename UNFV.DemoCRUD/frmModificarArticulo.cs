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
    public partial class frmModificarArticulo : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=LENOVO-PC\SQLTABULAR; database=DemoSeccionB ; integrated security = true");

        public frmModificarArticulo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string strCodigo = txtCodigo.Text;

            string cadena = "select descripcion, precio from articulos where codigo=" + strCodigo;

            SqlCommand comando = new SqlCommand(cadena, conexion);

            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                txtDescripcion.Text = registro["descripcion"].ToString();
                txtPrecio.Text = registro["precio"].ToString();
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();

            btnActualizar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int cant;
            conexion.Open();
            string strCodigo = txtCodigo.Text;
            string strDescripcion = txtDescripcion.Text;
            string strPrecio = txtPrecio.Text;

            string cadena = "update articulos set descripcion='" + strDescripcion + "', precio=" + strPrecio + " where codigo=" + strCodigo;
            
            SqlCommand comando = new SqlCommand(cadena, conexion);

            cant = comando.ExecuteNonQuery();
            conexion.Close();


            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                txtPrecio.Text = "";
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            
            btnActualizar.Enabled = false;
        }
    }
}
