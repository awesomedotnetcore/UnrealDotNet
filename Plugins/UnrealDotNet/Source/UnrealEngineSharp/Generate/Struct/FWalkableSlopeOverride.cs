using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3172

namespace UnrealEngine
{
	public  partial class FWalkableSlopeOverride : NativeStructWrapper
	{
		internal FWalkableSlopeOverride(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FWalkableSlopeOverride() :
			base(E_CreateStruct_FWalkableSlopeOverride(), false)
		{
		}

		public FWalkableSlopeOverride(EWalkableSlopeBehavior NewSlopeBehavior, float NewSlopeAngle) :
			base(E_CreateStruct_FWalkableSlopeOverride_EWalkableSlopeBehavior_float((byte)NewSlopeBehavior, NewSlopeAngle), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWalkableSlopeOverride();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWalkableSlopeOverride_EWalkableSlopeBehavior_float(byte NewSlopeBehavior, float NewSlopeAngle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FWalkableSlopeOverride_GetWalkableSlopeAngle(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FWalkableSlopeOverride_GetWalkableSlopeBehavior(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FWalkableSlopeOverride_ModifyWalkableFloorZ(IntPtr Self, float InWalkableFloorZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FWalkableSlopeOverride_SetWalkableSlopeAngle(IntPtr Self, float NewSlopeAngle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FWalkableSlopeOverride_SetWalkableSlopeBehavior(IntPtr Self, byte NewSlopeBehavior);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Override walkable slope angle (in degrees), applying the rules of the Walkable Slope Behavior. </para>
		/// <para>@see GetWalkableSlopeAngle(), SetWalkableSlopeAngle() </para>
		/// </summary>
		public float WalkableSlopeAngle
		{
			get => E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_GET(NativePointer);
			set => E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetWalkableSlopeAngle()
			=> E_FWalkableSlopeOverride_GetWalkableSlopeAngle(this);
		
		public EWalkableSlopeBehavior GetWalkableSlopeBehavior()
			=> (EWalkableSlopeBehavior)E_FWalkableSlopeOverride_GetWalkableSlopeBehavior(this);
		
		public float ModifyWalkableFloorZ(float InWalkableFloorZ)
			=> E_FWalkableSlopeOverride_ModifyWalkableFloorZ(this, InWalkableFloorZ);
		
		public void SetWalkableSlopeAngle(float NewSlopeAngle)
			=> E_FWalkableSlopeOverride_SetWalkableSlopeAngle(this, NewSlopeAngle);
		
		public void SetWalkableSlopeBehavior(EWalkableSlopeBehavior NewSlopeBehavior)
			=> E_FWalkableSlopeOverride_SetWalkableSlopeBehavior(this, (byte)NewSlopeBehavior);
		
		#endregion
		
		public static implicit operator IntPtr(FWalkableSlopeOverride Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FWalkableSlopeOverride(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWalkableSlopeOverride(Adress, false);
		}}}
