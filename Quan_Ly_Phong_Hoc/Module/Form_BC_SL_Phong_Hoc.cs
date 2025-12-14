using Microsoft.Reporting.WinForms;
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
    public partial class Form_BC_SL_Phong_Hoc : Form
    {
        public Form_BC_SL_Phong_Hoc()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void Form_BC_SL_Phong_Hoc_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            string query = @"
            SELECT        TB_Phong.Maphong, TB_Phong.Tenphong, TB_Phong.Vitri, TB_loaiP.Loaiphong, TB_Phong.Succhua, TB_Phong.Trangthai
             FROM            TB_loaiP INNER JOIN
                         TB_Phong ON TB_loaiP.Maloaiphong = TB_Phong.Maloai";
            ReportParameter[] reportParams = new ReportParameter[]
            {
                new ReportParameter("HotenNguoilap", "Thượng")
            };
            reportViewer1.LocalReport.ReportPath = "Baocao/DS_Phong.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", kn.LoadDataTable(query)
            ));
            reportViewer1.LocalReport.SetParameters(reportParams);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
