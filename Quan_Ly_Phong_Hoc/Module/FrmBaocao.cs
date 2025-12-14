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
    public partial class FrmBaocao : Form
    {
        public FrmBaocao()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void FrmBaocao_Load(object sender, EventArgs e)
        {
            kn.ComboboxLoad2("Select DISTINCT Khoa From TB_GV", txtkhoa);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            string tuNgayStr = tuNgay.ToString("yyyy-MM-dd HH:mm:ss");
            string denNgayStr = denNgay.ToString("yyyy-MM-dd HH:mm:ss");

            this.reportViewer1.RefreshReport();

            string query = @"
            SELECT 
                gv.Hoten,
                gv.Khoa,
                COUNT(dp.Madatphong) AS SoluotDat,
                SUM(CASE 
                    WHEN ld.Trangthai = N'Đã phê duyệt' THEN 1 
                    ELSE 0 
                END) AS SoluotDuocDuyet
            FROM 
                TB_LichsuDP dp
            JOIN 
                TB_GV gv ON dp.Magv = gv.Magv
            LEFT JOIN 
                TB_Lichsuduyet ld ON dp.MaDuyet = ld.Malichsu
            WHERE 
                ISDATE(dp.NgayDat) = 1
                AND CONVERT(datetime, dp.NgayDat, 120) BETWEEN '" + tuNgayStr + "' AND '" + denNgayStr + "' AND gv.Khoa = N'"+txtkhoa.Text+ @"'
            GROUP BY gv.Hoten, gv.Khoa 
            ORDER BY SoluotDat DESC";
            ReportParameter[] reportParams = new ReportParameter[]
            {
                new ReportParameter("tungay", tuNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("denngay", denNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("HotenNguoilap", "Thượng")
            };
            reportViewer1.LocalReport.ReportPath = "Baocao/Report_DSDatphong.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", kn.LoadDataTable(query)
            ));
            reportViewer1.LocalReport.SetParameters(reportParams);
            reportViewer1.RefreshReport();
        }

        
    }
}
