// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
    public partial class EffectAsset : GES.TrackElementAsset
    {

        public EffectAsset(IntPtr raw) : base(raw) { }

        protected EffectAsset() : base(IntPtr.Zero)
        {
            CreateNativeObject(new string[0], new GLib.Value[0]);
        }

        [DllImport(DLL.GES, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr ges_effect_asset_get_type();

        public static new GLib.GType GType
        {
            get
            {
                IntPtr raw_ret = ges_effect_asset_get_type();
                GLib.GType ret = new GLib.GType(raw_ret);
                return ret;
            }
        }


        static EffectAsset()
        {
            GtkSharp.GstEditingServices.ObjectManager.Initialize();
        }
        #endregion
    }
}