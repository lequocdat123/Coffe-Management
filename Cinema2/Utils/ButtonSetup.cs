using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManagerment.Utils
{
    public class ButtonSetup
    {

        private static ButtonSetup instance;

        public static ButtonSetup Instance
        {
            get { if (instance == null) instance = new ButtonSetup(); return ButtonSetup.instance; }
            private set { ButtonSetup.instance = value; }
        }

        private ButtonSetup() { }
        public void ButtonTransparent(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Transparent;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.Cursor = Cursor.Current;
        }
        public void AllButtonsTransparent(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button)
                {
                    ButtonTransparent((Button)ctrl);
                }
            }
        }
        public Button CreateButton()
        {
            Button btn = new Button();
            btn.BackgroundImage = ((System.Drawing.Image)(CoffeShopManagerment.Properties.Resources.Minus));
            btn.Size = new System.Drawing.Size(20, 20);
            btn.Location = new Point { X = 229, Y = 59 };
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonTransparent(btn);
            return btn;
        }
    }
}
