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
    public partial class Quan_ly_ca_hoc : Form
    {
        public Quan_ly_ca_hoc()
        {
            InitializeComponent();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Frm_Ca_hoc ca_Hoc = new Frm_Ca_hoc(this);
            ca_Hoc.Show();

        }
        public string maca, Giobd, Giokt, mota, trangthai;

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bool flag = this.View1.Rows.Count > 0;
            if (flag)
            {
                int rowIndex = this.View1.CurrentCell.RowIndex;
                string Maca = this.View1.Rows[rowIndex].Cells[0].Value?.ToString();
                this.View1.Rows.RemoveAt(rowIndex);
                if (!string.IsNullOrEmpty(Maca))
                {
                    string Xoa = "DELETE FROM TB_Cahoc WHERE Maphong = '" + Maca + "'";
                    kn.ThucThi(Xoa);
                }
                kn.DataGridViewLoad("select * from TB_Cahoc", View1);
            }
        }

        private void View1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {

                this.maca = this.View1.Rows[rowIndex].Cells[0].Value.ToString();
                this.Giobd = this.View1.Rows[rowIndex].Cells[1].Value.ToString();
                this.Giokt = this.View1.Rows[rowIndex].Cells[2].Value.ToString();
                this.mota = this.View1.Rows[rowIndex].Cells[3].Value.ToString();
                this.trangthai = this.View1.Rows[rowIndex].Cells[4].Value.ToString();
            }
        }
        Ketnoi kn = new Ketnoi();
        private void Quan_ly_ca_hoc_Load(object sender, EventArgs e)
        {
            kn.DataGridViewLoad("select * from TB_Cahoc", View1);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Frm_Ca_hoc ca_Hoc = new Frm_Ca_hoc(maca, Giobd, Giokt, mota, trangthai, this);
            ca_Hoc.Show();
        }
    }
}
