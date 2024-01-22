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
    public partial class FormManual : Form
    {
        public Plc _plc;
        Timer Timer_Manual = new Timer();
        int Time_update = 100;
        public Panel panelControl;
        public object btnSender;
        private ShareFunction _shareFunction = new ShareFunction();

        public FormManual()
        {
            InitializeComponent();

        }

       
        private void FormManual_Load(object sender, EventArgs e)
        {
           // Timer_Manual.Interval = Time_update;
           // Timer_Manual.Start();
           // Timer_Manual.Tick += Timer_Manual_Tick;
        }
         
        

        private void btnRunConveyor_Click(object sender, EventArgs e)
        {
            if(_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 3, 1);
            }
        }

        private void btnStopConveyor_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 3, 0);
            }
        }

        private void btnRunRotary_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 1);
            }
        }

        private void btnStopRotary_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 0);
            } 
        }

        private void btnCYLBottleInO_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 5, 1);
            }
        }

        private void btnCYLBottleINC_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 5, 0);
            }
        }

        private void btnCYLRejectO_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 6, 1);
            }
        }

        private void btnCYLRejectC_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 6, 0);
            }
        }

        private void btnCYLPOS1O_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 7, 1);
            }
        }

        private void btnCYLPOS1C_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 7, 0);
            }
        }

        private void btnCYLPOS2O_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 0, 1);
            }
        }

        private void btnCYLPOS2C_Click(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 0, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formTarget = new Forms.FormServo();
            formTarget._plc = _plc;
            //_shareFunction.OpenchildForm1(formTarget, btnSender, panelControl);
        }
    }
}
