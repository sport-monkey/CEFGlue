//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_print_handler_t
    {
        internal cef_base_t _base;
        internal IntPtr _on_print_settings;
        internal IntPtr _on_print_dialog;
        internal IntPtr _on_print_job;
        internal IntPtr _on_print_reset;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_print_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_print_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_print_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_print_settings_delegate(cef_print_handler_t* self, cef_print_settings_t* settings, int get_defaults);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_print_dialog_delegate(cef_print_handler_t* self, int has_selection, cef_print_dialog_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_print_job_delegate(cef_print_handler_t* self, cef_string_t* document_name, cef_string_t* pdf_file_path, cef_print_job_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_print_reset_delegate(cef_print_handler_t* self);
        
        private static int _sizeof;
        
        static cef_print_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_print_handler_t));
        }
        
        internal static cef_print_handler_t* Alloc()
        {
            var ptr = (cef_print_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_print_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_print_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
