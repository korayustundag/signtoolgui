using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    public static class HighDpi
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public static bool Enable()
        {
            try
            {
                if (Environment.OSVersion.Version.Major > 6 || (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor >= 1))
                {
                    return SetProcessDPIAware();
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}