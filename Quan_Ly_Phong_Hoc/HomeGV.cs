using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Phong_Hoc.Mdl_GV;
namespace Quan_Ly_Phong_Hoc
{
    public partial class HomeGV : Form
    {
        public string usernameGV;
        public HomeGV(string username)
        {
            usernameGV = username;
            InitializeComponent();
            txtName.Text = username;
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
        private void FrmGV_Load(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new DS_Phong(kn.GetID(usernameGV)));
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new DS_Phong(kn.GetID(usernameGV)));
        }
        Ketnoi kn = new Ketnoi();
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Frm_Thong_tin(kn.GetID(usernameGV)));
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Frm_Lich_su(kn.GetID(usernameGV)));
        }

        private void FrmGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            LoadFormVaoPanel(new Frm_Thong_tin(kn.GetID(usernameGV)));
        }
    }
}
