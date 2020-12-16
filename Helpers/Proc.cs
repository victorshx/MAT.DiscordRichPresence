using System;
using System.Diagnostics;

namespace MAT.DiscordRichPresence.Helpers
{
    class Proc
    {
        public static Process[] GetProcesses(string procName)
        {
            return Process.GetProcessesByName(procName);
        }

        public static bool IsRunning(string procName)
        {
            Process[] processes = Process.GetProcessesByName(procName);
            if (processes.Length > 0) return true;

            return false;
        }

        public static bool IsAlive(int pId)
        {
            try
            {
                Process p = Process.GetProcessById(pId);
                return true;
            } catch (ArgumentException)
            {
                return false;
            }
        }
    }
}
