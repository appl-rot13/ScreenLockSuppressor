
namespace ScreenLockSuppressor
{
    using System;
    using System.Threading;

    using ScreenLockSuppressor.Interop;

    internal static class Application
    {
        private static readonly TimeSpan Interval = TimeSpan.FromMinutes(1);

        internal static void Main()
        {
            while (true)
            {
                User32Wrapper.MoveMouse(1, 0);
                User32Wrapper.MoveMouse(-1, 0);

                Thread.Sleep(Interval);
            }
        }
    }
}
