using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intermediate.Delegate {
    static class Tools
    {

        public static void ClearControl(Control mainControl)
        {
            foreach (var control in mainControl.Controls)
            {
                //if (control is TextBox)
                //{
                //    (control as TextBox).Text = string.Empty;
                //}
                //else if (control is NumericUpDown)
                //{
                //    (control as NumericUpDown).Value = 0;
                //}

                //You can use the below block also.
                //Preference is of course yours but I prefer the above codes for more readability and a clear syntax
                if (control is TextBox c)
                {
                    c.Text = string.Empty;
                }
                else if (control is NumericUpDown nud)
                {
                    nud.Value = 0;
                }
            }
        }

        public static void ClearControl(Control mainControl, bool focusFirstTextBox = false)
        {
            ClearControl(mainControl);
            if (focusFirstTextBox)
            {
                foreach (var control in mainControl.Controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Focus();
                        break;
                    }
                }
            }
        }
    }
}
