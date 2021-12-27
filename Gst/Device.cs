﻿// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

    using GStreamer;

    #region Autogenerated code
	public partial class Device : Gst.Object {

		protected Device (IntPtr raw) : base(raw) {}

		protected Device() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_get_caps(IntPtr raw);

		[GLib.Property ("caps")]
		public Gst.Caps Caps {
			get  {
				IntPtr raw_ret = gst_device_get_caps(Handle);
				Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_get_device_class(IntPtr raw);

		[GLib.Property ("device-class")]
		public string DeviceClass {
			get  {
				IntPtr raw_ret = gst_device_get_device_class(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_get_display_name(IntPtr raw);

		[GLib.Property ("display-name")]
		public string DisplayName {
			get  {
				IntPtr raw_ret = gst_device_get_display_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_get_properties(IntPtr raw);

		[GLib.Property ("properties")]
		public Gst.Structure Properties {
			get  {
				IntPtr raw_ret = gst_device_get_properties(Handle);
				Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), true);
				return ret;
			}
		}

		[GLib.Signal("removed")]
		public event System.EventHandler Removed {
			add {
				this.AddSignalHandler ("removed", value);
			}
			remove {
				this.RemoveSignalHandler ("removed", value);
			}
		}

		static RemovedNativeDelegate Removed_cb_delegate;
		static RemovedNativeDelegate RemovedVMCallback {
			get {
				if (Removed_cb_delegate == null)
					Removed_cb_delegate = new RemovedNativeDelegate (Removed_cb);
				return Removed_cb_delegate;
			}
		}

		static void OverrideRemoved (GLib.GType gtype)
		{
			OverrideRemoved (gtype, RemovedVMCallback);
		}

		static void OverrideRemoved (GLib.GType gtype, RemovedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "removed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RemovedNativeDelegate (IntPtr inst);

		static void Removed_cb (IntPtr inst)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				__obj.OnRemoved ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Device), ConnectionMethod="OverrideRemoved")]
		protected virtual void OnRemoved ()
		{
			InternalRemoved ();
		}

		private void InternalRemoved ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static CreateElementNativeDelegate CreateElement_cb_delegate;
		static CreateElementNativeDelegate CreateElementVMCallback {
			get {
				if (CreateElement_cb_delegate == null)
					CreateElement_cb_delegate = new CreateElementNativeDelegate (CreateElement_cb);
				return CreateElement_cb_delegate;
			}
		}

		static void OverrideCreateElement (GLib.GType gtype)
		{
			OverrideCreateElement (gtype, CreateElementVMCallback);
		}

		static void OverrideCreateElement (GLib.GType gtype, CreateElementNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("create_element"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateElementNativeDelegate (IntPtr inst, IntPtr name);

		static IntPtr CreateElement_cb (IntPtr inst, IntPtr name)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				Gst.Element __result;
				__result = __obj.OnCreateElement (GLib.Marshaller.Utf8PtrToString (name));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Device), ConnectionMethod="OverrideCreateElement")]
		protected virtual Gst.Element OnCreateElement (string name)
		{
			return InternalCreateElement (name);
		}

		private Gst.Element InternalCreateElement (string name)
		{
			CreateElementNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("create_element"));
				unmanaged = (CreateElementNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CreateElementNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr __result = unmanaged (this.Handle, native_name);
			GLib.Marshaller.Free (native_name);
			return GLib.Object.GetObject(__result) as Gst.Element;
		}

		static ReconfigureElementNativeDelegate ReconfigureElement_cb_delegate;
		static ReconfigureElementNativeDelegate ReconfigureElementVMCallback {
			get {
				if (ReconfigureElement_cb_delegate == null)
					ReconfigureElement_cb_delegate = new ReconfigureElementNativeDelegate (ReconfigureElement_cb);
				return ReconfigureElement_cb_delegate;
			}
		}

		static void OverrideReconfigureElement (GLib.GType gtype)
		{
			OverrideReconfigureElement (gtype, ReconfigureElementVMCallback);
		}

		static void OverrideReconfigureElement (GLib.GType gtype, ReconfigureElementNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("reconfigure_element"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ReconfigureElementNativeDelegate (IntPtr inst, IntPtr element);

		static bool ReconfigureElement_cb (IntPtr inst, IntPtr element)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				bool __result;
				__result = __obj.OnReconfigureElement (GLib.Object.GetObject(element) as Gst.Element);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Device), ConnectionMethod="OverrideReconfigureElement")]
		protected virtual bool OnReconfigureElement (Gst.Element element)
		{
			return InternalReconfigureElement (element);
		}

		private bool InternalReconfigureElement (Gst.Element element)
		{
			ReconfigureElementNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("reconfigure_element"));
				unmanaged = (ReconfigureElementNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ReconfigureElementNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, element == null ? IntPtr.Zero : element.Handle);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("create_element"
							, Gst.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // create_element
							, null
							, "reconfigure_element"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("reconfigure_element"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // reconfigure_element
							, "create_element"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "reconfigure_element"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_device_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_device_create_element(IntPtr raw, IntPtr name);

		public Gst.Element CreateElement(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_device_create_element(Handle, native_name);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		public Gst.Element CreateElement() {
			return CreateElement (null);
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_device_has_classes(IntPtr raw, IntPtr classes);

		public bool HasClasses(string classes) {
			IntPtr native_classes = GLib.Marshaller.StringToPtrGStrdup (classes);
			bool raw_ret = gst_device_has_classes(Handle, native_classes);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_classes);
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_device_has_classesv(IntPtr raw, IntPtr[] classes);

		public bool HasClassesv(string[] classes) {
			int cnt_classes = classes == null ? 0 : classes.Length;
			IntPtr[] native_classes = new IntPtr [cnt_classes + 1];
			for (int i = 0; i < cnt_classes; i++)
				native_classes [i] = GLib.Marshaller.StringToPtrGStrdup (classes[i]);
			native_classes [cnt_classes] = IntPtr.Zero;
			bool raw_ret = gst_device_has_classesv(Handle, native_classes);
			bool ret = raw_ret;
			for (int i = 0; i < native_classes.Length - 1; i++) {
				classes [i] = GLib.Marshaller.Utf8PtrToString (native_classes[i]);
				GLib.Marshaller.Free (native_classes[i]);
			}
			return ret;
		}

		[DllImport(DLL.GStreamer, CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_device_reconfigure_element(IntPtr raw, IntPtr element);

		public bool ReconfigureElement(Gst.Element element) {
			bool raw_ret = gst_device_reconfigure_element(Handle, element == null ? IntPtr.Zero : element.Handle);
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
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