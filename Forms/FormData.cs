using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;


namespace Learn_0801_24.Forms
{
    public partial class FormData : Form
    {
        DataTable dt = new DataTable(); //
        
        DateTime date = DateTime.Now;
        
        public Plc _plc;
        Timer Timer_data = new Timer();
        int Time_data_Update = 1;
        bool old = false;
        public FormData()
        {
            Timer_data.Start();
            Timer_data.Interval = 1;
            Timer_data.Tick += Timer_data_Tick;
            InitializeComponent();
        }

        private void FormData_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Torque1", typeof(string));
            dt.Columns.Add("Torque2", typeof(string));
            dt.Columns.Add("Torque3", typeof(string));
            dt.Columns.Add("SKU", typeof(string));
            dt.Rows.Clear();
           // dt.Rows.Add(dt.Rows.Count + 1, 3, 5, 7, "a");
            dtgvreport.DataSource = dt;

        }
        private void LoadTheme()
        {
           
        }

        #region đọc tráng thái lên c#
        // đọc trạng thái lên plc
        private void Timer_data_Tick(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                //ghi thoi gian xuong plc
                int plc_year = date.Year;
                int plc_month = date.Month;
                int plc_day = date.Day;
                int plc_hour = date.Hour;
                int plc_minute = date.Minute;
                int plc_second = date.Second;
                //thanh ghi luu trữ thời gian
                _plc.Write("DB25.DBW0.0", plc_year);
                _plc.Write("DB25.DBB2.0", plc_month);
                _plc.Write("DB25.DBB3.0", plc_day);
                _plc.Write("DB25.DBB5.0", plc_hour);
                _plc.Write("DB25.DBB6.0", plc_minute);
                _plc.Write("DB25.DBB7.0", plc_second);
                // ghi thời gian xuống plc
                bool DB4_DBX164_0 = (bool)_plc.Read("DB4.DBX164.0");// read bit single
                var Value_torque1 = Math.Round(((uint)_plc.Read("DB4.DBD166.0")).ConvertToDouble(), 3);
                var Value_torque2 = Math.Round(((uint)_plc.Read("DB4.DBD174.0")).ConvertToDouble(), 3);
                var Value_torque3 = Math.Round(((uint)_plc.Read("DB4.DBD182.0")).ConvertToDouble(), 3);

                if (DB4_DBX164_0 && !old) 
                {
                    //dt.Rows.Add(dt.Rows.Count, Value_torque1.ToString(), Value_torque2.ToString(), Value_torque3.ToString(), "a");
                    dt.Rows.Add(dt.Rows.Count + 1, Value_torque1.ToString(), Value_torque2.ToString(), Value_torque3.ToString(), "");
                }
                UpdateDataGridView();
               // dtgvreport.DataSource = dt;
                old = DB4_DBX164_0;


            }

        }
        private void UpdateDataGridView()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    dtgvreport.DataSource = dt;
                });
            }
            else
            {
                dtgvreport.DataSource = dt;
            }
        }

        #endregion
        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            // Khởi tạo ứng dụng Excel
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Lưu dữ liệu từ DataGridView vào tệp Excel
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 1, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs(filePath);
            if (!File.Exists(filePath))
            {
                // Thư mục không tồn tại, tạo thư mục mới
            }
            else
            {
                workbook.SaveAs(filePath);
            }
            // Lưu tệp Excel

            // Đóng workbook và ứng dụng Excel
            workbook.Close();
            excelApp.Quit();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            string day = date.Day.ToString();
            string month = date.Month.ToString();
            string year = date.Year.ToString();
            string folderPath = @"F:\\Lien_Minh_Group\\SC_JohnSon\\Report_Torque\\" + month + "_" + year; // Đường dẫn của thư mục cần kiểm tra/tạo mới

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                // Thư mục không tồn tại, tạo thư mục mới
            }
            else
            {
                // Thư mục đã tồn tại
            }
            //excel
            string filePath = @"F:\\Lien_Minh_Group\\SC_JohnSon\\Report_Torque\\" + month + "_" + year + @"\\" + "tmp" + ".xlsx"; // Đường dẫn và tên tệp Excel muốn lưu
            ExportToExcel(dtgvreport, filePath);
        }
    }
}
