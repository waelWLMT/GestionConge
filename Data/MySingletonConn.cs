using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MySingletonConn
    {
        private string _connectionString;
        public SqlConnection Connection {  get; set; }
        
        private static MySingletonConn _instance;

        private MySingletonConn()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["GestConge_dbStr"].ConnectionString;
            //this._connectionString = "Data Source=.;Initial Catalog=GestionConge;Integrated Security=True;MultipleActiveResultSets=True";
            this.Connection = new SqlConnection(this._connectionString);
        }

        public static MySingletonConn getInstance()
        {
           if(_instance == null)
                _instance = new MySingletonConn();

           return _instance;

        }

       


    }
}
