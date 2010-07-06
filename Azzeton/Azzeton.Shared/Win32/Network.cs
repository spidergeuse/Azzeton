using System.Runtime.InteropServices;

namespace Azzeton.Shared
{
    public class Network
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(ref uint connected, uint reserved);
        private static uint uConnection = 0x20;
        public static bool HasInternetConnection
        {
            get 
            {
                try
                {
                    return InternetGetConnectedState(ref uConnection, 0);
                }
                catch { return false; }
            }
        }
    }
}
