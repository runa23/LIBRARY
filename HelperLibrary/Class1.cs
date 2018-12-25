using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace HelperLibrary
{
    public class Class1
    {
        public const int WM_SETREDRAW = 11; 
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        public int test()
        {
            return 0;
        }
    }
}
