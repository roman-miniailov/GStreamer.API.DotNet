using System;
using System.Collections.Generic;
using System.Text;

namespace GStreamer
{
    public static class DLL
    {
#if __ANDROID__
        public const string GStreamer = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GStreamer = "gstreamer-1.0-0.dll";
#elif __MACOS__
        public const string GStreamer = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstreamer-1.0.0.dylib";
#elif __IOS__
        public const string GStreamer = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GStreamer = "gstreamer-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GObject = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GObject = "gobject-2.0-0.dll";
#elif __MACOS__
        public const string GObject = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgobject-2.0.dylib";
#elif __IOS__
        public const string GObject = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GObject = "gobject-2.0-0.dll";
#endif

#if __ANDROID__
        public const string GLib = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GLib = "glib-2.0-0.dll";
#elif __MACOS__
        public const string GLib = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libglib-2.0.dylib";
#elif __IOS__
        public const string GLib = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GLib = "glib-2.0-0.dll";
#endif

#if __ANDROID__
        public const string GES = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GES = "ges-1.0-0.dll";
#elif __MACOS__
        public const string GES = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libglib-2.0.dylib";
#elif __IOS__
        public const string GES = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GES = "ges-1.0-0.dll";
#endif

#if __ANDROID__
        public const string PangoCairo = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string PangoCairo = "pangocairo-1.0-0.dll";
#elif __MACOS__
        public const string PangoCairo = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libpangocairo-1.0.dylib";
#elif __IOS__
        public const string PangoCairo = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string PangoCairo = "pangocairo-1.0-0.dll";
#endif

#if __ANDROID__
        public const string Pango = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string Pango = "pango-1.0-0.dll";
#elif __MACOS__
        public const string Pango = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libpango-1.0.dylib";
#elif __IOS__
        public const string Pango = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string Pango = "pango-1.0-0.dll";
#endif

#if __ANDROID__
        public const string Gio = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string Gio = "gio-2.0-0.dll";
#elif __MACOS__
        public const string Gio = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgio-2.0.dylib";
#elif __IOS__
        public const string Gio = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string Gio = "gio-2.0-0.dll";
#endif

#if NETFRAMEWORK
        public const string KS = "GStreamer.MediaBlocks.API.dll";
#else
        public const string KS = "___";
#endif


#if __ANDROID__
        public const string GstBase = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstBase = "gstbase-1.0-0.dll";
#elif __MACOS__
        public const string GstBase = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstbase-1.0.0.dylib";
#elif __IOS__
        public const string GstBase = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstBase = "gstbase-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstApp = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstApp = "gstapp-1.0-0.dll";
#elif __MACOS__
        public const string GstApp = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstapp-1.0.dylib";
#elif __IOS__
        public const string GstApp = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstApp = "gstapp-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstAudio = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstAudio = "gstaudio-1.0-0.dll";
#elif __MACOS__
        public const string GstAudio = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstaudio-1.0.0.dylib";
#elif __IOS__
        public const string GstAudio = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstAudio = "gstaudio-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstFFT = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstFFT = "gstfft-1.0-0.dll";
#elif __MACOS__
        public const string GstFFT = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstfft-1.0.dylib";
#elif __IOS__
        public const string GstFFT = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstFFT = "gstfft-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstController = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstController = "gstcontroller-1.0-0.dll";
#elif __MACOS__
        public const string GstController = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstcontroller-1.0.dylib";
#elif __IOS__
        public const string GstController = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstController = "gstcontroller-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstNet = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstNet = "gstnet-1.0-0.dll";
#elif __MACOS__
        public const string GstNet = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstnet-1.0.0.dylib";
#elif __IOS__
        public const string GstNet = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstNet = "gstnet-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstPbUtils = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstPbUtils = "gstpbutils-1.0-0.dll";
#elif __MACOS__
        public const string GstPbUtils = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstpbutils-1.0.dylib";
#elif __IOS__
        public const string GstPbUtils = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstPbUtils = "gstpbutils-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstRtp = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstRtp = "gstrtp-1.0-0.dll";
#elif __MACOS__
        public const string GstRtp = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstrtp-1.0.dylib";
#elif __IOS__
        public const string GstRtp = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstRtp = "gstrtp-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstRtsp = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstRtsp = "gstrtsp-1.0-0.dll";
#elif __MACOS__
        public const string GstRtsp = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstrtsp-1.0.dylib";
#elif __IOS__
        public const string GstRtsp = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstRtsp = "gstrtsp-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstSDP = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstSDP = "gstsdp-1.0-0.dll";
#elif __MACOS__
        public const string GstSDP = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstsdp-1.0.dylib";
#elif __IOS__
        public const string GstSDP = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstSDP = "gstsdp-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstTag = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstTag = "gsttag-1.0-0.dll";
#elif __MACOS__
        public const string GstTag = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgsttag-1.0.dylib";
#elif __IOS__
        public const string GstTag = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstTag = "gsttag-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstVideo = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstVideo = "gstvideo-1.0-0.dll";
#elif __MACOS__
        public const string GstVideo = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstvideo-1.0.dylib";
#elif __IOS__
        public const string GstVideo = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstVideo = "gstvideo-1.0-0.dll";
#endif

#if __ANDROID__
        public const string GstWebRTC = "libgstreamer_android.so";
#elif NETFRAMEWORK
        public const string GstWebRTC = "gstwebrtc-1.0-0.dll";
#elif __MACOS__
        public const string GstWebRTC = "/Library/Frameworks/GStreamer.framework/Versions/1.0/lib/libgstwebrtc-1.0.dylib";
#elif __IOS__
        public const string GstWebRTC = "@rpath/gstreamer_ios_simulator.framework/gstreamer_ios_simulator";
#else
        public const string GstWebRTC = "gstwebrtc-1.0-0.dll";
#endif
    }
}
