using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Azzeton.Shared
{
    public class Keyboard
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int virtualKeyCode);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vkey);
        [DllImport("user32.dll")]
        public static extern int GetKeyboardState(byte[] keystate);
        public static bool GetDepressedKey(System.Windows.Forms.Keys key)
        {
            return Convert.ToBoolean(GetKeyState((int)key));
        }
        public static bool CapsLockOn
        {
            get{return (((ushort)GetKeyState(0x14 /*VK_CAPITAL*/)) & 0xffff) != 0;}
        }
        public static bool NumLockOn
        {
            get { return (((ushort)GetKeyState(0x90 /*VK_NUMLOCK*/)) & 0xffff) != 0; }
        }
        public static bool ScrollLockOn
        {
            get{return (((ushort)GetKeyState(0x91 /*VK_NUMLOCK*/)) & 0xffff) != 0;}
        }
    }
}




  //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    byte[] keys = new byte[255];

        //    GetKeyboardState(keys);

        //    if (keys[(int)Keys.Up] == 129 && keys[(int)Keys.Right] == 129)
        //    {
        //        Console.WriteLine("Up Arrow key and Right Arrow key down.");
        //    }
        //}