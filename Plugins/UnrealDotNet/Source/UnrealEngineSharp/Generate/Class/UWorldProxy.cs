// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\World.h:81

namespace UnrealEngine
{
	public  partial class UWorldProxy : NativeWrapper
	{
		public UWorldProxy(IntPtr Adress)
			: base(Adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorldProxy_GetReference(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public UWorld GetReference()
			=> E_UWorldProxy_GetReference(this);
		
		#endregion
		
		public static implicit operator IntPtr(UWorldProxy self)
		{
			return self.NativePointer;
		}

		public static implicit operator UWorldProxy(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UWorldProxy>(PtrDesc);
		}}}
