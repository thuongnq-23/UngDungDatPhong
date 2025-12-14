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
    public partial class Form_Tuchoi : Form
    {
        FrmDuyetPhong frm2;
        public Form_Tuchoi(string a, string taikhoan, FrmDuyetPhong frm)
        {
            frm2 = frm;
            maduyet = a;
            UID = taikhoan;
            InitializeComponent();
        }
        public string maduyet;
        public string UID;
        private void Form_Tuchoi_Load(object sender, EventArgs e)
        {

        }
        Ketnoi kn = new Ketnoi();
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập lí do");
                return;
            }    
            string sql = "INSERT INTO TB_Lichsuduyet VALUES ('"+maduyet+"','" + UID + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',N'Từ chối', N'" + textBox1.Text + "')";
            string update = "UPDATE TB_LichsuDP set Maduyet = '" + maduyet + "' Where Madatphong = '" + maduyet + "'";
            kn.ThucThi(sql);
            kn.ThucThi(update);
            this.Hide();
            MessageBox.Show("Bạn đã từ chối duyệt phòng này", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm2.LoadView();
        }
    }
}
