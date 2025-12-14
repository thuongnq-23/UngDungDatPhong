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
    public partial class Thong_ke : Form
    {
        public string tenAdmin;
        public Thong_ke(string username)
        {
            InitializeComponent();
            tenAdmin = username;
        }
        FrmBaocao bc = new FrmBaocao();
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FrmBaocao bc = new FrmBaocao();
            bc.Show();

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form_BC_DS_phong bc = new Form_BC_DS_phong();
            bc.Show();
        }

        private void Thong_ke_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form_BC_SL_Phong_Hoc fl = new Form_BC_SL_Phong_Hoc();
            fl.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
                    }
    }
}
