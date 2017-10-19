using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalBase.Utility
{
    class Settings
    {
        public class Triggerbot
        {
            public static bool enabled = false;
            public static int delay = 0;
            public static Keys key = Keys.Menu; //if you want to use alt use must use keys.menu not keys.alt
        }

        public class Bunnyhop
        {
            public static bool enabled = false;
            public static int delay = 0;
            public static Keys key = Keys.Space;
        }
    }
}
