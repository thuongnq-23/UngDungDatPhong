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
    public partial class Frm_Ca_hoc : Form
    {
        public Quan_ly_ca_hoc frmca;
        public Frm_Ca_hoc(Quan_ly_ca_hoc ql)
        {
            InitializeComponent();
            btnSua.Hide();
            frmca = ql;
        }
        public Frm_Ca_hoc(string a, string b, string c, string d, string e, Quan_ly_ca_hoc ql)
        {

            InitializeComponent();
            btnThem.Hide();
            txtmaca.Text = a;
            txtgiobd.Text = b;
            txtgiokt.Text = c;
            txtmota.Text = d;
            txttrangthai.Text = e;
            frmca = ql;
        }
        private void Frm_Ca_hoc_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        Ketnoi kn = new Ketnoi();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kn.KiemTraMaTrung("select *from TB_Cahoc where Maca='" + txtmaca.Text + "'") == 1)
                MessageBox.Show("Ma da ton tai");
            else if (kn.KiemTraMaTrung("select *from TB_Cahoc where Maca='" + txtmaca.Text + "'") == 0)
            {
                kn.ThucThi("Insert into TB_Cahoc values('" + txtmaca.Text + "',N'" + txtgiobd.Text + "',N'" + txtgiokt.Text + "',N'" + txtmota.Text + "',N'" + txttrangthai.Text + "')");
                kn.DataGridViewLoad("select * from TB_Cahoc", frmca.View1);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sua = "Update TB_Cahoc set Giobatdau=N'" + txtgiobd.Text + "',Gioketthuc=N'" + txtgiokt.Text + "',Mota=N'" + txtmota.Text + "',Trangthai=N'" + txttrangthai.Text + "' where Maca='" + txtmaca.Text + "'";
            kn.ThucThi(Sua);
            kn.DataGridViewLoad("select * from TB_Cahoc", frmca.View1);
        }
    }
}
