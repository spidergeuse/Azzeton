using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Azzeton.Shared
{
    public class Volume
    {
        [DllImport("kernel32.dll")]
        private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, UInt32 VolumeNameSize, ref UInt32 VolumeSerialNumber, ref UInt32 MaximumComponentLength, ref UInt32 FileSystemFlags, StringBuilder FileSystemNameBuffer, UInt32 FileSystemNameSize);
        public static string GetVolumeSerial(string strDriveLetter)
        {
            uint serNum = 0;
            uint maxCompLen = 0;
            StringBuilder VolLabel = new StringBuilder(256);
            UInt32 VolFlags = new UInt32();
            StringBuilder FSName = new StringBuilder(256);
            strDriveLetter += ":\\";
            long Ret = GetVolumeInformation(strDriveLetter, VolLabel, (UInt32)VolLabel.Capacity, ref serNum, ref maxCompLen, ref VolFlags, FSName, (UInt32)FSName.Capacity);
            return Convert.ToString(serNum);
        }
        public static string GetVolumeSerial()
        {
            return  GetVolumeSerial(new System.IO.DirectoryInfo(System.Windows.Forms.Application.StartupPath).Root.ToString().Replace("\\", "").Replace(":", ""));
        }
    }
}
