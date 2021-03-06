// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3641

namespace UnrealEngine
{
	public  partial class FDebugFloatHistory : NativeStructWrapper
	{
		internal FDebugFloatHistory(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDebugFloatHistory() :
			base(E_CreateStruct_FDebugFloatHistory(), false)
		{
		}

		public FDebugFloatHistory(float inMaxSamples, float inMinValue, float inMaxValue, bool inbAutoAdjustMinMax) :
			base(E_CreateStruct_FDebugFloatHistory_float_float_float_bool(inMaxSamples, inMinValue, inMaxValue, inbAutoAdjustMinMax), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDebugFloatHistory();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDebugFloatHistory_float_float_float_bool(float inMaxSamples, float inMinValue, float inMaxValue, bool inbAutoAdjustMinMax);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FDebugFloatHistory_bAutoAdjustMinMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugFloatHistory_bAutoAdjustMinMax_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugFloatHistory_MaxSamples_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugFloatHistory_MaxSamples_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugFloatHistory_MaxValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugFloatHistory_MaxValue_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FDebugFloatHistory_MinValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDebugFloatHistory_MinValue_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FDebugFloatHistory_AddSample(IntPtr self, float floatValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FDebugFloatHistory_GetMaxValue(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FDebugFloatHistory_GetMinMaxRange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FDebugFloatHistory_GetMinValue(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FDebugFloatHistory_GetNumSamples(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_FDebugFloatHistory_GetSamples(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Auto adjust Min/Max as new values are recorded? </para>
		/// </summary>
		public bool bAutoAdjustMinMax
		{
			get => E_PROP_FDebugFloatHistory_bAutoAdjustMinMax_GET(NativePointer);
			set => E_PROP_FDebugFloatHistory_bAutoAdjustMinMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max Samples to record. </para>
		/// </summary>
		public float MaxSamples
		{
			get => E_PROP_FDebugFloatHistory_MaxSamples_GET(NativePointer);
			set => E_PROP_FDebugFloatHistory_MaxSamples_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max value to record. </para>
		/// </summary>
		public float MaxValue
		{
			get => E_PROP_FDebugFloatHistory_MaxValue_GET(NativePointer);
			set => E_PROP_FDebugFloatHistory_MaxValue_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Min value to record. </para>
		/// </summary>
		public float MinValue
		{
			get => E_PROP_FDebugFloatHistory_MinValue_GET(NativePointer);
			set => E_PROP_FDebugFloatHistory_MinValue_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Record a new Sample. </para>
		/// <para>if bAutoAdjustMinMax is true, this new value will potentially adjust those bounds. </para>
		/// <para>Otherwise value will be clamped before being recorded. </para>
		/// <para>If MaxSamples is exceeded, old values will be deleted. </para>
		/// <param name="FloatValue">new sample to record. </param>
		/// </summary>
		public void AddSample(float floatValue)
			=> E_FDebugFloatHistory_AddSample(this, floatValue);
		
		
		/// <summary>
		/// <para>Max value. This could be either the max value recorded or max value allowed depending on 'bAutoAdjustMinMax'. </para>
		/// </summary>
		public float GetMaxValue()
			=> E_FDebugFloatHistory_GetMaxValue(this);
		
		
		/// <summary>
		/// <para>Range between Min and Max values </para>
		/// </summary>
		public float GetMinMaxRange()
			=> E_FDebugFloatHistory_GetMinMaxRange(this);
		
		
		/// <summary>
		/// <para>Min value. This could either be the min value recorded or min value allowed depending on 'bAutoAdjustMinMax'. </para>
		/// </summary>
		public float GetMinValue()
			=> E_FDebugFloatHistory_GetMinValue(this);
		
		
		/// <summary>
		/// <para>Number of Samples currently recorded </para>
		/// </summary>
		public int GetNumSamples()
			=> E_FDebugFloatHistory_GetNumSamples(this);
		
		
		/// <summary>
		/// <para>Read access to Samples array </para>
		/// </summary>
		public TArray<float> GetSamples()
			=> E_FDebugFloatHistory_GetSamples(this);
		
		#endregion
		
		public static implicit operator IntPtr(FDebugFloatHistory self)
		{
			return self.NativePointer;
		}

		public static implicit operator FDebugFloatHistory(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDebugFloatHistory(Adress, false);
		}}}
