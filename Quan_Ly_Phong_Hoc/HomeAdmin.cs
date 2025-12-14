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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin(string username)
        {
            UID = kn.GetUID(username);
            InitializeComponent();
            txtName.Text = username;
            
        }
        Ketnoi kn = new Ketnoi();
        public string UID;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSophong.Text = kn.GetID("SELECT COUNT(*) From TB_Phong");
            txtThanhvien.Text = kn.GetID("SELECT COUNT(*) From TB_GV");
            txtSophongdadat.Text = kn.GetID("SELECT COUNT(*) From TB_LichsuDP ");
            txtSophongtrong.Text = kn.GetID("SELECT COUNT(*) From TB_LichsuDP WHERE Maduyet is NULL");
            txtSophongbaotri.Text = kn.GetID("SELECT COUNT(*) From TB_Phong WHERE Trangthai = N'Bảo trì'");
        }
        private void LoadFormVaoPanel(Form formCon)
        {
            panelMain.Controls.Clear(); 
            formCon.TopLevel = false; 
            formCon.FormBorderStyle = FormBorderStyle.None; 
            formCon.Dock = DockStyle.Fill; 
            panelMain.Controls.Add(formCon); 
            formCon.Show(); 
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Quan_Ly_Phong());
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Quan_ly_nguoi_dung());
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Quan_ly_ca_hoc());
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Ql_Loai_phong());
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Dashboard());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton7_Click_1(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Thong_ke(txtName.Text));
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();
        }

        private void bunifuButton6_Click_1(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Lich_su_su_dung_phong());
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new FrmDuyetPhong(UID));
        }
    }
}
