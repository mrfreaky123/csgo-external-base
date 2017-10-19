using ExternalBase.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExternalBase.Features
{
    class Bunnyhop
    {
        public static void Run()
        {
            while (true)
            {
                Thread.Sleep(1);

                if (Structs.LocalPlayer.onGround && Settings.Bunnyhop.enabled && Checks.IsKeyPushedDown(Settings.Bunnyhop.key))
                {
                    if (Settings.Bunnyhop.delay > 0) Thread.Sleep(Settings.Bunnyhop.delay);

                    Actions.Jump();
                }
            }
        }
    }
}
