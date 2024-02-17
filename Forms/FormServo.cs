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
            //Timer_Servo.Interval = Time_update_sv;
            //Timer_Servo.Start();
            //Timer_Servo.Tick += Timer_Servo_Tick;
        }
        #region Write data Manual Servo
        // write dữ liệu xuống text box jog speed lift

        private void tbJogSpeedLift_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbJogSpeedLift.Text, out double jogspeedlift))
            {
                _plc.Write("db4.dbd8.0", jogspeedlift);
            }
        }
        // hOME
        private void tbHomeSpeedLift_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbHomeSpeedLift.Text, out double homeSpeedLift))
            {
                _plc.Write("db4.dbd36.0", homeSpeedLift);
            }
        }
        // servo 1.1
        private void tbJogSpeed1_1_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbJogSpeed1_1.Text, out double JogSpeed1_1))
            {
                _plc.Write("db4.dbd12.0", JogSpeed1_1);
            }
        }
        // servo 1.2
        private void tbJogSpeed1_2_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbJogSpeed1_2.Text, out double JogSpeed1_2))
            {
                _plc.Write("db4.dbd16.0", JogSpeed1_2);
            }
        }
        // servo 2.1
        private void tbJogSpeed2_1_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbJogSpeed2_1.Text, out double JogSpeed2_1))
            {
                _plc.Write("db4.dbd20.0", JogSpeed2_1);
            }
        }

        private void tbJogSpeed2_2_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbJogSpeed2_2.Text, out double JogSpeed2_2))
            {
                _plc.Write("db4.dbd24.0", JogSpeed2_2);
            }
        }

        private void tbJogSpeed3_1_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbJogSpeed3_1.Text, out double JogSpeed3_1))
            {
                _plc.Write("db4.dbd28.0", JogSpeed3_1);
            }
        }

        private void tbJogSpeed3_2_TextChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected && double.TryParse(tbJogSpeed3_2.Text, out double JogSpeed3_2))
            {
                _plc.Write("db4.dbd32.0", JogSpeed3_2);
            }
        }


        #endregion
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
        #region On_Off_Servo
        private void sBtnOnServoLift_CheckedChanged(object sender, EventArgs e)
        {

            if (sBtnOnServoLift.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 7, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 3, 7, 0);
        }

        private void sBtnOnServo1_1_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo1_1.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 5, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 1, 5, 0);
        }

        private void sBtnOnServo1_2_CheckedChanged(object sender, EventArgs e)
        {

            if (sBtnOnServo1_2.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 6, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 1, 6, 0);
        }

        private void sBtnOnServo2_1_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo2_1.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 3, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 2, 3, 0);
        }

        private void sBtnOnServo2_2_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo2_2.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 2, 4, 0);
        }

        private void sBtnOnServo3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo3_1.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 1, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 3, 1, 0);
        }

        private void sBtnOnServo3_2_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnOnServo3_2.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 2, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 3, 2, 0);
            #endregion
        }
        #region servo4_JOG
        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 4, 0, 1);
            }
        }
        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 4, 0, 0);
            }
        }
        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 4, 1, 1);
            }
        }
        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 4, 1, 0);
            }
        }

        #endregion
        #region Cụm 1 JOG
        // servo11
        private void btnLeft1_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 0, 1);
            }
        }
        private void btnLeft1_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 0, 0);
            }
        }
        private void btnRight1_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 7, 1);
            }
        }
        private void btnRight1_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 7, 0);
            }
        }
        // servo1.2
        private void btnLeft1_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 2, 1);
            }
        }
        private void btnLeft1_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 2, 0);
            }
        }
        private void btnRight1_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 1, 1);
            }
        }
        private void btnRight1_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 1, 0);
            }
        }

        #endregion
        #region cụm 2
        // servo 2_1
        private void btnLeft2_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 6, 1);
            }
        }
        private void btnLeft2_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 6, 0);
            }
        }
        private void btnRight2_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 5, 1);
            }
        }
        private void btnRight2_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 5, 0);
            }
        }
        // servo2.2
        private void btnLeft2_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 0, 1);
            }
        }
        private void btnLeft2_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 0, 0);
            }
        }
        private void btnRight2_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 7, 1);
            }
        }
        private void btnRight2_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 2, 7, 0);
            }
        }
        #endregion
        #region cụm 3
        // servo 3_1
        private void btnLeft3_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 4, 1);
            }
        }
        private void btnLeft3_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 4, 0);
            }
        }
        private void btnRight3_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 3, 1);
            }
        }
        private void btnRight3_1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 3, 0);
            }
        }
        // servo3.2 3_6, 3_5
        private void btnLeft3_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 6, 1);
            }
        }
        private void btnLeft3_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 6, 0);
            }
        }
        private void btnRight3_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 5, 1);
            }
        }
        private void btnRight3_2_MouseUp(object sender, MouseEventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 3, 5, 0);
            }
        }








        #endregion

        public void Timer_Servo_Tick(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                //sButton check or uncheck
                
                bool DB1_DBX2_5 = (bool)_plc.Read("DB1.DBX2.5");// read bit single
                bool DB1_DBX2_4 = (bool)_plc.Read("DB1.DBX2.4"); // don't delete
                bool DB1_DBX0_0 = (bool)_plc.Read("DB1.DBX0.0");
                bool DB4_DBX1_5 = (bool)_plc.Read("DB4.DBX1.5");
                bool DB4_DBX1_6 = (bool)_plc.Read("DB4.DBX1.6");
                bool DB4_DBX2_3 = (bool)_plc.Read("DB4.DBX2.3");
                bool DB4_DBX2_4 = (bool)_plc.Read("DB4.DBX2.4");
                bool DB4_DBX3_1 = (bool)_plc.Read("DB4.DBX3.1");
                bool DB4_DBX3_2 = (bool)_plc.Read("DB4.DBX3.2");
                bool DB4_DBX3_7 = (bool)_plc.Read("DB4.DBX3.7");


                //  var DB4_DBD8 = ((uint)_plc.Read("DB4.DBD8.0")).ConvertToDouble();
              //  var Set_Speed_Conveyor =Math.Round( ((uint)_plc.Read("DB4.DBD0.0")).ConvertToDouble(), 3);
             //   var Set_Speed_Rotary = ((uint)_plc.Read("DB4.DBD4.0")).ConvertToDouble();
                var Set_SpeedJog_Servo4 = Math.Round(((uint)_plc.Read("DB4.DBD8.0")).ConvertToDouble(), 3);
                var Set_SpeedJog_Servo1_1 = Math.Round(((uint)_plc.Read("DB4.DBD12.0")).ConvertToDouble(),3);
                var Set_SpeedJog_Servo1_2 = Math.Round(((uint)_plc.Read("DB4.DBD16.0")).ConvertToDouble(),3);
                var Set_SpeedJog_Servo2_1 = Math.Round(((uint)_plc.Read("DB4.DBD20.0")).ConvertToDouble(), 3);
                var Set_SpeedJog_Servo2_2 = Math.Round(((uint)_plc.Read("DB4.DBD24.0")).ConvertToDouble(), 3);
                var Set_SpeedJog_Servo3_1 = Math.Round(((uint)_plc.Read("DB4.DBD28.0")).ConvertToDouble(), 3);
                var Set_SpeedJog_Servo3_2 = Math.Round(((uint)_plc.Read("DB4.DBD32.0")).ConvertToDouble(), 3);
                // Speed Home Serrvo
                var Set_SpeedHome_Servo4 = Math.Round(((uint)_plc.Read("DB4.DBD36.0")).ConvertToDouble(), 3);
              



                //   double result = Convert.ToDouble((uint)_plc.Read("DB1.DBD8.0"));
                //Jog to text box
                tbJogSpeed1_1.Text= Convert.ToString(Set_SpeedJog_Servo1_1).ToString();
                tbJogSpeed1_2.Text= Convert.ToString(Set_SpeedJog_Servo1_2).ToString();
                tbJogSpeed2_1.Text = Convert.ToString(Set_SpeedJog_Servo2_1).ToString();
                tbJogSpeed2_2.Text = Convert.ToString(Set_SpeedJog_Servo2_2).ToString();
                tbJogSpeedLift.Text = Convert.ToString(Set_SpeedJog_Servo4).ToString();
                tbJogSpeed3_1.Text = Convert.ToString(Set_SpeedJog_Servo3_1).ToString();
                tbJogSpeed3_2.Text = Convert.ToString(Set_SpeedJog_Servo3_2).ToString();
                //Home
                tbHomeSpeedLift.Text= Convert.ToString(Set_SpeedHome_Servo4).ToString();
                //tb.Text = Convert.ToString(Set_SpeedHome_Servo1_1).ToString();

                radioBtnLimitDown.Checked = DB1_DBX2_5;
                radioBtnLimitUp.Checked = DB1_DBX2_4;
                // status switch on/ off servo
                #region check sButton check or uncheck 
                ////test
                if (DB1_DBX0_0)
                {
                    sBtnHomeServo.CheckState = CheckState.Checked;
                    btnHomeServo.BackColor = Color.Green;
                }
                else
                {
                    sBtnHomeServo.CheckState = CheckState.Unchecked;
                    btnHomeServo.BackColor = Color.Red;
                }
                ////home
                //if (DB4_DBX3_7)
                //{
                //    sBtnOnServoLift.CheckState = CheckState.Checked;
                //}
                //else
                //{
                //    sBtnHomeServo.CheckState = CheckState.Unchecked;
                //}
                //// servo 1.1
                //if (DB4_DBX1_5)
                //{
                //    sBtnOnServo1_1.CheckState = CheckState.Checked;
                //}
                //else
                //{
                //    sBtnOnServo1_1.CheckState = CheckState.Unchecked;
                //}
                //// servo 1.2
                //if (DB4_DBX1_6)
                //{
                //    sBtnOnServo1_2.CheckState = CheckState.Checked;
                //}
                //else
                //{
                //    sBtnOnServo1_2.CheckState = CheckState.Unchecked;
                //}
                //// servo 2.1
                //if (DB4_DBX2_3)
                //{
                //    sBtnOnServo2_1.CheckState = CheckState.Checked;
                //}
                //else
                //{
                //    sBtnOnServo2_1.CheckState = CheckState.Unchecked;
                //}
                ////servo 2.2
                //if (DB4_DBX2_4)
                //{
                //    sBtnOnServo2_2.CheckState = CheckState.Checked;
                //}
                //else
                //{
                //    sBtnOnServo2_2.CheckState = CheckState.Unchecked;
                //}
                ////servo 3.1
                //if (DB4_DBX3_1)
                //{
                //    sBtnOnServo3_1.CheckState = CheckState.Checked;
                //}
                //else
                //{
                //    sBtnOnServo3_1.CheckState = CheckState.Unchecked;
                //}
                ////servo 3.2
                //if (DB4_DBX3_2)
                //{
                //    sBtnOnServo3_2.CheckState = CheckState.Checked;
                //}
                //else
                //{
                //    sBtnOnServo3_2.CheckState = CheckState.Unchecked;
                //}
                #endregion
            }
        }
        



        
    }
}
