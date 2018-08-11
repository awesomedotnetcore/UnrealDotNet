using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2210

namespace UnrealEngine
{
	public  partial class FAnimSlotInfo : NativeStructWrapper
	{
		internal FAnimSlotInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAnimSlotInfo() :
			base(E_CreateStruct_FAnimSlotInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAnimSlotInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FAnimSlotInfo_SlotName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimSlotInfo_SlotName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string SlotName
		{
			get => E_PROP_FAnimSlotInfo_SlotName_GET(NativePointer);
			set => E_PROP_FAnimSlotInfo_SlotName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FAnimSlotInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAnimSlotInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAnimSlotInfo(Adress, false);
		}}}
