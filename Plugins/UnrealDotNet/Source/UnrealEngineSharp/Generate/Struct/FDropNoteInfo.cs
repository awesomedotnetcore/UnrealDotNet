// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:471

namespace UnrealEngine
{
	public  partial class FDropNoteInfo : NativeStructWrapper
	{
		internal FDropNoteInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDropNoteInfo() :
			base(E_CreateStruct_FDropNoteInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDropNoteInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FDropNoteInfo_Comment_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDropNoteInfo_Comment_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDropNoteInfo_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDropNoteInfo_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDropNoteInfo_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDropNoteInfo_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public string Comment
		{
			get => E_PROP_FDropNoteInfo_Comment_GET(NativePointer);
			set => E_PROP_FDropNoteInfo_Comment_SET(NativePointer, value);
		}

		public FVector Location
		{
			get => E_PROP_FDropNoteInfo_Location_GET(NativePointer);
			set => E_PROP_FDropNoteInfo_Location_SET(NativePointer, value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FDropNoteInfo_Rotation_GET(NativePointer);
			set => E_PROP_FDropNoteInfo_Rotation_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDropNoteInfo self)
		{
			return self.NativePointer;
		}

		public static implicit operator FDropNoteInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDropNoteInfo(Adress, false);
		}}}
