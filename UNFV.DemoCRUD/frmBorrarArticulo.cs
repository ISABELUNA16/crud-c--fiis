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
    public partial class frmBorrarArticulo : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=LENOVO-PC\SQLTABULAR; database=DemoSeccionB ; integrated security = true");

        public frmBorrarArticulo()
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
                lblDescripcion.Text = registro["descripcion"].ToString();
                lblPrecio.Text = registro["precio"].ToString();
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            conexion.Close();

            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int cant;
            conexion.Open();
            string strCodigo = txtCodigo.Text;
            string cadena = "delete from articulos where codigo=" + strCodigo;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            
            cant = comando.ExecuteNonQuery();
            conexion.Close();

            if (cant == 1)
            {
                MessageBox.Show("Se borró el artículo");
                lblDescripcion.Text = "";
                lblPrecio.Text = "";
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
            
            btnBorrar.Enabled = false;
        }
    }
}
