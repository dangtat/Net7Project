using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Learn_0801_24.Forms;
using S7.Net;

namespace Learn_0801_24
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private ShareFunction shareFunction = new ShareFunction();
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            //btnCloseChildForm.Visible = false;
            this.Text=string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            shareFunction._panelMenu = this.panelMenu;
        }
        /// <summary>
        /// //////////////////////
        /// </summary>///////
        /// <returns></returns>
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {

                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;

                }
            }
        }
        public void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif",12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void OpenchildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childform);
            this.panelDesktopPanel.Tag = childform;
 
            childform.BringToFront();
            childform.Show();
            lbTitle.Text = childform.Text;

        }
        Plc _Plc = new Plc(CpuType.S71500, "192.168.1.49", 0, 1);
        Timer timer = new Timer();
        int Time_Update = 100;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = Time_Update;
            timer.Start();
           // timer.Tick += timer1_Tick;
            if (_Plc.Open() == ErrorCode.NoError)
            {
                Timer_Connect_Plc.Enabled = true;
                Timer_Connect_Plc.Interval = 1000;
                MessageBox.Show(" Kết nối thành công với PLC");
                //_Plc.Close();
            }
            else
                MessageBox.Show("Kết nối không thành công với PLC");
        }
        //public void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (_plc.IsConnected)
        //    {
        //        byte[] DB1 = _plc.ReadBytes(DataType.Output, 0, 0, 2);

        //        //------- Q0.0 -----------------------------

        //        if (DB1[0].SelectBit(0))
        //            rdoHomeDone.Checked = true;
        //        else
        //            rdoHomeDone.Checked = false;
        //    }

        //}





        private void btnMainScreen_Click(object sender, EventArgs e)
        {
            var formMain = new Forms.FormMain();
            formMain._plc = _Plc;
            OpenchildForm(formMain, sender);

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            var FormManual = new Forms.FormManual();
            FormManual.panelControl = this.panelDesktopPanel;
            FormManual._plc = _Plc;
            FormManual.btnSender = sender;
            shareFunction.OpenchildForm1(FormManual, sender, this.panelDesktopPanel, this.lbTitle);
            //OpenchildForm(FormManual,sender);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FormAlarm(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FormSetting(), sender);

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FormData(), sender);

        }

        private void btnIO_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FormIO(), sender);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                reset();
            }
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                reset();
            }
        }

        private void reset()
        {
            DisableButton();
            lbTitle.Text = "SCREW CAPPER MACHINE";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            //btnCloseChildForm.Visible= false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState== FormWindowState.Normal)
                this.WindowState= FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FormServo = new Forms.FormServo();
            FormServo._plc = _Plc;
            OpenchildForm(FormServo, sender);
            //OpenchildForm(new Forms.FormServo(), sender);
        }
    }
}
