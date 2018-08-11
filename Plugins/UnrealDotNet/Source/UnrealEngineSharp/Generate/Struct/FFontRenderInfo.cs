using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3802

namespace UnrealEngine
{
	public  partial class FFontRenderInfo : NativeStructWrapper
	{
		internal FFontRenderInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFontRenderInfo() :
			base(E_CreateStruct_FFontRenderInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFontRenderInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FFontRenderInfo_GlowInfo_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFontRenderInfo_GlowInfo_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>depth field glow parameters (only usable if font was imported with a depth field) </para>
		/// </summary>
		public FDepthFieldGlowInfo GlowInfo
		{
			get => E_PROP_FFontRenderInfo_GlowInfo_GET(NativePointer);
			set => E_PROP_FFontRenderInfo_GlowInfo_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FFontRenderInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFontRenderInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFontRenderInfo(Adress, false);
		}}}
