﻿using System.Windows.Forms;

namespace Custom.Controls {
    public class TextBoxCustom : TextBox {
        public override string Text {
            get { return base.Text.Trim(); }
            set {
                if (value != null) {
                    base.Text = value.Trim();
                }
            }
        }
    }
}
