using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExternalBase.Utility
{
    class Updater
    {
        public static void Run()
        {
            while(true)
            {
                Thread.Sleep(1);
                Structs.LocalPlayer.Base = Mem.Memory.Read<int>(BaseModules.Client + Offsets.dwLocalPlayer);
                Structs.LocalPlayer.Health = Mem.Memory.Read<int>(Structs.LocalPlayer.Base + Netvars.m_iHealth);
                Structs.LocalPlayer.onGround = Checks.canBhop(Mem.Memory.Read<int>(Structs.LocalPlayer.Base + Netvars.m_fFlags));
                Structs.LocalPlayer.shotsFired = Mem.Memory.Read<int>(Structs.LocalPlayer.Base + Netvars.m_iShotsFired);
                Structs.LocalPlayer.teamNum = Mem.Memory.Read<int>(Structs.LocalPlayer.Base + Netvars.m_iTeamNum);
                Structs.LocalPlayer.crosshairID = Mem.Memory.Read<int>(Structs.LocalPlayer.Base + Netvars.m_iCrosshairId);

                int activewep = Mem.Memory.Read<int>(Structs.LocalPlayer.Base + Netvars.m_hActiveWeapon) & 0xFFF;
                int entity = Mem.Memory.Read<int>(BaseModules.Client + Offsets.dwEntityList + (activewep - 1) * 0x10);
                Structs.LocalPlayer.WeaponID = Mem.Memory.Read<int>(entity + Netvars.m_iItemDefinitionIndex);

                //trigger shit here
                int crosshairEntityBase = Mem.Memory.Read<int>(BaseModules.Client + Offsets.dwEntityList + (Structs.LocalPlayer.crosshairID - 1) * 0x10);
                Structs.LocalPlayer.isEnemyInCrosshair = Checks.IsEnemyInCrosshair(crosshairEntityBase);
            }
        }
    }
}
