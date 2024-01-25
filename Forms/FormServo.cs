using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_0801_24.Forms
{
    public partial class FormServo : Form
    {
        public Plc _plc;
        Timer Timer_Servo=new Timer();
        int Time_update_sv = 100;
        

        public FormServo()
        {
            InitializeComponent();
            //LoadTheme();
            Timer_Servo.Interval = Time_update_sv;
            Timer_Servo.Start();
            Timer_Servo.Tick += Timer_Servo_Tick;
        }
        
        private void Formservo_Load(object sender, EventArgs e)
        {
            Timer_Servo.Interval = Time_update_sv;
            Timer_Servo.Start();
            Timer_Servo.Tick += Timer_Servo_Tick;
        }
        public void Timer_Servo_Tick(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
             bool DB1_DBX0_0 = (bool)_plc.Read("DB1.DBX0.0");
                if (DB1_DBX0_0)
                {
                    sBtnHomeServo.CheckState = CheckState.Checked;
                    btnHomeServo.BackColor = Color.Green;
                }
                else
                    sBtnHomeServo.CheckState = CheckState.Unchecked;
                    btnHomeServo.BackColor = Color.Red;

            }
        }
        public struct DB16
        {
            public bool a;
            public bool b;
        }


        #region // Home servo
        private void btnHomeServo_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 1, 0, 4, 1);// home servo
            }
        }

        private void btnHomeServo_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 1, 0, 4, 0);// home servo
            }
        }

        #endregion

        private void sBtnOnServoLift_CheckedChanged(object sender, EventArgs e)
        {

            if (sBtnOnServoLift.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 0);
        }

        private void sBtnOnServo1_1_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo1_1.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 0);
        }

        private void sBtnOnServo1_2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (sBtnOnServo1_2.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 0);
        }

        private void sBtnOnServo2_1_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo2_1.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 0);
        }

        private void sBtnOnServo2_2_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo2_2.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 0);
        }

        private void sBtnOnServo3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo3_1.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 0);
        }

        private void sBtnOnServo3_2_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo3_2.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 0);
        }

        
    }
}
