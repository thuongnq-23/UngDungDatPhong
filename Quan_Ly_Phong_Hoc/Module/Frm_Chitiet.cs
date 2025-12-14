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
    public partial class Frm_Chitiet : Form
    {
        public Frm_Chitiet(string maduyet, string maphong, string magv)
        {
            malichsu = maduyet;
            maP = maphong;
            maGV = magv;
            InitializeComponent();
        }
        public string malichsu, maP, maGV;
        Ketnoi kn = new Ketnoi();

        private void Frm_Chitiet_Load(object sender, EventArgs e)
        {
            txtGV.Text = kn.GetTT("SELECT Hoten From TB_GV WHERE magv = '" + maGV + "'");
            txtten.Text = kn.GetTT("SELECT Tenphong From TB_phong WHERE maphong = '" + maP + "'");
            txtloai.Text = kn.GetTT("SELECT Loaiphong From TB_phong, TB_LoaiP WHERE TB_LoaiP.maloaiphong = maloai AND maphong = '" + maP + "'");
            txtca.Text = kn.GetTT("SELECT mota From TB_cahoc, TB_Lichsudp WHERE TB_Cahoc.Maca = TB_LichsuDP.maca AND madatphong = '" + malichsu + "'");
            txtbatdau.Text = kn.GetTT("SELECT Giobatdau From TB_cahoc, TB_Lichsudp WHERE TB_Cahoc.Maca = TB_LichsuDP.maca AND madatphong = '" + malichsu + "'");
            txtketthuc.Text = kn.GetTT("SELECT Gioketthuc From TB_cahoc, TB_Lichsudp WHERE TB_Cahoc.Maca = TB_LichsuDP.maca AND madatphong = '" + malichsu + "'");
            txtmucdich.Text = kn.GetTT("SELECT Mucdich From TB_LichsuDP WHERE madatphong = '" + malichsu + "'");
            txtNgaydung.Text = kn.GetTT("SELECT ngaydung From TB_LichsuDP WHERE madatphong = '" + malichsu + "'");
            txttrangthai.Text = kn.GetTT("SELECT CASE  WHEN dp.MaDuyet IS NULL THEN N'Chờ duyệt' ELSE ls.Trangthai END AS Trangthai From  TB_LichsuDP dp LEFT JOIN TB_Lichsuduyet ls ON dp.MaDuyet = ls.Malichsu WHERE Madatphong = '"+malichsu+"'");
        }
        
    }
}
