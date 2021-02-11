
namespace ScreenLockSuppressor.Interop
{
    using System.Runtime.InteropServices;

    internal static class User32Wrapper
    {
        public static void MoveMouse(int dx, int dy)
        {
            NativeMethods.mouse_event(0x0001, dx, dy, 0, 0);
        }

        private static class NativeMethods
        {
            [DllImport("user32.dll")]
            public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        }
    }
}
