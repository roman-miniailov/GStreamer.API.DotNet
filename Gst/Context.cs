﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Context : IEquatable<Context> {


		public static Gst.Context Zero = new Gst.Context ();

		public static Gst.Context New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Context.Zero;
			return (Gst.Context) Marshal.PtrToStructure (raw, typeof (Gst.Context));
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_context_new(IntPtr context_type, bool persistent);

		public static Context New(string context_type, bool persistent)
		{
			IntPtr native_context_type = GLib.Marshaller.StringToPtrGStrdup (context_type);
			Context result = Context.New (gst_context_new(native_context_type, persistent));
			GLib.Marshaller.Free (native_context_type);
			return result;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_context_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_context_get_context_type(IntPtr raw);

		public string ContextType { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_context_get_context_type(this_as_native);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_context_get_structure(IntPtr raw);

		public Gst.Structure Structure { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_context_get_structure(this_as_native);
				Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), false);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_context_has_context_type(IntPtr raw, IntPtr context_type);

		public bool HasContextType(string context_type) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_context_type = GLib.Marshaller.StringToPtrGStrdup (context_type);
			bool raw_ret = gst_context_has_context_type(this_as_native, native_context_type);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_context_type);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_context_is_persistent(IntPtr raw);

		public bool IsPersistent { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool raw_ret = gst_context_is_persistent(this_as_native);
				bool ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_context_writable_structure(IntPtr raw);

		public Gst.Structure WritableStructure() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_context_writable_structure(this_as_native);
			Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), true);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Context target)
		{
			target = New (native);
		}

		public bool Equals (Context other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is Context && Equals ((Context) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.Context boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.Context.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.Context (GLib.Value val)
		{
			return (Gst.Context) val.Val;
		}
#endregion
	}
}