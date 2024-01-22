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
        public FormSetting()
        {
            InitializeComponent();
            //panelCalib.BackColor = Color.FromArgb(39, 39, 58);
            //panelCalib.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadTheme();
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
    }
}
