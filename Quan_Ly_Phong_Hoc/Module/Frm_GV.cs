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
    public partial class Frm_GV : Form
    {
        public Quan_ly_nguoi_dung frmnd;
        public Frm_GV(Quan_ly_nguoi_dung frm)
        {
            InitializeComponent();
            btnSua.Hide();
            frmnd = frm;
        }
        public Frm_GV(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, Quan_ly_nguoi_dung frm)
        {
            InitializeComponent();
            btnThem.Hide();
            txtma.Text = a;
            txtten.Text = b;
            txtgt.Text = c;
            txtsdt.Text = d;
            txtemail.Text = e;
            txttaikhoan.Text = g;
            txtmk.Text = h;
            txtquyen.Text = i;
            txttrangthai.Text = j;
            frmnd = frm;

        }
        Ketnoi kn = new Ketnoi();

        private void Frm_GV_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kn.KiemTraMaTrung("select * from TB_GV where Magv='" + txtma.Text + "'") == 1)
                MessageBox.Show("Ma da ton tai");
            else if (kn.KiemTraMaTrung("select *from TB_GV where Magv='" + txtma.Text + "'") == 0)
            {
                string trangthai = txttrangthai.Text == "Hoạt động" ? "0" : "1";
                kn.ThucThi("Insert into TB_GV values('" + txtma.Text + "',N'" + txtten.Text + "',N'" + txtgt.Text + "',N'" + txtsdt.Text + "',N'" + txtemail.Text + "',N'" + txttaikhoan.Text + "',N'" + txtmk.Text + "',N'" + txtquyen.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',N'" + trangthai + "')");
                kn.DataGridViewLoad_GV("select * from TB_GV", frmnd.View1);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string trangthai = txttrangthai.Text == "Hoạt động" ? "0" : "1";
            string Sua = "Update TB_GV set Hoten=N'" + txtten.Text + "',Gioitinh=N'" + txtgt.Text + "',Sodt=N'" + txtsdt.Text + "',Email=N'" + txtemail.Text + "',Taikhoan=N'" + txttaikhoan.Text + "',Matkhau=N'" + txtmk.Text + "',Quyen=N'" + txtquyen.Text + "',Ngaytao='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Trangthai=N'" + trangthai + "' where Magv='" + txtma.Text + "'";
            kn.ThucThi(Sua);
            kn.DataGridViewLoad_GV("select * from TB_GV", frmnd.View1);
        }
    }
}
