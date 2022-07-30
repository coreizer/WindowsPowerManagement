#region License Information (GPL v3)

/**
 * Copyright (C) 2017-2022 coreizer
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

#endregion

namespace Windows_Power_Management
{
   using System;
   using System.Diagnostics;
   using System.Runtime.InteropServices;
   using System.Windows.Forms;

   public partial class Form1 : Form
  {
    // Thanks https://miromannino.com/blog/exitwindowsex-in-c/
    private class ExitWindows
    {
      private const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
      private const short SE_PRIVILEGE_ENABLED = 2;
      private const short TOKEN_ADJUST_PRIVILEGES = 32;
      private const short TOKEN_QUERY = 8;

      private const ushort EWX_LOGOFF = 0;
      private const ushort EWX_POWEROFF = 0x00000008;
      private const ushort EWX_REBOOT = 0x00000002;
      private const ushort EWX_SHUTDOWN = 0x00000001;
      private const ushort EWX_FORCE = 0x00000004;

      private struct LUID
      {
        public uint LowPart;
        public uint HighPart;
      }

      private struct LUID_AND_ATTRIBUTES
      {
        public LUID Luid;
        public uint Attributes;
      }

      private struct TOKEN_PRIVILEGES
      {
        public int PrivilegeCount;
        public LUID_AND_ATTRIBUTES Privileges;
      }

      [DllImport("advapi32.dll")]
      static extern int OpenProcessToken(IntPtr ProcessHandle, int DesiredAccess, out IntPtr TokenHandle);

      [DllImport("advapi32.dll")]
      static extern int LookupPrivilegeValue(string lpSystemName, string lpName, out LUID lpLuid);

      [DllImport("advapi32.dll", SetLastError = true)]
      [return: MarshalAs(UnmanagedType.Bool)]
      static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, uint BufferLength, IntPtr PreviousState, IntPtr ReturnLength);

      [DllImport("user32.dll", SetLastError = true)]
      static extern int ExitWindowsEx(uint uFlags, uint dwReason);

      [DllImport("user32.dll", SetLastError = true)]
      static extern bool LockWorkStation();

      private static void GetPrivileges()
      {
        TOKEN_PRIVILEGES token;
        OpenProcessToken(Process.GetCurrentProcess().Handle, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, out IntPtr hToken);
        token.PrivilegeCount = 1;
        token.Privileges.Attributes = (uint)SE_PRIVILEGE_ENABLED;
        LookupPrivilegeValue("", SE_SHUTDOWN_NAME, out token.Privileges.Luid);
        AdjustTokenPrivileges(hToken, false, ref token, 0U, IntPtr.Zero, IntPtr.Zero);
      }

      public static void Shutdown() => Shutdown(false);

      public static void Shutdown(bool force)
      {
        GetPrivileges();
        ExitWindowsEx(EWX_SHUTDOWN | (uint)(force ? EWX_FORCE : 0) | EWX_POWEROFF, 0);
      }

      public static void Reboot() => Reboot(false);

      public static void Reboot(bool force)
      {
        GetPrivileges();
        ExitWindowsEx(EWX_REBOOT | (uint)(force ? EWX_FORCE : 0), 0);
      }

      public static void LogOff() => LogOff(false);

      public static void LogOff(bool force)
      {
        GetPrivileges();
        ExitWindowsEx(EWX_LOGOFF | (uint)(force ? EWX_FORCE : 0), 0);
      }

      public static void Sleep()
      {
        LockWorkStation();
      }
    }

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ExitWindows.LogOff();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      ExitWindows.Sleep();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      ExitWindows.Shutdown();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      ExitWindows.Reboot();
    }
  }
}
