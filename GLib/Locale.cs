using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLib
{
    using System.Runtime.InteropServices;

    public static class Locale
    {
        public enum LocaleType
        {
            CTYPE = 0,

            NUMERIC = 1,

            TIME = 2,

            COLLATE = 3,

            MONETARY = 4,

            MESSAGES = 5,

            ALL = 6,

            PAPER = 7,

            NAME = 8,

            ADDRESS = 9,

            TELEPHONE = 10,

            MEASUREMENT = 11,

            IDENTIFICATION = 12
        }

        [DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr setlocale(int category, IntPtr locale);

        public static void SetLocale(LocaleType category, string value)
        {
            // en_US.UTF-8
            var valuePtr = global::GLib.Marshaller.StringToPtrGStrdup(value);

            var res = setlocale((int)category, valuePtr);

            global::GLib.Marshaller.Free(valuePtr);
        }
    }
}
