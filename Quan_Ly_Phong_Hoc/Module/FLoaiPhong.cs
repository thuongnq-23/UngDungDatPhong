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
    public partial class FLoaiPhong : Form
    {
        public Ql_Loai_phong frmnd;
        private string MaloaiP;

        public FLoaiPhong(Ql_Loai_phong frm)
        {
            InitializeComponent();
            frmnd = frm;
            btnSua.Hide();
        }
        Ketnoi kn = new Ketnoi();
        public FLoaiPhong(string ma, string ten, Ql_Loai_phong frm)
        {
            InitializeComponent();
            txtloai.Text = ten;
            MaloaiP = ma;
            frmnd = frm;
            btnThem.Hide();
        }
        private void FLoaiPhong_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sua = "Update TB_loaiP set loaiphong=N'" + txtloai.Text + "' where maloaiphong='" + MaloaiP + "'";
            kn.ThucThi(Sua);
            kn.DataGridViewLoad("select * from TB_loaiP", frmnd.View1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kn.ThucThi("Insert into TB_LoaiP (Loaiphong) values(N'" + txtloai.Text + "'");
            kn.DataGridViewLoad_GV("select * from TB_GV", frmnd.View1);
        }
    }
}
