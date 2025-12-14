using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Phong_Hoc.Module
{
    class Ketnoi
    {
        string strCon = @"Data Source=DESKTOP-S55GF51\MSSQLSERVER233;Initial Catalog=QLPhongHoc;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRe;
        SqlDataAdapter sqlAdap;
        public DataTable LoadDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public void DataGridViewLoad_GV(string strSelect, DataGridView dg)
        {
            try
            {
                dg.Rows.Clear();
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    using (SqlCommand sqlCom = new SqlCommand(strSelect, sqlCon))
                    using (SqlDataReader sqlRe = sqlCom.ExecuteReader())
                    {
                        while (sqlRe.Read())
                        {
                            object[] rowData = new object[sqlRe.FieldCount];
                            sqlRe.GetValues(rowData);
                            int rowIndex = dg.Rows.Add(rowData);
                            int lastColIndex = dg.ColumnCount - 1;
                            if (rowData[lastColIndex].ToString() == "0")
                            {
                                dg.Rows[rowIndex].Cells[lastColIndex].Value = "Hoạt động";
                            }
                            else if (rowData[lastColIndex].ToString() == "1")
                            {
                                DataGridViewButtonCell btn = new DataGridViewButtonCell();
                                btn.Value = "Chờ duyệt";
                                dg.Rows[rowIndex].Cells[lastColIndex] = btn;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu:\n" + ex.Message);
            }
        }
        public void ComboboxLoad(string strSelect, ComboBox cb)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlCom = new SqlCommand(strSelect, sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            cb.Items.Clear();
            while (sqlRe.Read())
            {
                string ten = sqlRe[0].ToString();
                string ma = sqlRe[1].ToString();
                ComboboxItem item = new ComboboxItem
                {
                    Ten = ten,
                    Ma = ma
                };
                cb.Items.Add(item);
            }
            sqlCon.Close();
        }
        public void ComboboxLoad2(string strSelect, ComboBox cb)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlCom = new SqlCommand(strSelect, sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            cb.Items.Clear();
            while (sqlRe.Read())
            {
                string ten = sqlRe[0].ToString();
                cb.Items.Add(ten);
            }
            sqlCon.Close();
        }
        public string GetUID(string username)
        {
            string ID = "";
            string query = "SELECT Magv FROM TB_GV WHERE Taikhoan = @tk";
            using (SqlConnection conn = new SqlConnection(strCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tk", username);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    ID = result.ToString();
                }
            }
            return ID;
        }
        public string GetID(string strSelect)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlCom = new SqlCommand(strSelect, sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            string ma = "";
            while (sqlRe.Read())
            {
                 ma = sqlRe[0].ToString();
               
            }
            sqlCon.Close();
            return ma;
        }
        public string GetTT(string strSelect)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlCom = new SqlCommand(strSelect, sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            string ma = "";
            while (sqlRe.Read())
            {
                ma = sqlRe[0].ToString();

            }
            sqlCon.Close();
            return ma;
        }
        public void DataGridViewLoad(string strSelect, DataGridView dg)
        {
            try
            {
                dg.Rows.Clear();
                using (SqlConnection sqlCon = new SqlConnection(strCon))
                {
                    sqlCon.Open();
                    using (SqlCommand sqlCom = new SqlCommand(strSelect, sqlCon))
                    using (SqlDataReader sqlRe = sqlCom.ExecuteReader())
                    {
                        while (sqlRe.Read())
                        {
                            object[] rowData = new object[sqlRe.FieldCount];
                            sqlRe.GetValues(rowData);
                            dg.Rows.Add(rowData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu:\n" + ex.Message);
            }
        }
        public int KiemTraMaTrung(string strSelect)
        {
            int sbg = 0;
            DataTable dtSelect = new DataTable();
            sqlAdap = new SqlDataAdapter(strSelect, strCon);
            sqlAdap.Fill(dtSelect);
            sbg = dtSelect.Rows.Count;
            return sbg;
        }
        public void ThucThi(string strSQL)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();
            sqlCon.Close();
        }
        public int KiemtraTonTai(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var p in parameters)
                        {
                            cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                        }
                    }
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public string DangNhap(string username, string password)
        {
            string quyen = "";
            string query = "SELECT Quyen FROM TB_GV WHERE Taikhoan = @tk AND Matkhau = @mk ";
            using (SqlConnection conn = new SqlConnection(strCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tk", username);
                cmd.Parameters.AddWithValue("@mk", password);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    quyen = result.ToString();
                }  
            }
            return quyen;
        }
    }
}
