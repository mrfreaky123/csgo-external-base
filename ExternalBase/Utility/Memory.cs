using ExternalBase.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExternalBase
{
    class Mem
    {
        //credits to https://www.unknowncheats.me/forum/members/849921.html for memory class, i've changed it around a bit but it was based off his
        public class Variables
        {
            public static int ProcessHandle;
            public static int bytesRead;
            public static int bytesWritten;

            public const int PROCESS_VM_OPERATION = 0x0008;
            public const int PROCESS_VM_READ = 0x0010;
            public const int PROCESS_VM_WRITE = 0x0020;
        }

        public class Memory
        {
            public static bool Setup(Process proc)
            {
                if (proc == null)
                    return false;

                Variables.ProcessHandle = (int)Windows.Imports.OpenProcess(Variables.PROCESS_VM_OPERATION | Variables.PROCESS_VM_READ | Variables.PROCESS_VM_WRITE, false, proc.Id);
                return true;
            }

            public static void Write<var>(int memaddress, object value) where var : struct
            {
                byte[] buffer = Transform.ToByteArray(value);
                Windows.Imports.WriteProcessMemory(Variables.ProcessHandle, memaddress, buffer, buffer.Length, out Variables.bytesWritten);
            }

            public static byte[] Read(int memaddress, int size)
            {
                byte[] buffer = new byte[size];
                Windows.Imports.ReadProcessMemory(Variables.ProcessHandle, memaddress, buffer, size, ref Variables.bytesRead);
                return buffer;
            }

            public static var Read<var>(int memaddress) where var : struct
            {
                int size = Marshal.SizeOf(typeof(var));
                byte[] buffer = new byte[size];
                Windows.Imports.ReadProcessMemory(Variables.ProcessHandle, memaddress, buffer, size, ref Variables.bytesRead);
                return Transform.ToStructure<var>(buffer);
            }
        }

        public class Transform
        {
            public static T ToStructure<T>(byte[] bytes) where T : struct
            {
                GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);

                try
                {
                    return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
                }
                finally
                {
                    handle.Free();
                }
            }

            public static byte[] ToByteArray(object obj)
            {
                int length = Marshal.SizeOf(obj);

                byte[] array = new byte[length];

                IntPtr pointer = Marshal.AllocHGlobal(length);

                Marshal.StructureToPtr(obj, pointer, true);
                Marshal.Copy(pointer, array, 0, length);
                Marshal.FreeHGlobal(pointer);

                return array;
            }
        }

        public class Modules
        {
            public static bool Initialize(Process process)
            {
                bool clientLoaded = false;
                bool engineLoaded = false;
                foreach (ProcessModule module in process.Modules)
                {
                    if (module.ModuleName == "client.dll" && !clientLoaded)
                    {
                        BaseModules.Client = (int)module.BaseAddress;
                        clientLoaded = true;
                    }
                    else if (module.ModuleName == "engine.dll" && !engineLoaded)
                    {
                        BaseModules.Engine = (int)module.BaseAddress;
                        engineLoaded = true;
                    }
                    else if (engineLoaded && clientLoaded)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
