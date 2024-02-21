using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02
{
    class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public DataTable Load(string sqlStr)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dataTable);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Xuat du lieu that bai\nCau sql: " + sqlStr + "\n" + exc);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public void Execute(string sqlStr, string action)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show(action + " thanh cong");
            }
            catch (Exception exc)
            {
                MessageBox.Show(action + " that bai\nCau sql: " + sqlStr + "\n" + exc);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
