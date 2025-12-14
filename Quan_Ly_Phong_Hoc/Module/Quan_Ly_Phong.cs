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
    public partial class Quan_Ly_Phong : Form
    {
        public Quan_Ly_Phong()
        {
            InitializeComponent();
        }
        Ketnoi ketnoi = new Ketnoi();
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Frm_phonghoc frm = new Frm_phonghoc(this);
            frm.Show();
        }
        
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Frm_phonghoc frm = new Frm_phonghoc(maphong, tenphong, loaiphong, succhua, vitri, mota, trangthai);
            frm.Show();
        }
        public string maphong, tenphong, loaiphong, succhua, vitri,  mota, trangthai;
        
        private void Quan_Ly_Phong_Load(object sender, EventArgs e)
        {
            ketnoi.DataGridViewLoad("select * from TB_Phong", View1);
        }

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
                    ketnoi.ThucThi(Xoa);
                }
                ketnoi.DataGridViewLoad("select * from TB_Phong", View1);
            }

        }

        private void View1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {

                this.maphong = this.View1.Rows[rowIndex].Cells[0].Value.ToString();
                this.tenphong = this.View1.Rows[rowIndex].Cells[1].Value.ToString();
                this.loaiphong = this.View1.Rows[rowIndex].Cells[2].Value.ToString();
                this.succhua = this.View1.Rows[rowIndex].Cells[3].Value.ToString();
                this.vitri = this.View1.Rows[rowIndex].Cells[4].Value.ToString();
                this.mota = this.View1.Rows[rowIndex].Cells[5].Value.ToString();
                this.trangthai = this.View1.Rows[rowIndex].Cells[7].Value.ToString();
            }
        }
    }
}
