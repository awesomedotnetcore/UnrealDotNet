// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:58

namespace UnrealEngine
{
	public  partial class FAnimationEvaluationContext : NativeStructWrapper
	{
		internal FAnimationEvaluationContext(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAnimationEvaluationContext() :
			base(E_CreateStruct_FAnimationEvaluationContext(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAnimationEvaluationContext();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FAnimationEvaluationContext_bDoEvaluation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimationEvaluationContext_bDoEvaluation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FAnimationEvaluationContext_bDoInterpolation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimationEvaluationContext_bDoInterpolation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FAnimationEvaluationContext_BoneSpaceTransforms_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimationEvaluationContext_BoneSpaceTransforms_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FAnimationEvaluationContext_ComponentSpaceTransforms_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimationEvaluationContext_ComponentSpaceTransforms_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAnimationEvaluationContext_RootBoneTranslation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimationEvaluationContext_RootBoneTranslation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAnimationEvaluationContext_Clear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAnimationEvaluationContext_Copy(IntPtr self, IntPtr other);
		
		#endregion
		
		#region Property
		public bool bDoEvaluation
		{
			get => E_PROP_FAnimationEvaluationContext_bDoEvaluation_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_bDoEvaluation_SET(NativePointer, value);
		}

		public bool bDoInterpolation
		{
			get => E_PROP_FAnimationEvaluationContext_bDoInterpolation_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_bDoInterpolation_SET(NativePointer, value);
		}

		public bool bDuplicateToCacheBones
		{
			get => E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_SET(NativePointer, value);
		}

		public bool bDuplicateToCacheCurve
		{
			get => E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_SET(NativePointer, value);
		}

		public TArray<FTransform> BoneSpaceTransforms
		{
			get => E_PROP_FAnimationEvaluationContext_BoneSpaceTransforms_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_BoneSpaceTransforms_SET(NativePointer, value);
		}

		public TArray<FTransform> ComponentSpaceTransforms
		{
			get => E_PROP_FAnimationEvaluationContext_ComponentSpaceTransforms_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_ComponentSpaceTransforms_SET(NativePointer, value);
		}

		public FVector RootBoneTranslation
		{
			get => E_PROP_FAnimationEvaluationContext_RootBoneTranslation_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_RootBoneTranslation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Clear()
			=> E_FAnimationEvaluationContext_Clear(this);
		
		public void Copy(FAnimationEvaluationContext other)
			=> E_FAnimationEvaluationContext_Copy(this, other);
		
		#endregion
		
		public static implicit operator IntPtr(FAnimationEvaluationContext self)
		{
			return self.NativePointer;
		}

		public static implicit operator FAnimationEvaluationContext(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAnimationEvaluationContext(Adress, false);
		}}}
