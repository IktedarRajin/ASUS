using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AIUB_Parking_Management_System
{
    class DataAccess
    {
        private SqlConnection sqlConnection;

        public SqlConnection SqlConnection
        {
            set; get;
        }

        private SqlCommand sqlCommand;

        public SqlCommand SqlCommand
        {
            set; get;
        }

        private SqlDataAdapter sqlDataAdapter;
        public SqlDataAdapter SqlDataAdapter
        {
            set; get;
        }

        private DataSet dataSet;
        public DataSet DataSet
        {
            set; get;
        }

        public DataAccess()
        {
            this.SqlConnection = new SqlConnection(@"Data Source=RUSHDIZPC\SQLEXPRESS;Initial Catalog=AiubParking;Integrated Security=True");
            this.SqlConnection.Open();
        }

        private void Query(string query)
        {
            this.SqlCommand = new SqlCommand(query, this.SqlConnection);
        }
        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.Query(sql);
                this.SqlDataAdapter=new SqlDataAdapter(this.SqlCommand);
                this.DataSet = new DataSet();
                this.SqlDataAdapter.Fill(this.DataSet);
                return this.DataSet;
            }
            catch
            {
                return null;
            }
        }
        public int ExexuteQuery(string sql)
        {
            this.Query(sql);
            int row = this.SqlCommand.ExecuteNonQuery();
            return row;
        }
    }
}
