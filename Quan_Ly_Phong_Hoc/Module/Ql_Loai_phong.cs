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
    public partial class Ql_Loai_phong : Form
    {
        public Ql_Loai_phong()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private string MaP;
        private string TenP;

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
                    string Xoa = "DELETE FROM TB_LoaiP WHERE Maloaiphong = '" + Maphong + "'";
                    kn.ThucThi(Xoa);
                }
                kn.DataGridViewLoad_GV("select * from TB_LoaiP", View1);
            }
        }

        private void View1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {

                this.MaP = this.View1.Rows[rowIndex].Cells[0].Value.ToString();
                this.TenP = this.View1.Rows[rowIndex].Cells[1].Value.ToString();
                
            }
        }
        
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FLoaiPhong f = new FLoaiPhong(this);
            f.Show();
        }
        public string ma, ten;

        private void View1_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void Ql_Loai_phong_Load(object sender, EventArgs e)
        {
            kn.DataGridViewLoad("SELECT * FROM TB_loaiP", View1);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            FLoaiPhong f = new FLoaiPhong(MaP, TenP, this);
            f.Show();
        }
    }
}
