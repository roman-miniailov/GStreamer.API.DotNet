﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Cancellable : GLib.Object {

		public Cancellable (IntPtr raw) : base(raw) {}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_cancellable_new();

		public Cancellable () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Cancellable)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_cancellable_new();
		}

		[GLib.Signal("cancelled")]
		public event System.EventHandler Cancelled {
			add {
				this.AddSignalHandler ("cancelled", value);
			}
			remove {
				this.RemoveSignalHandler ("cancelled", value);
			}
		}

		static CancelledNativeDelegate Cancelled_cb_delegate;
		static CancelledNativeDelegate CancelledVMCallback {
			get {
				if (Cancelled_cb_delegate == null)
					Cancelled_cb_delegate = new CancelledNativeDelegate (Cancelled_cb);
				return Cancelled_cb_delegate;
			}
		}

		static void OverrideCancelled (GLib.GType gtype)
		{
			OverrideCancelled (gtype, CancelledVMCallback);
		}

		static void OverrideCancelled (GLib.GType gtype, CancelledNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("cancelled"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CancelledNativeDelegate (IntPtr inst);

		static void Cancelled_cb (IntPtr inst)
		{
			try {
				Cancellable __obj = GLib.Object.GetObject (inst, false) as Cancellable;
				__obj.OnCancelled ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Cancellable), ConnectionMethod="OverrideCancelled")]
		protected virtual void OnCancelled ()
		{
			InternalCancelled ();
		}

		private void InternalCancelled ()
		{
			CancelledNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("cancelled"));
				unmanaged = (CancelledNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CancelledNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("cancelled"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // cancelled
							, null
							, "_g_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved1
							, "cancelled"
							, "_g_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved2
							, "_g_reserved1"
							, "_g_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved3
							, "_g_reserved2"
							, "_g_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved4
							, "_g_reserved3"
							, "_g_reserved5"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved5"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved5
							, "_g_reserved4"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_cancellable_cancel(IntPtr raw);

		public void Cancel() {
			g_cancellable_cancel(Handle);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_cancellable_disconnect(IntPtr raw, UIntPtr handler_id);

		public void Disconnect(ulong handler_id) {
			g_cancellable_disconnect(Handle, new UIntPtr (handler_id));
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_cancellable_get_current();

		public static GLib.Cancellable Current { 
			get {
				IntPtr raw_ret = g_cancellable_get_current();
				GLib.Cancellable ret = GLib.Object.GetObject(raw_ret) as GLib.Cancellable;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_cancellable_get_fd(IntPtr raw);

		public int Fd { 
			get {
				int raw_ret = g_cancellable_get_fd(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_cancellable_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_cancellable_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_cancellable_is_cancelled(IntPtr raw);

		public bool IsCancelled { 
			get {
				bool raw_ret = g_cancellable_is_cancelled(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_cancellable_make_pollfd(IntPtr raw, out GLib.PollFD pollfd);

		public bool MakePollfd(out GLib.PollFD pollfd) {
			bool raw_ret = g_cancellable_make_pollfd(Handle, out pollfd);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_cancellable_pop_current(IntPtr raw);

		public void PopCurrent() {
			g_cancellable_pop_current(Handle);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_cancellable_push_current(IntPtr raw);

		public void PushCurrent() {
			g_cancellable_push_current(Handle);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_cancellable_release_fd(IntPtr raw);

		public void ReleaseFd() {
			g_cancellable_release_fd(Handle);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_cancellable_reset(IntPtr raw);

		public void Reset() {
			g_cancellable_reset(Handle);
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_cancellable_set_error_if_cancelled(IntPtr raw, out IntPtr error);

		public unsafe bool SetErrorIfCancelled() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_cancellable_set_error_if_cancelled(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport(DLL.Gio, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_cancellable_source_new(IntPtr raw);

		public GLib.Source SourceNew() {
			IntPtr raw_ret = g_cancellable_source_new(Handle);
			GLib.Source ret = new GLib.Source(raw_ret);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
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