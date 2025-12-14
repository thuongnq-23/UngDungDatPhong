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
    public partial class Frm_Thong_tin : Form
    {
        public Frm_Thong_tin(string magv)
        {
            Magv = magv;
            InitializeComponent();
        }
        public string Magv;
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
        }
        Ketnoi kn = new Ketnoi();
        public string Maphong;
        private void Frm_Dat_phong_Load(object sender, EventArgs e)
        {
            txtName.Text = kn.GetID22("SELECT Hoten FROM TB_GV WHERE Magv = '"+Magv+"'");
            txtkhoa.Text = kn.GetID22("SELECT Khoa FROM TB_GV WHERE Magv = '" + Magv + "'");
            txtEmail.Text = kn.GetID22("SELECT Email FROM TB_GV WHERE Magv = '" + Magv + "'");
            txtSDT.Text = kn.GetID22("SELECT Sodt FROM TB_GV WHERE Magv = '" + Magv + "'");
            txtUsser.Text = kn.GetID22("SELECT Taikhoan FROM TB_GV WHERE Magv = '" + Magv + "'");
            txtPass.Text = kn.GetID22("SELECT matkhau FROM TB_GV WHERE Magv = '" + Magv + "'");

        }

        private void txtLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtVitri_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public string maca;
        private void txtCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            kn.ThucThi("UPDATE TB_GV set (Hoten = '" + txtName.Text + "', Sodt = '" + txtSDT.Text + "', Khoa = '" + txtkhoa.Text + "', Email = '" + txtEmail.Text + "', Matkhau = '" + txtPass.Text + "') WHERE Taikhoan = '" + txtUsser.Text + "'");
            MessageBox.Show("Cập nhật thông tin thành công");
        }
    }
}
