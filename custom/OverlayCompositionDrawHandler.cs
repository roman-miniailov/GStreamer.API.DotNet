using System;
using System.Collections.Generic;
using System.Text;
using Gst.Video;

namespace GStreamer.custom
{
    public delegate IntPtr OverlayCompositionDrawHandler(object o, OverlayCompositionDrawArgs args);

    public class OverlayCompositionDrawArgs : GLib.SignalArgs
    {
        public Gst.Sample Sample
        {
            get
            {
                return (Gst.Sample)Args[0];
            }
        }
    }
}
