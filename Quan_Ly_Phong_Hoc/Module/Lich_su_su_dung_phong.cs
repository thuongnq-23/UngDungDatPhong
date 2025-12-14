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
    public partial class Lich_su_su_dung_phong : Form
    {
        public Lich_su_su_dung_phong()
        {
            InitializeComponent();
        }

        private void Lich_su_su_dung_phong_Load(object sender, EventArgs e)
        {
            LoadView();

        }
        Ketnoi kn = new Ketnoi();
        public void LoadView()
        {
            string SQL = @"
                SELECT 
                    dp.Madatphong, 
                    gv.Magv, 
                    p.Maphong, 
                    gv.Hoten, 
                    p.Tenphong, 
                    dp.Ngaydat, 
                    CASE  
                        WHEN dp.MaDuyet IS NULL THEN N'Chờ duyệt'  
                        ELSE ls.Trangthai  
                    END AS Trangthai
                FROM 
                    TB_LichsuDP dp
                JOIN TB_Phong p ON dp.Maphong = p.Maphong
                JOIN TB_GV gv ON dp.Magv = gv.Magv
                LEFT JOIN TB_Lichsuduyet ls ON dp.MaDuyet = ls.Malichsu";
            kn.DataGridViewLoad(SQL, View1);
        }

        private void View1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == View1.Columns["btnDat"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = View1.Rows[e.RowIndex];
                string maduyet = row.Cells[0].Value.ToString();
                string maphong = row.Cells[2].Value.ToString();
                string magv = row.Cells[1].Value.ToString();
                Frm_Chitiet chitiet = new Frm_Chitiet(maduyet, maphong, magv);
                chitiet.Show();
            }
        }
    }
}
