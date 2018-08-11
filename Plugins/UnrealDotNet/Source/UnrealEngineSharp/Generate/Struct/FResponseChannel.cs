using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:839

namespace UnrealEngine
{
	public  partial class FResponseChannel : NativeStructWrapper
	{
		internal FResponseChannel(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FResponseChannel() :
			base(E_CreateStruct_FResponseChannel(), false)
		{
		}

		public FResponseChannel(string InChannel, ECollisionResponse InResponse) :
			base(E_CreateStruct_FResponseChannel_FName_ECollisionResponse(InChannel, (byte)InResponse), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FResponseChannel();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FResponseChannel_FName_ECollisionResponse(string InChannel, byte InResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FResponseChannel_Channel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FResponseChannel_Channel_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>This should match DisplayName of ECollisionChannel </para>
		/// <para>Meta data of custom channels can be used as well </para>
		/// </summary>
		public string Channel
		{
			get => E_PROP_FResponseChannel_Channel_GET(NativePointer);
			set => E_PROP_FResponseChannel_Channel_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FResponseChannel Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FResponseChannel(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FResponseChannel(Adress, false);
		}}}
