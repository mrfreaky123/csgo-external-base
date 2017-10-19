using ExternalBase.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalBase
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // you can do you own menu, or you can just do what i've done below if you want to add more to the current menu

        private void bhopToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Bunnyhop.enabled = bhopToggle.Checked;
        }

        private void triggerToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Triggerbot.enabled = triggerToggle.Checked;
        }

        private void triggerDelay_Scroll(object sender, EventArgs e)
        {
            Settings.Triggerbot.delay = triggerDelay.Value;
        }

        private void bhopDelay_Scroll(object sender, EventArgs e)
        {
            Settings.Bunnyhop.delay = bhopDelay.Value;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
