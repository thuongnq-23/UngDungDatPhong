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
    public partial class Quan_ly_nguoi_dung : Form
    {
        public Quan_ly_nguoi_dung()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Frm_GV gv = new Frm_GV(this);
            gv.Show();
        }
        public string MaGV, Tengv, gioitinh, Email, bomon, taikhoan, matkhau, quyen, trangthai, sodt;

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bool flag = this.View1.Rows.Count > 0;
            if (flag)
            {
                int rowIndex = this.View1.CurrentCell.RowIndex;
                string Maphong = this.View1.Rows[rowIndex].Cells[0].Value?.ToString();
                this.View1.Rows.RemoveAt(rowIndex);
                if (!string.IsNullOrEmpty(Maphong))
                {
                    string Xoa = "DELETE FROM TB_Phong WHERE Maphong = '" + Maphong + "'";
                    kn.ThucThi(Xoa);
                }
                kn.DataGridViewLoad_GV("select * from TB_GV", View1);
            }
        }

        Ketnoi kn = new Ketnoi();
        private void Quan_ly_nguoi_dung_Load(object sender, EventArgs e)
        {
            kn.DataGridViewLoad_GV("select * from TB_GV", View1);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Frm_GV gv = new Frm_GV(MaGV, Tengv, gioitinh, sodt, Email, bomon, taikhoan, matkhau, quyen, trangthai, this);
            gv.Show();
        }

        private void View1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {

                this.MaGV = this.View1.Rows[rowIndex].Cells[0].Value.ToString();
                this.Tengv = this.View1.Rows[rowIndex].Cells[1].Value.ToString();
                this.gioitinh = this.View1.Rows[rowIndex].Cells[2].Value.ToString();
                this.sodt = this.View1.Rows[rowIndex].Cells[3].Value.ToString();
                this.Email = this.View1.Rows[rowIndex].Cells[5].Value.ToString();
                this.taikhoan = this.View1.Rows[rowIndex].Cells[6].Value.ToString();
                this.matkhau = this.View1.Rows[rowIndex].Cells[7].Value.ToString();
                this.quyen = this.View1.Rows[rowIndex].Cells[8].Value.ToString();
            }
        }
    }
}
