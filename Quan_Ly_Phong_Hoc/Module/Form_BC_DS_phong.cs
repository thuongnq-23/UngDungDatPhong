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
    public partial class Form_BC_DS_phong : Form
    {
        public Form_BC_DS_phong()
        {
            InitializeComponent();
        }

        private void Form_BC_DS_phong_Load(object sender, EventArgs e)
        {
            kn.ComboboxLoad2("Select DISTINCT Khoa From TB_GV", txtkhoa);
            this.reportViewer1.RefreshReport();
        }
        Ketnoi kn = new Ketnoi();
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            string tuNgayStr = tuNgay.ToString("yyyy-MM-dd HH:mm:ss");
            string denNgayStr = denNgay.ToString("yyyy-MM-dd HH:mm:ss");

            this.reportViewer1.RefreshReport();

            string query = @"
            SELECT TB_LichsuDP.Madatphong, TB_GV.Hoten, TB_Phong.Tenphong, TB_loaiP.Loaiphong, TB_LichsuDP.Ngaydung, TB_Cahoc.Mota, TB_Cahoc.Giobatdau, TB_Cahoc.Gioketthuc, TB_LichsuDP.Mucdich
            FROM TB_LichsuDP INNER JOIN
                         TB_GV ON TB_LichsuDP.Magv = TB_GV.Magv INNER JOIN
                         TB_Phong ON TB_LichsuDP.MaPhong = TB_Phong.Maphong INNER JOIN
                         TB_Cahoc ON TB_LichsuDP.Maca = TB_Cahoc.Maca INNER JOIN
                         TB_loaiP ON TB_Phong.Maloai = TB_loaiP.Maloaiphong
            WHERE 
                ISDATE(TB_LichsuDP.NgayDat) = 1
                AND CONVERT(datetime, TB_LichsuDP.NgayDat, 120) BETWEEN '" + tuNgayStr + "' AND '" + denNgayStr + "' AND TB_GV.Khoa = N'" + txtkhoa.Text + @"'";
            ReportParameter[] reportParams = new ReportParameter[]
            {
                new ReportParameter("tungay", tuNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("denngay", denNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("HotenNguoilap", "Thượng")
            };
            reportViewer1.LocalReport.ReportPath = "Baocao/DS_Phong_da_dat.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", kn.
                LoadDataTable(query)
            ));
            reportViewer1.LocalReport.SetParameters(reportParams);
            reportViewer1.RefreshReport();
        }
    }
}
