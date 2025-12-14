using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Phong_Hoc.Module;
namespace Quan_Ly_Phong_Hoc
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private void FrmDangNhap_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPasss_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtPasss.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if(checkBox1.Checked == true)
            {
                txtPasss.UseSystemPasswordChar = false; 
            }    
            else
            {
                txtPasss.UseSystemPasswordChar = true;
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Ketnoi kn = new Ketnoi();
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPasss.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }    
            string quyen =  kn.DangNhap(txtUser.Text, txtPasss.Text);
            if(quyen == "" && string.IsNullOrEmpty(quyen))
            {
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!!!");
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM TB_GV WHERE Taikhoan = @Taikhoan AND Trangthai != '1'";
            var checkParams = new Dictionary<string, object> { { "@Taikhoan", txtUser.Text }};
            int existing = kn.KiemtraTonTai(checkQuery, checkParams);
            if (existing ==  0)
            {
                MessageBox.Show("Tài khoản của bạn đang chờ ADMIN duyệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(quyen == "Admin")
            {
                HomeAdmin fm = new HomeAdmin(txtUser.Text);
                fm.Show();
                this.Hide();
            }
            else  if(quyen == "Giáo viên")
            {
                HomeGV fm = new HomeGV(txtUser.Text);
                fm.Show();
                this.Hide();
            }    
        }

        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangKy frm = new FrmDangKy();
            frm.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Quenmatkhau qm = new Frm_Quenmatkhau();
            qm.Show();
        }
    }
}
