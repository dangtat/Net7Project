using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_0801_24.Forms
{
    public static class FormOpenChildForm
    {
        public static void OpenChildForm(Form parentForm, Form childForm, object btnSender, Panel panel, Label label)
        {
            if (parentForm.ActiveMdiChild != null)
            {
                parentForm.ActiveMdiChild.Close();
            }
            ActivateButton(parentForm, btnSender);
            childForm.MdiParent = parentForm;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label.Text = childForm.Text;
        }

        private static void ActivateButton(Form parentForm, object btnSender)
        {
            foreach (Control control in parentForm.Controls["panelMenu"].Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.FromArgb(51, 51, 76);
                }
            }

            Button button = (Button)btnSender;
            button.BackColor = Color.FromArgb(46, 51, 73);
        }
    }
}

