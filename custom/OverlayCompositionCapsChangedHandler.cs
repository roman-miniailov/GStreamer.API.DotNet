using System;
using System.Collections.Generic;
using System.Text;
using Gst.Video;

namespace GStreamer.custom
{
    public delegate void OverlayCompositionCapsChangedHandler(object o, OverlayCompositionCapsChangedArgs args);

    public class OverlayCompositionCapsChangedArgs : GLib.SignalArgs
    {
        public Gst.Caps Caps
        {
            get
            {
                return (Gst.Caps)Args[0];
            }
        }

        public int WindowWidth
        {
            get
            {
                return (int)Args[1];
            }
        }

        public int WindowHeight
        {
            get
            {
                return (int)Args[2];
            }
        }
    }
}
