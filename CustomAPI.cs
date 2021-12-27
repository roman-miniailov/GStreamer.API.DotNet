using System;
using System.Collections.Generic;
using System.Text;

namespace GStreamer
{
    using System.Runtime.InteropServices;

    public static class CustomAPI
    {
        [DllImport(DLL.GLib, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr g_quark_to_string(uint quark);

        [DllImport(DLL.GObject, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint g_signal_connect_data(
                       IntPtr instance,
                       IntPtr detailed_signal,
                       [MarshalAs(UnmanagedType.FunctionPtr)] Delegate c_handler,
                       IntPtr data,
                       IntPtr destroy_data,
                       uint connect_flags);

        public static uint g_signal_connect(
            IntPtr instance,
            IntPtr detailed_signal,
            [MarshalAs(UnmanagedType.FunctionPtr)] Delegate c_handler,
            IntPtr data)
        {
            return g_signal_connect_data(instance, detailed_signal, c_handler, data, IntPtr.Zero, 0);
        }
    }
}
