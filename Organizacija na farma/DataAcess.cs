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
            conn= new SqlConnection("Server=.\\FARMASQL;Database=Farma;Integrated Security=true");
            return conn;
        }

        public void cmdInesrt(SqlCommand cmd)
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

        public void cmdUpdate(SqlCommand cmd)
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
        public void cmdSelect(SqlCommand cmd)
        {
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                //listBox1.Items.Clear();
                while (reader.Read())
                {
                    //if (reader.GetString(0) != null)
                    // listBox1.Items.Add(string.Format("{0}", reader.GetString(0)));
                }
                //label1.Text = " Uspesno vtoro";
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                // label1.Text = "Exeption cmd";
            }
        }
    }
}
