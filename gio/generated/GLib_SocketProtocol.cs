﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[GLib.GType (typeof (GLib.SocketProtocolGType))]
	public enum SocketProtocol {

		Unknown = -1,
		Default,
		Tcp = 6,
		Udp = 17,
		Sctp = 132,
	}

	internal class SocketProtocolGType {
		[DllImport (DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_protocol_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_socket_protocol_get_type ());
			}
		}
	}
#endregion
}