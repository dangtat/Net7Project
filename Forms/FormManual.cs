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
        public FormManual()
        {
            InitializeComponent();
        }

        private void sButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(_plc.IsConnected) 
            {
                if (_plc.IsConnected)
                {
                    _plc.WriteBit(DataType.DataBlock, 3, 0, 0, 0); // ( DB3.DBX0.0, BIT WRITE XUỐNG )
                }
            }
        }
    }
}
