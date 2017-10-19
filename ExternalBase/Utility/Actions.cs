using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExternalBase.Utility
{
    class Actions
    {
        public static void Shoot()
        {
            Mem.Memory.Write<int>(BaseModules.Client + Offsets.dwForceAttack, 5);
            Thread.Sleep(1);
            Mem.Memory.Write<int>(BaseModules.Client + Offsets.dwForceAttack, 4);
        }

        public static void Jump()
        {
            Mem.Memory.Write<int>(BaseModules.Client + Offsets.dwForceJump, 5);
            Thread.Sleep(1);
            Mem.Memory.Write<int>(BaseModules.Client + Offsets.dwForceJump, 4);
        }
    }
}
