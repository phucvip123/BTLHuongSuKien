using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance {
            get
            {
                if (instance == null) instance = new DataProvider();
                return  DataProvider.instance;
            }
            private set => instance = value; 
        }
        private DataProvider() { }
        private string strcn = @"Data Source=PHUC\PHUC;Initial Catalog=QUANLYQUANAN;Integrated Security=True";
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using(SqlConnection cnn = new SqlConnection(strcn)) {
                cnn.Open();
 
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }



                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);

                }
                    cnn.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection cnn = new SqlConnection(strcn))
            {
                cnn.Open();

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    data = cmd.ExecuteNonQuery();

                }
                cnn.Close();
            }
            return data;
        }
        public object ExcutScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection cnn = new SqlConnection(strcn))
            {
                cnn.Open();

                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    data = cmd.ExecuteScalar();

                }
                cnn.Close();
            }
            return data;
        }
    }
    
}
