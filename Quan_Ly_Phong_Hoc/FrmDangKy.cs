using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Quan_Ly_Phong_Hoc.Mdl_GV;

namespace Quan_Ly_Phong_Hoc
{
    public partial class FrmDangKy : Form
    {

        public FrmDangKy()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            txtNam.Checked = false;
            txtNu.Checked = false;
        }

        private void txtNam_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(txtNam.Checked == true)
            {
                txtNu.Checked = false;
            }    

        }

        private void txtNu_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (txtNu.Checked == true)
            {
                txtNam.Checked = false;
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsser.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtPass.Text) || (!txtNam.Checked && !txtNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            string taiKhoan = txtUsser.Text.Trim();
            bool hopLeCoBan = Regex.IsMatch(taiKhoan, @"^[a-zA-Z0-9]{6,40}$");
            bool khongPhaiToanSo = !Regex.IsMatch(taiKhoan, @"^\d+$");
            if (!hopLeCoBan || !khongPhaiToanSo)
            {
                MessageBox.Show("Tài khoản chỉ được chứa chữ thường (a-z) và số (0-9)!");
                return;
            }
            string email = txtEmail.Text;
            if (!email.Contains("@"))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email");
                return;
            }
            string matKhau = txtPass.Text.Trim();
            bool hopLe = Regex.IsMatch(matKhau, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");
            if(!hopLe)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự và bao gồm cả chữ và số!");
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM TB_GV WHERE Taikhoan = @Taikhoan";
            var checkParams = new Dictionary<string, object> { { "@Taikhoan", taiKhoan } };

            int existing = kn.KiemtraTonTai(checkQuery, checkParams);

            if (existing > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại!, vui lòng dùng tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gioitinh = txtNam.Checked == true ? "Nam" : "Nữ";
            string query = @"INSERT INTO TB_GV
                (Hoten, Gioitinh, Sodt, Email, Taikhoan, Matkhau, Quyen, Ngaytao, Trangthai)
                VALUES (@Hoten, @Gioitinh, @Sodt, @Email, @Taikhoan, @Matkhau, @Quyen, @Ngaytao, @Trangthai)";

            var parameters = new Dictionary<string, object>
            {
                { "@Hoten", txtName.Text },
                { "@Gioitinh", gioitinh },
                { "@Sodt", txtSDT.Text },
                { "@Email", txtEmail.Text },
                { "@Taikhoan", taiKhoan },
                { "@Matkhau", matKhau },
                { "@Quyen", "Giáo viên" },
                { "@Ngaytao", DateTime.Now },
                { "@Trangthai", "Chờ duyệt" }
            };
            kn.ThucThi_dung(query, parameters);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmDangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();
            this.Hide();
        }
    }
}
