using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:127

namespace UnrealEngine
{
	public  partial class FDetachmentTransformRules : NativeStructWrapper
	{
		internal FDetachmentTransformRules(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDetachmentTransformRules(EDetachmentRule InRule, bool bInCallModify) :
			base(E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_bool((byte)InRule, bInCallModify), false)
		{
		}

		public FDetachmentTransformRules(EDetachmentRule InLocationRule, EDetachmentRule InRotationRule, EDetachmentRule InScaleRule, bool bInCallModify) :
			base(E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_EDetachmentRule_EDetachmentRule_bool((byte)InLocationRule, (byte)InRotationRule, (byte)InScaleRule, bInCallModify), false)
		{
		}

		public FDetachmentTransformRules(FAttachmentTransformRules AttachmentRules, bool bInCallModify) :
			base(E_CreateStruct_FDetachmentTransformRules_FAttachmentTransformRules_bool(AttachmentRules, bInCallModify), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_bool(byte InRule, bool bInCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDetachmentTransformRules_EDetachmentRule_EDetachmentRule_EDetachmentRule_bool(byte InLocationRule, byte InRotationRule, byte InScaleRule, bool bInCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDetachmentTransformRules_FAttachmentTransformRules_bool(IntPtr AttachmentRules, bool bInCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FDetachmentTransformRules_bCallModify_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDetachmentTransformRules_bCallModify_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDetachmentTransformRules_KeepRelativeTransform_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDetachmentTransformRules_KeepWorldTransform_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FDetachmentTransformRules_LocationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDetachmentTransformRules_LocationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FDetachmentTransformRules_RotationRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDetachmentTransformRules_RotationRule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FDetachmentTransformRules_ScaleRule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDetachmentTransformRules_ScaleRule_SET(IntPtr Ptr, byte Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Whether to call Modify() on the components concerned when detaching </para>
		/// </summary>
		public bool bCallModify
		{
			get => E_PROP_FDetachmentTransformRules_bCallModify_GET(NativePointer);
			set => E_PROP_FDetachmentTransformRules_bCallModify_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Various preset detachment rules </para>
		/// </summary>
		public static FDetachmentTransformRules KeepRelativeTransform
		{
			get => E_PROP_FDetachmentTransformRules_KeepRelativeTransform_GET();
		}

		public static FDetachmentTransformRules KeepWorldTransform
		{
			get => E_PROP_FDetachmentTransformRules_KeepWorldTransform_GET();
		}

		
		/// <summary>
		/// <para>The rule to apply to location when detaching </para>
		/// </summary>
		public EDetachmentRule LocationRule
		{
			get => (EDetachmentRule)E_PROP_FDetachmentTransformRules_LocationRule_GET(NativePointer);
			set => E_PROP_FDetachmentTransformRules_LocationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>The rule to apply to rotation when detaching </para>
		/// </summary>
		public EDetachmentRule RotationRule
		{
			get => (EDetachmentRule)E_PROP_FDetachmentTransformRules_RotationRule_GET(NativePointer);
			set => E_PROP_FDetachmentTransformRules_RotationRule_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>The rule to apply to scale when detaching </para>
		/// </summary>
		public EDetachmentRule ScaleRule
		{
			get => (EDetachmentRule)E_PROP_FDetachmentTransformRules_ScaleRule_GET(NativePointer);
			set => E_PROP_FDetachmentTransformRules_ScaleRule_SET(NativePointer, (byte)value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDetachmentTransformRules Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDetachmentTransformRules(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDetachmentTransformRules(Adress, false);
		}}}
