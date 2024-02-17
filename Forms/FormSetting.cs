using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_0801_24.Forms
{
    public partial class FormSetting : Form
    {
        public Plc _plc;
        Timer Timer_Setting = new Timer();
        int Time_Setting_Update = 100;
        public FormSetting()
        {
            InitializeComponent();
            Timer_Setting.Start();  
            Timer_Setting.Interval = Time_Setting_Update;
            
            Timer_Setting.Tick += Timer_Setting_Tick;
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadTheme();
            Timer_Setting.Start();  
            Timer_Setting.Interval = Time_Setting_Update;
            
            Timer_Setting.Tick += Timer_Setting_Tick;
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                
            }
        }
        #region đọc tráng thái lên c#
        // đọc trạng thái lên plc
        private void Timer_Setting_Tick(object sender, EventArgs e)
        {
            if(_plc.IsConnected)
            {
                var Set_Speed_Torque = Math.Round(((uint)_plc.Read("DB4.DBD32.0")).ConvertToDouble(), 3);
                tbSpeed_Torque.Text = Convert.ToString(Set_Speed_Torque).ToString(); ///bo
                //torque
                var Set_Torque = Math.Round(((uint)_plc.Read("DB4.DBD44.0")).ConvertToDouble(), 3);
               tbSetTorque.Text = Convert.ToString(Set_Torque).ToString();
                // time out
                var Set_TimeOut = Math.Round(((uint)_plc.Read("DB4.DBD132.0")).ConvertToDouble(), 3);
                tbTimeOut.Text = Convert.ToString(Set_TimeOut).ToString();
                

                //speed nâng hạ
                var Set_SpeedLift = Math.Round(((uint)_plc.Read("DB4.DBD116.0")).ConvertToDouble(), 3);
                tbSpeedLift.Text = Convert.ToString(Set_SpeedLift).ToString();
                // vị trí nâng hạ
                var LocationLift = Math.Round(((uint)_plc.Read("DB4.DBD124.0")).ConvertToDouble(), 3);
                tbLocation.Text = Convert.ToString(LocationLift).ToString();
                // Speed băng tải
                  var Set_Speed_Conveyor =Math.Round( ((uint)_plc.Read("DB4.DBD0.0")).ConvertToDouble(), 3);
                tbSpConveyor.Text = Convert.ToString(Set_Speed_Conveyor).ToString();
                // speed motor xoay
                var Set_Speed_Rotary = ((uint)_plc.Read("DB4.DBD4.0")).ConvertToDouble();
                tbSpRotary.Text = Convert.ToString(Set_Speed_Rotary).ToString();


            }

        }

        #endregion
        #region Write dữ liệu xuống PLC
        // Write dữ liệu xuống PLC
        // Speed Torque
        private void tbSpeed_Torque_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbSpeed_Torque.Text, out double TorqueSpeed))
            {
                _plc.Write("db4.dbd8.0", TorqueSpeed); // đổi địa chỉ
            }
        }
        // Set torque
        private void tbSetTorque_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbSetTorque.Text, out double Torque_Set))
            {
                _plc.Write("db4.dbd8.0", Torque_Set); // đổi địa chỉ
            }
        }
        // thời gian xong 1 chu trình
        private void tbTimeOut_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbTimeOut.Text, out double TimeOut_set))
            {
                _plc.Write("db4.dbd8.0", TimeOut_set); // đổi địa chỉ
            }
        }
        //Tốc độ nâng hạ

        private void tbSpeedLift_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbSpeedLift.Text, out double SpeedLift_Set))
            {
                _plc.Write("db4.dbd8.0", SpeedLift_Set); // đổi địa chỉ
            }
        }
        // Vị trí làm việc theo SKU
        private void tbLocation_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbLocation.Text, out double Location_Work))
            {
                _plc.Write("db4.dbd8.0", Location_Work); // đổi địa chỉ
            }
        }
        // Tốc độ băng tải
        private void tbSpConveyor_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbSpConveyor.Text, out double Speed_Conveyor))
            {
                _plc.Write("db4.dbd8.0", Speed_Conveyor); // đổi địa chỉ
            }
        }
        // Tốc độ bộ tách chai
        private void tbSpRotary_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbSpRotary.Text, out double Speed_Rotary))
            {
                _plc.Write("db4.dbd8.0", Speed_Rotary); // đổi địa chỉ
            }
        }
#endregion
    }
}
