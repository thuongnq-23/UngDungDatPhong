using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Phong_Hoc.Mdl_GV
{
    public partial class DS_Phong : Form
    {
        public DS_Phong(string UID)
        {

            InitializeComponent();
            maGV = UID;
        }
        public string maGV;
        Ketnoi kn = new Ketnoi();
        private string maca;
        
        private void DS_Phong_Load(object sender, EventArgs e)
        {
            kn.DataGridViewLoad("select maphong, Tenphong, TB_loaiP.Loaiphong, Succhua, Vitri, Mota, TB_Phong.Trangthai from TB_Phong, TB_loaiP Where TB_loaiP.Maloaiphong = TB_Phong.Maloai", View1);
            kn.ComboboxLoad("SELECT DISTINCT LoaiPhong FROM TB_loaiP", txtLoai);
            kn.ComboboxLoad("SELECT DISTINCT (MoTa + ' - ' + GioBatDau + N' đến ' + GioKetThuc) AS ThongTinCa FROM TB_Cahoc", txtCa);
            kn.ComboboxLoad("SELECT DISTINCT Vitri FROM TB_Phong", txtVitri);
            kn.ComboboxLoad("SELECT DISTINCT Mota FROM TB_Phong", txtMota);
        }
        private void txtLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("SELECT TB_Phong.maphong, Tenphong, TB_loaiP.Loaiphong, Succhua, Vitri, Mota, Trangthai FROM TB_Phong, TB_loaiP WHERE 1=1");
            if (!string.IsNullOrWhiteSpace(txtLoai.Text))
            {
                query.Append(" AND TB_loaiP.Maloaiphong = TB_phong.Maloai AND TB_loaiP.Loaiphong LIKE N'%" + txtLoai.Text + "%'");
            }
            else
            {
                MessageBox.Show("Trước tiên hãy chọn loại phòng");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtSucchua.Text))
            {
                query.Append(" AND Succhua >= " + txtSucchua.Text );
            }
            if (!string.IsNullOrWhiteSpace(txtVitri.Text))
            { 
                query.Append(" AND Vitri = N'" + txtVitri.Text + "'");
            }
            if (!string.IsNullOrWhiteSpace(txtMota.Text))
            {
                query.Append(" AND Mota LIKE N'%" + txtMota.Text + "%'");
            }
            if (!string.IsNullOrWhiteSpace(txtNgaydung.Text) && !string.IsNullOrWhiteSpace(txtCa.Text))
            {
                query.Append(" AND Maphong NOT IN (SELECT MaPhong FROM TB_LichsuDP WHERE Ngaydung = '" + txtNgaydung.Text + "' AND Maca = '"+ maca + "')");
            }
            kn.DataGridViewLoad(query.ToString(), View1);
        }

        private void txtCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] parts = txtCa.Text.Split('-');
            string tenCa = parts[0].Trim();
            string[] giohoc = parts[1].Split(' ');
            string gioBatDau = giohoc[1].Trim();
            string gioKetThuc = giohoc[3].Trim();
            maca = kn.GetMaca(tenCa, gioBatDau, gioKetThuc);
           
        }

        private void View1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == View1.Columns["btnDat"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đặt phòng này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (string.IsNullOrWhiteSpace(txtCa.Text))
                {
                    MessageBox.Show("Vui lòng chọn ca học");
                    return;
                }
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = View1.Rows[e.RowIndex];
                    string maphong = row.Cells[0].Value.ToString();
                    if (kn.KiemTraTrungLich(maphong, txtNgaydung.Text, maca))
                    {
                        MessageBox.Show("Phòng này đã có người đặt trước, vui lòng chọn phòng khác");
                        return;
                    }
                    Form_Mucdich md = new Form_Mucdich(maca, maGV, maphong, txtNgaydung.Text);
                    md.Show();
                }

            }
        }
    }
}
