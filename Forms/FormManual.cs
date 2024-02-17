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
        public FormManual()
        {
            InitializeComponent();
            Timer_Manual.Interval = Time_update;
            Timer_Manual.Start();
            Timer_Manual.Tick += Timer_Manual_Tick;
        }
        public void Timer_Manual_Tick(object sender, EventArgs e)
        {
            
            // đọc biến lên ở đây
        }
        private void sBtnRunConv_CheckedChanged(object sender, EventArgs e)
        {
            if (_plc.IsConnected)
            {


                if (sBtnRunConv.Checked)
                {
                    _plc.WriteBit(DataType.DataBlock, 3, 0, 3, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

                }
                else
                    _plc.WriteBit(DataType.DataBlock, 3, 0, 3, 0);
            }   
        }

        private void sBtnCYLPressCapper_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnCYLPressCapper.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 1, 4, 0);
        }

        private void sBtnRunRotary_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnRunRotary.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 4, 0);
        }

        private void sBtnCYLKeepCapper_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnCYLKeepCapper.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 2, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 1, 2, 0);
        }

        private void sBtnKeepBottle_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnKeepBottle.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 3, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 1, 3, 0);
        }

        private void sBtnCYLBlockBottle_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnCYLBlockBottle.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 5, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 5, 0);
        }

        private void sBtnCYLPos1_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnCYLPos1.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 0, 7, 1); // ( DB3.DBX0.7, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 0, 7, 0);
        }

        private void sBtnCYLPos2_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnCYLPos2.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 0, 1); // ( DB3.DBX0.7, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 1, 0, 0);
        }

        private void sBtnCYLPos3_CheckedChanged(object sender, EventArgs e)
        {
            if (sBtnCYLPos3.Checked)
            {
                _plc.WriteBit(DataType.DataBlock, 3, 1, 1, 1); // ( DB3.DBX0.7, BIT WRITE XUỐNG ) }

            }
            else
                _plc.WriteBit(DataType.DataBlock, 3, 1, 1, 0);
        }
        




        //private void sButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(_plc.IsConnected) 
        //    {
        //        if (_plc.IsConnected)
        //        {
        //            _plc.WriteBit(DataType.DataBlock, 3, 0, 3, 1); // ( DB3.DBX0.0, BIT WRITE XUỐNG )
        //        }
        //        else
        //            _plc.WriteBit(DataType.DataBlock, 3, 0, 3, 0);
        //    }
        //}
    }
}
