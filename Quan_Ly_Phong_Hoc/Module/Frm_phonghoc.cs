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
    public partial class Frm_phonghoc : Form
    {
        private Quan_Ly_Phong formChinh;
        public Frm_phonghoc(Quan_Ly_Phong cha)
        {
            InitializeComponent();
            btnSua.Hide();
            formChinh = cha;
        }
        Ketnoi kn = new Ketnoi();
        public Frm_phonghoc(string a, string b, string c, string d, string e, string f, string g)
        {
            InitializeComponent();
            btnThem.Hide();
            maphong.Text = a;
            tenphong.Text = b;
            txtloai.Text = kn.GetID("SELECT Loaiphong From TB_LoaiP WHERE Maloaiphong = '" + c + "'");
            succhua.Text = d;
            vitri.Text = e;
            mota.Text = f;
            trangthai.Text = g;
               
        }

        private void Frm_phonghoc_Load(object sender, EventArgs e)
        {
            kn.ComboboxLoad("select loaiphong, Maloaiphong from TB_loaiP", txtloai);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kn.KiemTraMaTrung("select *from TB_Phong where Maphong='" + maphong.Text + "'") == 1)
                MessageBox.Show("Ma da ton tai");
            else if (kn.KiemTraMaTrung("select *from TB_Phong where Maphong='" + maphong.Text + "'") == 0)
            {
                kn.ThucThi("Insert into TB_Phong values('" + maphong.Text + "',N'" + tenphong.Text + "',N'" + txtloai.Text + "',N'" + succhua.Text + "',N'" + vitri.Text + "',N'" + mota.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+ "',N'" + trangthai.Text + "')");
                kn.DataGridViewLoad("select * from TB_Phong", formChinh.View1);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sua = "Update TB_Phong set Tenphong=N'" + tenphong.Text + "',Loaiphong=N'" + txtloai.Text + "',Succhua=N'" + succhua.Text + "',Vitri=N'" + vitri.Text + "',Mota=N'" + mota.Text + "',Ngaythem='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Trangthai=N'" + trangthai.Text + "' where Maphong='" + maphong.Text + "'";
            kn.ThucThi(Sua);
            kn.DataGridViewLoad("select * from TB_Phong", formChinh.View1);
        }
    }
}
