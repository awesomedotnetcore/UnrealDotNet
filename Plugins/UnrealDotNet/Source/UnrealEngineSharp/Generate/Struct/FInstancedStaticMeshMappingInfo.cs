using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:100

namespace UnrealEngine
{
	public  partial class FInstancedStaticMeshMappingInfo : NativeStructWrapper
	{
		internal FInstancedStaticMeshMappingInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInstancedStaticMeshMappingInfo() :
			base(E_CreateStruct_FInstancedStaticMeshMappingInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshMappingInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FInstancedStaticMeshMappingInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FInstancedStaticMeshMappingInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInstancedStaticMeshMappingInfo(Adress, false);
		}}}
