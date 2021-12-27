using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GLib
{
    using GStreamer;

    public static class Env
    {
        [DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
        static extern bool g_setenv(IntPtr variable, IntPtr value, bool overwrite);

        public static bool SetEnv(string variable, string value, bool overwrite)
        {
            var variablePtr = global::GLib.Marshaller.StringToPtrGStrdup(variable);
            var valuePtr = global::GLib.Marshaller.StringToPtrGStrdup(value);

            var res =  g_setenv(variablePtr, valuePtr, overwrite);

            global::GLib.Marshaller.Free(variablePtr);
            global::GLib.Marshaller.Free(valuePtr);

            return res;
        }
    }
}
