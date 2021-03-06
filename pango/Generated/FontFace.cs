// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FontFace : GLib.Object {

		public FontFace (IntPtr raw) : base(raw) {}

		protected FontFace() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_font_face_describe(IntPtr raw);
		static d_pango_font_face_describe pango_font_face_describe = FuncLoader.LoadFunction<d_pango_font_face_describe>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_face_describe"));

		public Pango.FontDescription Describe() {
			IntPtr raw_ret = pango_font_face_describe(Handle);
			Pango.FontDescription ret = raw_ret == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontDescription), true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_font_face_get_face_name(IntPtr raw);
		static d_pango_font_face_get_face_name pango_font_face_get_face_name = FuncLoader.LoadFunction<d_pango_font_face_get_face_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_face_get_face_name"));

		public string FaceName { 
			get {
				IntPtr raw_ret = pango_font_face_get_face_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_font_face_get_type();
		static d_pango_font_face_get_type pango_font_face_get_type = FuncLoader.LoadFunction<d_pango_font_face_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_face_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_font_face_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_pango_font_face_is_synthesized(IntPtr raw);
		static d_pango_font_face_is_synthesized pango_font_face_is_synthesized = FuncLoader.LoadFunction<d_pango_font_face_is_synthesized>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_face_is_synthesized"));

		public bool IsSynthesized { 
			get {
				bool raw_ret = pango_font_face_is_synthesized(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_font_face_list_sizes(IntPtr raw, out int sizes, out int n_sizes);
		static d_pango_font_face_list_sizes pango_font_face_list_sizes = FuncLoader.LoadFunction<d_pango_font_face_list_sizes>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_font_face_list_sizes"));

		public void ListSizes(out int sizes, out int n_sizes) {
			pango_font_face_list_sizes(Handle, out sizes, out n_sizes);
		}

#endregion
	}
}
