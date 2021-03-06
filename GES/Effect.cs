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
    public partial class Effect : GES.BaseEffect
    {

        public Effect(IntPtr raw) : base(raw) { }

        [DllImport(DLL.GES, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr ges_effect_new(IntPtr bin_description);

        public Effect(string bin_description) : base(IntPtr.Zero)
        {
            if (GetType() != typeof(Effect))
            {
                var vals = new List<GLib.Value>();
                var names = new List<string>();
                names.Add("bin_description");
                vals.Add(new GLib.Value(bin_description));
                CreateNativeObject(names.ToArray(), vals.ToArray());
                return;
            }
            IntPtr native_bin_description = GLib.Marshaller.StringToPtrGStrdup(bin_description);
            Raw = ges_effect_new(native_bin_description);
            GLib.Marshaller.Free(native_bin_description);
        }

        [GLib.Property("bin-description")]
        public string BinDescription
        {
            get
            {
                GLib.Value val = GetProperty("bin-description");
                string ret = (string)val;
                val.Dispose();
                return ret;
            }
        }


        // Internal representation of the wrapped structure ABI.
        static GLib.AbiStruct _class_abi = null;
        static public new GLib.AbiStruct class_abi
        {
            get
            {
                if (_class_abi == null)
                    _class_abi = new GLib.AbiStruct(new List<GLib.AbiField>{
                        new GLib.AbiField("rate_properties"
                            , GES.BaseEffect.class_abi.Fields
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) // rate_properties
							, null
                            , "_ges_reserved"
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                        new GLib.AbiField("_ges_reserved"
                            , -1
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, "rate_properties"
                            , null
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                    });

                return _class_abi;
            }
        }


        // End of the ABI representation.

        [DllImport(DLL.GES, CallingConvention = CallingConvention.Cdecl)]
        static extern bool ges_effect_class_register_rate_property(IntPtr element_name, IntPtr property_name);

        public static bool RegisterRateProperty(string element_name, string property_name)
        {
            IntPtr native_element_name = GLib.Marshaller.StringToPtrGStrdup(element_name);
            IntPtr native_property_name = GLib.Marshaller.StringToPtrGStrdup(property_name);
            bool raw_ret = ges_effect_class_register_rate_property(native_element_name, native_property_name);
            bool ret = raw_ret;
            GLib.Marshaller.Free(native_element_name);
            GLib.Marshaller.Free(native_property_name);
            return ret;
        }

        [DllImport(DLL.GES, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr ges_effect_get_type();

        public static new GLib.GType GType
        {
            get
            {
                IntPtr raw_ret = ges_effect_get_type();
                GLib.GType ret = new GLib.GType(raw_ret);
                return ret;
            }
        }


        static Effect()
        {
            GtkSharp.GstEditingServices.ObjectManager.Initialize();
        }

        // Internal representation of the wrapped structure ABI.
        static GLib.AbiStruct _abi_info = null;
        static public new GLib.AbiStruct abi_info
        {
            get
            {
                if (_abi_info == null)
                    _abi_info = new GLib.AbiStruct(new List<GLib.AbiField>{
                        new GLib.AbiField("priv"
                            , GES.BaseEffect.abi_info.Fields
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
                            , "_ges_reserved"
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                        new GLib.AbiField("_ges_reserved"
                            , -1
                            , (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, "priv"
                            , null
                            , (uint) Marshal.SizeOf(typeof(IntPtr))
                            , 0
                            ),
                    });

                return _abi_info;
            }
        }


        // End of the ABI representation.

        #endregion
    }
}
