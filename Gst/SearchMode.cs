﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (Gst.SearchModeGType))]
	public enum SearchMode {

		Exact = 0,
		Before = 1,
		After = 2,
	}

	internal class SearchModeGType {
		[DllImport (DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_search_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_search_mode_get_type ());
			}
		}
	}
#endregion
}