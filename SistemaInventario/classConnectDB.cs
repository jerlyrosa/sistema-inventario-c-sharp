using System.Data.SqlClient;
using System.Data;

namespace connectionDb
{
    class connection
    {
        // Change data source for your local server
        string provider = @"Data Source=DESKTOP-1B3K7PC;" +
                "Initial Catalog=TIENDA;" +
                "Integrated Security=True";

        public SqlConnection connect = new SqlConnection();

        public connection()
        {
            connect.ConnectionString = provider;
        }


    }
    public class classClienterData
    {
        public Boolean registrarCliente(string name,string lastname, string address, string email, string password, string fullName)
        {
            connection database = new connection();
            database.connect.Open();

            SqlCommand cmd = new SqlCommand("RESGISTRARUSUARIOS", database.connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@contrasena", password);


            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }


        public DataTable getClientes()
        {
            connection database = new connection();
            database.connect.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("GETUSUARIOS", database.connect);

            DataTable data = new DataTable();
            adapter.Fill(data);


            return data;


        }








    }

}





