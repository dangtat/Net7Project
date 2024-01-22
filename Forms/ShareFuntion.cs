using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_0801_24.Forms
{
    public class ShareFunction
    {
        private Form _activeForm;
        public Panel _panelMenu;

        //public Title
        public void OpenchildForm1(Form childform, object btnSender, Panel panelDesktopPanel, Label title)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            ActivateButton(btnSender);
            _activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(childform);
            panelDesktopPanel.Tag = childform;

            childform.BringToFront();
            childform.Show();
            title.Text = childform.Text;

        }

        public void ActivateButton(object sender)
        {
            DisableButton();
            var btnSender = (Button)sender;
            btnSender.BackColor = Color.White;
        }

        public void DisableButton()
        {
            if(_panelMenu != null) {
                foreach (Control previousBtn in _panelMenu.Controls)
                {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                        previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                        previousBtn.ForeColor = Color.Gainsboro;
                        previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }
        }
    }
}
