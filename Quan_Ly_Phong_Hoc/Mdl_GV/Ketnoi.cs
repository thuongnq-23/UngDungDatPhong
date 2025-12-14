using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Phong_Hoc.Mdl_GV
{
    class Ketnoi
    {
        string strCon = @"Data Source=DESKTOP-S55GF51\MSSQLSERVER233;Initial Catalog=QLPhongHoc;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRe;
        SqlDataAdapter sqlAdap;

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
        public string GetID22(string strSelect)
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
        public string GetID(string username)
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
        public string GetMaca(string tenca, string giobatdau, string gioketthuc)
        {
            string ID = "";
            string query = "SELECT Maca FROM TB_Cahoc WHERE mota = @mota And Giobatdau = @batdau AND Gioketthuc = @ketthuc";
            using (SqlConnection conn = new SqlConnection(strCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@mota", tenca);
                cmd.Parameters.AddWithValue("@batdau", giobatdau);
                cmd.Parameters.AddWithValue("@ketthuc", gioketthuc);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    ID = result.ToString();
                }
            }
            return ID;
        }
        public string GetMaPhong(string loaiphong, string tenphong, string vitri)
        {
            string ID = "";
            string sql = @"
            SELECT Maphong 
            FROM TB_Phong 
            WHERE Loaiphong = @loaiphong 
              AND Tenphong = @tenphong 
              AND Vitri = @vitri";
            using (SqlConnection conn = new SqlConnection(strCon))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@loaiphong", loaiphong.Trim());
                cmd.Parameters.AddWithValue("@tenphong", tenphong.Trim());
                cmd.Parameters.AddWithValue("@vitri", vitri.Trim());
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    ID = result.ToString();
                }
            }

            return ID;
        }

        public string MA;
        public void ComboboxLoad(string strSelect, ComboBox cb)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlCom = new SqlCommand(strSelect, sqlCon);
            sqlRe = sqlCom.ExecuteReader();
            cb.Items.Clear();
            while (sqlRe.Read())
            {
               
                cb.Items.Add(sqlRe[0].ToString());
                if (sqlRe.FieldCount > 1 && !sqlRe.IsDBNull(1))
                {
                    MA = sqlRe[1].ToString();
                }
            }
            sqlCon.Close();
        }
        public  bool KiemTraTrungLich(string maPhong, string ngayDung, string maCa)
        {
            string query = @"SELECT COUNT(*) 
                     FROM TB_LichsuDP 
                     WHERE MaPhong = @maphong 
                     AND NgayDung = @ngaydung 
                     AND MaCa = @maca";
            using (SqlConnection conn = new SqlConnection(strCon))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maphong", maPhong);
                    cmd.Parameters.AddWithValue("@ngaydung", ngayDung);
                    cmd.Parameters.AddWithValue("@maca", maCa);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    conn.Close();
                    return count > 0;
                }
            }
        }
        
        public void ThucThi(string strSQL)
        {
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            sqlCom = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();
            sqlCon.Close();
        }
        public void ThucThi_dung(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand sqlCom = new SqlCommand(query, sqlCon))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            sqlCom.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }
                    sqlCom.ExecuteNonQuery();
                }
            }
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

    }
}
