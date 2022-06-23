﻿using System.Data.SqlClient;
using System.Data;






namespace connectionDb
{
    class connection
    {
        // Change data source for your local server
        string provider = @"Data Source=DESKTOP-1B3K7PC;" +
                "Initial Catalog=INVENTARIO;" +
                "Integrated Security=True";

        public SqlConnection connect = new SqlConnection();

        public connection()
        {
            connect.ConnectionString = provider;
        }


    }
    public class classData
    {
        public Boolean registrarUsuario(string name,string lastname, string username, string address, string email, string password)
        {
            connection database = new connection();
            database.connect.Open();

            SqlCommand cmd = new SqlCommand("RESGISTRAR_USUARIO", database.connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);


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


        public Boolean loginUser(string username, string password)
        {
            connection database = new connection();
            database.connect.Open();
            SqlCommand cmd = new SqlCommand("LOGIN_USER", database.connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@contrasena", password);

            try
            {
      

     

                return true;


            }
            catch (SqlException ex)
            {
           
                return false;
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





