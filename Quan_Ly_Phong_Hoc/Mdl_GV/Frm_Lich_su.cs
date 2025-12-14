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
    public partial class Frm_Lich_su : Form
    {
        public Frm_Lich_su(string UID)
        {
            maGV = UID;
            InitializeComponent();
        }
        public  string maGV;
        Ketnoi kn = new Ketnoi();
        private void Frm_Lich_su_Load(object sender, EventArgs e)
        {
            string sql = @"
            SELECT DISTINCT 
                dp.Ngaydat, 
                dp.Ngaydung, 
                ch.Mota AS MotaCa, 
                ch.Giobatdau, 
                ch.Gioketthuc, 
                lp.Loaiphong, 
                p.Vitri, 
                p.Tenphong,
                CASE 
                    WHEN dp.MaDuyet IS NULL THEN N'Chờ duyệt'
                    ELSE ls.Trangthai
                END AS Trangthai,
                CASE 
                    WHEN dp.MaDuyet IS NULL THEN N'NULL'
                    ELSE ls.Ghichu
                END AS Ghichu
            FROM 
                TB_LichsuDP dp
            LEFT JOIN TB_Phong p ON dp.MaPhong = p.MaPhong
            LEFT JOIN TB_LoaiP lp ON p.Maloai = lp.Maloaiphong
            LEFT JOIN TB_Cahoc ch ON dp.Maca = ch.Maca
            LEFT JOIN TB_GV gv ON dp.Magv = gv.Magv
            LEFT JOIN TB_Lichsuduyet ls ON dp.MaDuyet = ls.Malichsu
            WHERE 
                dp.Magv = '" + maGV+"'";

            kn.DataGridViewLoad(sql, View1);
        }
    }
}
