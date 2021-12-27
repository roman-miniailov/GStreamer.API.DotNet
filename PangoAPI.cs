using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GStreamer
{
    public static class PangoAPI
    {
        [DllImport(DLL.PangoCairo, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr pango_cairo_font_map_get_default();
                
        [DllImport(DLL.Pango, CallingConvention = CallingConvention.Cdecl)]
        public extern static void pango_font_map_list_families(IntPtr font_map, IntPtr families, out int count);
    }
}
