using ExternalBase.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalBase.Features
{
    class Triggerbot
    {
        public static void Run()
        {
            while(true)
            {
                Thread.Sleep(1);
       
                if (Structs.LocalPlayer.isEnemyInCrosshair && Settings.Triggerbot.enabled && Checks.IsKeyPushedDown(Settings.Triggerbot.key))
                {
                    if (Settings.Triggerbot.delay > 0) Thread.Sleep(Settings.Triggerbot.delay);
                    Actions.Shoot();
                }
            }
        }
    }
}
