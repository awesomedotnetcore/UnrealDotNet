using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\ReflectionCaptureComponent.h:66

namespace UnrealEngine
{
	public  partial class FReflectionCaptureFullHDR : NativeStructWrapper
	{
		internal FReflectionCaptureFullHDR(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FReflectionCaptureFullHDR() :
			base(E_CreateStruct_FReflectionCaptureFullHDR(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FReflectionCaptureFullHDR();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FReflectionCaptureFullHDR_CubemapSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FReflectionCaptureFullHDR_CubemapSize_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FReflectionCaptureFullHDR_HasValidData(IntPtr Self);
		
		#endregion
		
		#region Property
		public int CubemapSize
		{
			get => E_PROP_FReflectionCaptureFullHDR_CubemapSize_GET(NativePointer);
			set => E_PROP_FReflectionCaptureFullHDR_CubemapSize_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool HasValidData()
			=> E_FReflectionCaptureFullHDR_HasValidData(this);
		
		#endregion
		
		public static implicit operator IntPtr(FReflectionCaptureFullHDR Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FReflectionCaptureFullHDR(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FReflectionCaptureFullHDR(Adress, false);
		}}}
