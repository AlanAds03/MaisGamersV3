using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Frameworks
{
    
    public class Conexao<T> : IDisposable
    {
        
        private static IDbConnection connection;
        private static IDbCommand command;

        public Conexao()
        {
            connection = new OdbcConnection("Data Source=.; DataBase=maisGamers;user=sa;pwd=qweasd");
        }

        public bool Conectar()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
            

        }

        public IDataReader ExecuteReader(string query, List<IDbDataParameter> parameters )
        {
            IDataReader reader;
            command.CommandText = query;
            command.Connection = connection;

            if (parameters.Any()) { 
                foreach (var param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }
            reader = command.ExecuteReader();
            return reader;

        }

        public DataTable ExecuteDataTable(string query, List<IDbDataParameter> parameters)
        {


            IDataReader reader;
            command.CommandText = query;
            command.Connection = connection;

            DataTable table = new DataTable();
            if (parameters.Any())
            {
                foreach (var param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            reader = command.ExecuteReader();
            table.Load(reader);
            return table;

        }

        public bool ExecuteNowQuery(string query, List<IDbDataParameter> parameters)
        {


            IDataReader reader;
            command.CommandText = query;
            command.Connection = connection;

            DataTable table = new DataTable();
            if (parameters.Any())
            {
                foreach (var param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            reader = command.ExecuteReader();
            table.Load(reader);
            return table;

        }



        public Object ExecuteScalar(string query, List<IDbDataParameter> parameters)
        {
            
            command.CommandText = query;
            command.Connection = connection;
            if (parameters.Any())
            {
                foreach (var param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }
            return command.ExecuteScalar();
        }

        public void Dispose()
        {
            command = null;
            connection.Close();
            connection.Dispose();
        }
    }
}
