using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizacija_na_farma
{
    public class DataAcess
    {

        public SqlConnection conn { get; set; }

        public SqlConnection getConnection()
        {
            conn = new SqlConnection("Data Source=194.149.138.63;Initial Catalog=FarmaSQL;Persist Security Info=True;User ID=sa;Password=L0z1nk@z@baza!");
            //conn = new SqlConnection("Server=.\\FARMASQL;Database=Farma;Integrated Security=true");
            return conn;
        }

        public void cmdCommand(SqlCommand cmd)
        {
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

   }
}
