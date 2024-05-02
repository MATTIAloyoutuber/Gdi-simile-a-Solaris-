using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("user32.dll")]
    public static extern IntPtr GetDC(IntPtr hwnd);

    [DllImport("user32.dll")]
    public static extern int GetSystemMetrics(int nIndex);

    [DllImport("gdi32.dll")]
    public static extern bool BitBlt(IntPtr hdc, int x, int y, int cx, int cy, IntPtr hdcSrc, int x1, int y1, uint rop);

    [DllImport("kernel32.dll")]
    public static extern void Sleep(int dwMilliseconds);

    static void Main()
    {
        int y1;
        int v4;
        int v5;
        int y;
        int x;
        int v9;
        int v10;
        IntPtr hdc = GetDC(IntPtr.Zero);
        v10 = GetSystemMetrics(0);
        v9 = GetSystemMetrics(1);
        while (true)
        {
            hdc = GetDC(IntPtr.Zero);
            x = new Random().Next() % v10;
            y = new Random().Next() % v9;
            y1 = new Random().Next() % 21 + y - 10;
            v4 = new Random().Next();
            BitBlt(hdc, x, y, 200, 200, hdc, v4 % 21 + x - 10, y1, 0xEE0086);
            v5 = new Random().Next();
            Sleep(1);
        }
    }
}
