using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Phong_Hoc.Module
{
    public partial class FrmDuyetPhong : Form
    {
        public FrmDuyetPhong(string ID)
        {
            UID = ID;
            InitializeComponent();
        }
        public string UID;
        Ketnoi kn = new Ketnoi();
        private void FrmDuyetPhong_Load(object sender, EventArgs e)
        {
            LoadView();
        }
        public void LoadView()
        {
            string sql = "SELECT  dp.Madatphong, p.Tenphong, gv.Hoten, dp.Ngaydung,  ch.Mota, ch.Giobatdau, ch.Gioketthuc,  lp.Loaiphong, p.Vitri, dp.Mucdich FROM TB_LichsuDP dp LEFT JOIN TB_Phong p ON dp.Maphong = p.Maphong LEFT JOIN TB_LoaiP lp ON p.Maloai = lp.Maloaiphong LEFT JOIN TB_Cahoc ch ON dp.Maca = ch.Maca LEFT JOIN TB_GV gv ON dp.Magv = gv.Magv WHERE dp.MaDuyet IS NULL";
            kn.DataGridViewLoad(sql, View1);
        }
        public void LoadViewToID(string ID)
        {
            string sql = "SELECT  dp.Madatphong, p.Tenphong, gv.Hoten, dp.Ngaydung,  ch.Mota, ch.Giobatdau, ch.Gioketthuc,  lp.Loaiphong, p.Vitri, dp.Mucdich FROM TB_LichsuDP dp LEFT JOIN TB_Phong p ON dp.Maphong = p.Maphong LEFT JOIN TB_LoaiP lp ON p.Maloai = lp.Maloaiphong LEFT JOIN TB_Cahoc ch ON dp.Maca = ch.Maca LEFT JOIN TB_GV gv ON dp.Magv = gv.Magv WHERE dp.MaDuyet IS NULL AND dp.Magv = '"+ID+"'";
            kn.DataGridViewLoad(sql, View1);
        }
        private void View1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == View1.Columns["btnDat"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn muốn duyệt phòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = View1.Rows[e.RowIndex];
                    string maphong = row.Cells[0].Value.ToString();
                    string sql = "INSERT INTO TB_Lichsuduyet VALUES ('" + maphong + "','" + UID + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',N'Đã phê duyệt', N'Không')";
                    string update = "UPDATE TB_LichsuDP set Maduyet = '" + maphong + "' Where Madatphong = '" + maphong + "'";
                    kn.ThucThi(sql);
                    kn.ThucThi(update);
                    MessageBox.Show("Duyệt phòng này thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadView();
                }
                else
                {
                    DataGridViewRow row = View1.Rows[e.RowIndex];
                    string maphong = row.Cells[0].Value.ToString();
                    Form_Tuchoi tc = new Form_Tuchoi(maphong, UID, this);
                    tc.Show();
                }    

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadViewToID(textBox1.Text);
        }
    }
}
