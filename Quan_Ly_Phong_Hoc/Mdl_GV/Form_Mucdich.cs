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
    public partial class Form_Mucdich : Form
    {
        public Form_Mucdich(string maca1,string magv1,string maphong1,string ngaydung1)
        {
            InitializeComponent();
            maca = maca1;
            magv = magv1;
            maphong = maphong1;
            ngaydung = ngaydung1;
        }
        public string maca, magv, maphong, ngaydung;
        Ketnoi kn = new Ketnoi();
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (kn.KiemTraTrungLich(maphong, ngaydung, maca))
            {
                MessageBox.Show("Phòng này đã có người đặt trước, vui lòng chọn phòng khác");
                return;
            }
            string sql = "INSERT INTO TB_Lichsudp (magv, maphong, Ngaydat, Maca, Ngaydung, Mucdich) VALUES ('"+magv+"', '"+maphong+"','"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '"+maca+"', '"+ngaydung+"', N'"+txtmucdich.Text+"')";
            kn.ThucThi(sql);
            this.Close();
            MessageBox.Show("đặt phòng thành công, vui lòng chờ admin duyệt");
            
        }

        private void Form_Mucdich_Load(object sender, EventArgs e)
        {

        }
    }
}
