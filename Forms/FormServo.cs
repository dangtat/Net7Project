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
        int Time_update = 100;
        
            
        public FormServo()
        {
            InitializeComponent();
            //LoadTheme();
            Timer_Servo.Interval = Time_update;
            Timer_Servo.Start();
            Timer_Servo.Tick += Timer_Servo_Tick;
        }
        public struct DB1
        {
            public bool a;
            public short b;
            public int c;
            public double d;

        }
        private void Formservo_Load(object sender, EventArgs e)
        {
            
        }
        public void Timer_Servo_Tick(object sender, EventArgs e)
        {
           //if (_plc.IsConnected)
           // {
           //     DB1 db1 = (DB1)_plc.ReadStruct(typeof(DB1), 1);
           //     tbJogSpeed.Text = db1.b.ToString();
           //     tbHomeSpeed.Text = db1.c.ToString();
           //     tbVelocity.Text = Convert.ToString(db1.d).ToString();


           // }

        }

        private void btnOnServo_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 1, 0, 4, 1);
            }
        }

        private void btnOffServo_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 1, 0, 4, 0);
            }
        }

        
    }
}
