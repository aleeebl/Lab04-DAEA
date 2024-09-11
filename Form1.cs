using System.Data.SqlClient;
using System.Data;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {


            string cadena = "Server=LAB1507-21\\SQLEXPRESS01; Database=Neptuno; Integrated Security=True";
            SqlConnection connection = new SqlConnection(cadena);

            connection.Open();

            SqlCommand command = new SqlCommand("USP_ListarCategoria", connection);
            command.CommandType = CommandType.StoredProcedure;

            List<Categoria> listaClientes = new List<Categoria>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                Categoria categoria = new Categoria();
                categoria.idcategoria = reader["idcategoria"].ToString();
                categoria.nombrecategoria = reader["nombrecategoria"].ToString();
                categoria.descripcion = reader["descripcion"].ToString();

                listaClientes.Add(categoria);
            }
            connection.Close();

            dgvcategoria.DataSource = listaClientes;


        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cadena = "Server=LAB1507-21\\SQLEXPRESS01; Database=Neptuno; Integrated Security=True";
            SqlConnection connection = new SqlConnection(cadena);

            connection.Open();

            SqlCommand command = new SqlCommand("USP_ListarProductos", connection);
            command.CommandType = CommandType.StoredProcedure;

            List<Producto> listaClientes = new List<Producto>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                Producto producto = new Producto();
                producto.idproducto = reader["idproducto"].ToString();
                producto.nombreproducto = reader["nombreproducto"].ToString();
                producto.idproveedor = reader["idproveedor"].ToString();
                producto.idcategoria = reader["idcategoria"].ToString();

                listaClientes.Add(producto);
            }
            connection.Close();

            dgvproductos.DataSource = listaClientes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cadena = "Server=LAB1507-21\\SQLEXPRESS01; Database=Neptuno; Integrated Security=True";
            SqlConnection connection = new SqlConnection(cadena);

            connection.Open();

            SqlCommand command = new SqlCommand("USP_ListarProveedores", connection);
            command.CommandType = CommandType.StoredProcedure;

            List<Proveedores> listaClientes = new List<Proveedores>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                Proveedores proveedores = new Proveedores();
                Proveedores.idproveedor = reader["idproveedor"].ToString();


    

                listaClientes.Add(proveedores);
            }
            connection.Close();

            dgvproveedores.DataSource = listaClientes;
        }
    }
}
                               