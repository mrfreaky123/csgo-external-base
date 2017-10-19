using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalBase.Utility
{
    class Checks
    {
        public static bool canBhop(int input) { return (input != 256); }

        public static bool IsEnemyInCrosshair(int entitybase)
        {
            int team = Mem.Memory.Read<int>(entitybase + Netvars.m_iTeamNum);
            int health = Mem.Memory.Read<int>(entitybase + Netvars.m_iHealth);

            if (team != Structs.LocalPlayer.teamNum && health > 0)
                return true;
            else
                return false;
        }
    }
}
