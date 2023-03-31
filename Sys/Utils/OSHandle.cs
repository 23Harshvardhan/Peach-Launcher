using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace Peach_Launcher.Sys.Utils
{
    internal class OSHandle
    {
        public static void ShutDownOS(int timeout = 0)
        {
            Process.Start("shutdown", "/s /t " + timeout);
        }

        public static void RestartOS(int timeout = 0)
        {
            Process.Start("shutdown", "/r /t " + timeout);
        }
    }
}
 