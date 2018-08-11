using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

namespace UnrealEngine
{
	public  partial class ACharacter : APawn
	{
		public ACharacter(IntPtr Adress)
			: base(Adress)
		{
		}

		public ACharacter(UObject Parent = null, string Name = "Character")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ACharacter(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ACharacter(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_ACharacter_CapsuleComponentName_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_ACharacter_CharacterMovementComponentName_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_CrouchedEyeHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_CrouchedEyeHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_ACharacter_JumpCurrentCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpCurrentCount_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_JumpForceTimeRemaining_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpForceTimeRemaining_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_JumpKeyHoldTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpKeyHoldTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_ACharacter_JumpMaxCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpMaxCount_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_JumpMaxHoldTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpMaxHoldTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_ACharacter_LandedDelegate(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_ACharacter_LandedDelegate(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_ACharacter_MeshComponentName_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_ACharacter_MovementModeChangedDelegate(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_ACharacter_MovementModeChangedDelegate(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_ACharacter_OnCharacterMovementUpdated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_ACharacter_OnCharacterMovementUpdated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_ACharacter_OnReachedJumpApex(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_ACharacter_OnReachedJumpApex(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_ProxyJumpForceStartedTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_ProxyJumpForceStartedTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_ACharacter_RepRootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_RepRootMotion_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ApplyDamageMomentum(IntPtr Self, float DamageTaken, IntPtr DamageEvent, IntPtr PawnInstigator, IntPtr DamageCauser);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_BaseChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_CacheInitialMeshOffset(IntPtr Self, IntPtr MeshRelativeLocation, IntPtr MeshRelativeRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanCrouch(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanJump(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanJumpInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanJumpInternal_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_CheckJumpInput(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClearJumpInput(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAckGoodMove(IntPtr Self, float TimeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAckGoodMove_Implementation(IntPtr Self, float TimeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAdjustPosition(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewVel, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAdjustPosition_Implementation(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewVel, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatFly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatFly_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatGhost(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatGhost_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatWalk(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatWalk_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientVeryShortAdjustPosition(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientVeryShortAdjustPosition_Implementation(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Crouch(IntPtr Self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Falling(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetAnimRootMotionTranslationScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseRotationOffset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseRotationOffsetRotator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseTranslationOffset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetCapsuleComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetCharacterMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetJumpMaxHoldTime(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetMesh(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_ACharacter_GetReplicatedMovementMode(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsJumpProvidingForce(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsPlayingNetworkedRootMotionMontage(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsPlayingRootMotion(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Jump(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_OnEndCrouch(IntPtr Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_OnMovementModeChanged(IntPtr Self, byte PrevMovementMode, byte NewMovementMode, byte PrevCustomMode, byte NewCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_OnStartCrouch(IntPtr Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_UpdateCustomMovement(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Landed(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_LaunchCharacter(IntPtr Self, IntPtr LaunchVelocity, bool bXYOverride, bool bZOverride);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_MoveBlockedBy(IntPtr Self, IntPtr Impact);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyActorBeginOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyActorEndOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyJumpApex(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnEndCrouch(IntPtr Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnJumped(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnJumped_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnLanded(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnLaunched(IntPtr Self, IntPtr LaunchVelocity, bool bXYOverride, bool bZOverride);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnMovementModeChanged(IntPtr Self, byte PrevMovementMode, byte PreviousCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_IsCrouched(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_ReplicatedBasedMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_RootMotion(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnStartCrouch(IntPtr Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnUpdateSimulatedPosition(IntPtr Self, IntPtr OldLocation, IntPtr OldRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnWalkingOffLedge(IntPtr Self, IntPtr PreviousFloorImpactNormal, IntPtr PreviousFloorContactNormal, IntPtr PreviousLocation, float TimeDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnWalkingOffLedge_Implementation(IntPtr Self, IntPtr PreviousFloorImpactNormal, IntPtr PreviousFloorContactNormal, IntPtr PreviousLocation, float TimeDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ResetJumpState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_RestoreReplicatedMove(IntPtr Self, IntPtr RootMotionRepMove);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RootMotionDebugClientPrintOnScreen(IntPtr Self, string InString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RootMotionDebugClientPrintOnScreen_Implementation(IntPtr Self, string InString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SaveRelativeBasedMovement(IntPtr Self, IntPtr NewRelativeLocation, IntPtr NewRotation, bool bRelativeRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetAnimRootMotionTranslationScale(IntPtr Self, float InAnimRootMotionTranslationScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetBase(IntPtr Self, IntPtr NewBase, string BoneName, bool bNotifyActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_ShouldNotifyLanded(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SimulatedRootMotionPositionFixup(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_StopJumping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_UnCrouch(IntPtr Self, bool bClientSimulation);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Name of the CapsuleComponent. </para>
		/// </summary>
		public static string CapsuleComponentName
		{
			get => E_PROP_ACharacter_CapsuleComponentName_GET();
		}

		
		/// <summary>
		/// <para>Name of the CharacterMovement component. Use this name if you want to use a different class (with ObjectInitializer.SetDefaultSubobjectClass). </para>
		/// </summary>
		public static string CharacterMovementComponentName
		{
			get => E_PROP_ACharacter_CharacterMovementComponentName_GET();
		}

		
		/// <summary>
		/// <para>Default crouched eye height </para>
		/// </summary>
		public float CrouchedEyeHeight
		{
			get => E_PROP_ACharacter_CrouchedEyeHeight_GET(NativePointer);
			set => E_PROP_ACharacter_CrouchedEyeHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Tracks the current number of jumps performed. </para>
		/// <para>This is incremented in CheckJumpInput, used in CanJump_Implementation, and reset in OnMovementModeChanged. </para>
		/// <para>When providing overrides for these methods, it's recommended to either manually </para>
		/// <para>increment / reset this value, or call the Super:: method. </para>
		/// </summary>
		public int JumpCurrentCount
		{
			get => E_PROP_ACharacter_JumpCurrentCount_GET(NativePointer);
			set => E_PROP_ACharacter_JumpCurrentCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Amount of jump force time remaining, if JumpMaxHoldTime > 0. </para>
		/// </summary>
		public float JumpForceTimeRemaining
		{
			get => E_PROP_ACharacter_JumpForceTimeRemaining_GET(NativePointer);
			set => E_PROP_ACharacter_JumpForceTimeRemaining_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Jump key Held Time. </para>
		/// <para>This is the time that the player has held the jump key, in seconds. </para>
		/// </summary>
		public float JumpKeyHoldTime
		{
			get => E_PROP_ACharacter_JumpKeyHoldTime_GET(NativePointer);
			set => E_PROP_ACharacter_JumpKeyHoldTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The max number of jumps the character can perform. </para>
		/// <para>Note that if JumpMaxHoldTime is non zero and StopJumping is not called, the player </para>
		/// <para>may be able to perform and unlimited number of jumps. Therefore it is usually </para>
		/// <para>best to call StopJumping() when jump input has ceased (such as a button up event). </para>
		/// </summary>
		public int JumpMaxCount
		{
			get => E_PROP_ACharacter_JumpMaxCount_GET(NativePointer);
			set => E_PROP_ACharacter_JumpMaxCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The max time the jump key can be held. </para>
		/// <para>Note that if StopJumping() is not called before the max jump hold time is reached, </para>
		/// <para>then the character will carry on receiving vertical velocity. Therefore it is usually </para>
		/// <para>best to call StopJumping() when jump input has ceased (such as a button up event). </para>
		/// </summary>
		public float JumpMaxHoldTime
		{
			get => E_PROP_ACharacter_JumpMaxHoldTime_GET(NativePointer);
			set => E_PROP_ACharacter_JumpMaxHoldTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Name of the MeshComponent. Use this name if you want to prevent creation of the component (with ObjectInitializer.DoNotCreateDefaultSubobject). </para>
		/// </summary>
		public static string MeshComponentName
		{
			get => E_PROP_ACharacter_MeshComponentName_GET();
		}

		
		/// <summary>
		/// <para>Track last time a jump force started for a proxy. </para>
		/// </summary>
		public float ProxyJumpForceStartedTime
		{
			get => E_PROP_ACharacter_ProxyJumpForceStartedTime_GET(NativePointer);
			set => E_PROP_ACharacter_ProxyJumpForceStartedTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Replicated Root Motion montage </para>
		/// </summary>
		public FRepRootMotionMontage RepRootMotion
		{
			get => E_PROP_ACharacter_RepRootMotion_GET(NativePointer);
			set => E_PROP_ACharacter_RepRootMotion_SET(NativePointer, value);
		}

		#endregion
		
		#region Events
		
		/// <summary>
		/// <para>Called upon landing when falling, to perform actions based on the Hit result. </para>
		/// <para>Note that movement mode is still "Falling" during this event. Current Velocity value is the velocity at the time of landing. </para>
		/// <para>Consider OnMovementModeChanged() as well, as that can be used once the movement mode changes to the new mode (most likely Walking). </para>
		/// <param name="Hit">Result describing the landing that resulted in a valid landing spot. </param>
		/// <para>@see OnMovementModeChanged() </para>
		/// </summary>
		public event FLandedSignature LandedDelegate
		{
			add
			{
				E_EVENT_ADD_ACharacter_LandedDelegate(NativePointer);
				_Event_LandedDelegate += value;
			}

			remove
			{
				E_EVENT_DEL_ACharacter_LandedDelegate(NativePointer);
				_Event_LandedDelegate -= value;
			}

		}

		private event FLandedSignature _Event_LandedDelegate;
		
		internal void InvokeEvent_LandedDelegate(FHitResult Hit)
		{
			_Event_LandedDelegate?.Invoke(Hit);
		}

		
		/// <summary>
		/// <para>Multicast delegate for MovementMode changing. </para>
		/// </summary>
		public event FMovementModeChangedSignature MovementModeChangedDelegate
		{
			add
			{
				E_EVENT_ADD_ACharacter_MovementModeChangedDelegate(NativePointer);
				_Event_MovementModeChangedDelegate += value;
			}

			remove
			{
				E_EVENT_DEL_ACharacter_MovementModeChangedDelegate(NativePointer);
				_Event_MovementModeChangedDelegate -= value;
			}

		}

		private event FMovementModeChangedSignature _Event_MovementModeChangedDelegate;
		
		internal void InvokeEvent_MovementModeChangedDelegate(ObjectPointerDescription Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			_Event_MovementModeChangedDelegate?.Invoke(Character, PrevMovementMode, PreviousCustomMode);
		}

		
		/// <summary>
		/// <para>Event triggered at the end of a CharacterMovementComponent movement update. </para>
		/// <para>This is the preferred event to use rather than the Tick event when performing custom updates to CharacterMovement properties based on the current state. </para>
		/// <para>This is mainly due to the nature of network updates, where client corrections in position from the server can cause multiple iterations of a movement update, </para>
		/// <para>which allows this event to update as well, while a Tick event would not. </para>
		/// <param name="DeltaSeconds">Delta time in seconds for this update </param>
		/// <param name="InitialLocation">Location at the start of the update. May be different than the current location if movement occurred. </param>
		/// <param name="InitialVelocity">Velocity at the start of the update. May be different than the current velocity. </param>
		/// </summary>
		public event FCharacterMovementUpdatedSignature OnCharacterMovementUpdated
		{
			add
			{
				E_EVENT_ADD_ACharacter_OnCharacterMovementUpdated(NativePointer);
				_Event_OnCharacterMovementUpdated += value;
			}

			remove
			{
				E_EVENT_DEL_ACharacter_OnCharacterMovementUpdated(NativePointer);
				_Event_OnCharacterMovementUpdated -= value;
			}

		}

		private event FCharacterMovementUpdatedSignature _Event_OnCharacterMovementUpdated;
		
		internal void InvokeEvent_OnCharacterMovementUpdated(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
		{
			_Event_OnCharacterMovementUpdated?.Invoke(DeltaSeconds, OldLocation, OldVelocity);
		}

		
		/// <summary>
		/// <para>Broadcast when Character's jump reaches its apex. Needs CharacterMovement->bNotifyApex = true </para>
		/// </summary>
		public event FCharacterReachedApexSignature OnReachedJumpApex
		{
			add
			{
				E_EVENT_ADD_ACharacter_OnReachedJumpApex(NativePointer);
				_Event_OnReachedJumpApex += value;
			}

			remove
			{
				E_EVENT_DEL_ACharacter_OnReachedJumpApex(NativePointer);
				_Event_OnReachedJumpApex -= value;
			}

		}

		private event FCharacterReachedApexSignature _Event_OnReachedJumpApex;
		
		internal void InvokeEvent_OnReachedJumpApex()
		{
			_Event_OnReachedJumpApex?.Invoke();
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Apply momentum caused by damage. </para>
		/// </summary>
		public virtual void ApplyDamageMomentum(float DamageTaken, FDamageEvent DamageEvent, APawn PawnInstigator, AActor DamageCauser)
			=> E_ACharacter_ApplyDamageMomentum(this, DamageTaken, DamageEvent, PawnInstigator, DamageCauser);
		
		
		/// <summary>
		/// <para>Event called after actor's base changes (if SetBase was requested to notify us with bNotifyPawn). </para>
		/// </summary>
		protected virtual void BaseChange()
			=> E_ACharacter_BaseChange(this);
		
		
		/// <summary>
		/// <para>Cache mesh offset from capsule. This is used as the target for network smoothing interpolation, when the mesh is offset with lagged smoothing. </para>
		/// <para>This is automatically called during initialization; call this at runtime if you intend to change the default mesh offset from the capsule. </para>
		/// <para>@see GetBaseTranslationOffset(), GetBaseRotationOffset() </para>
		/// </summary>
		public virtual void CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
			=> E_ACharacter_CacheInitialMeshOffset(this, MeshRelativeLocation, MeshRelativeRotation);
		
		
		/// <summary>
		/// <return>true if this character is currently able to crouch (and is not currently crouched) </return>
		/// </summary>
		public virtual bool CanCrouch()
			=> E_ACharacter_CanCrouch(this);
		
		
		/// <summary>
		/// <para>Check if the character can jump in the current state. </para>
		/// <para>The default implementation may be overridden or extended by implementing the custom CanJump event in Blueprints. </para>
		/// <para>@Return Whether the character can jump in the current state. </para>
		/// </summary>
		public bool CanJump()
			=> E_ACharacter_CanJump(this);
		
		
		/// <summary>
		/// <para>Customizable event to check if the character can jump in the current state. </para>
		/// <para>Default implementation returns true if the character is on the ground and not crouching, </para>
		/// <para>has a valid CharacterMovementComponent and CanEverJump() returns true. </para>
		/// <para>Default implementation also allows for 'hold to jump higher' functionality: </para>
		/// <para>As well as returning true when on the ground, it also returns true when GetMaxJumpTime is more </para>
		/// <para>than zero and IsJumping returns true. </para>
		/// <para>@Return Whether the character can jump in the current state. </para>
		/// </summary>
		protected bool CanJumpInternal()
			=> E_ACharacter_CanJumpInternal(this);
		
		protected virtual bool CanJumpInternal_Implementation()
			=> E_ACharacter_CanJumpInternal_Implementation(this);
		
		
		/// <summary>
		/// <para>Trigger jump if jump button has been pressed. </para>
		/// </summary>
		public virtual void CheckJumpInput(float DeltaTime)
			=> E_ACharacter_CheckJumpInput(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Update jump input state after having checked input. </para>
		/// </summary>
		public virtual void ClearJumpInput(float DeltaTime)
			=> E_ACharacter_ClearJumpInput(this, DeltaTime);
		
		public void ClientAckGoodMove(float TimeStamp)
			=> E_ACharacter_ClientAckGoodMove(this, TimeStamp);
		
		public void ClientAckGoodMove_Implementation(float TimeStamp)
			=> E_ACharacter_ClientAckGoodMove_Implementation(this, TimeStamp);
		
		public void ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_ACharacter_ClientAdjustPosition(this, TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		public void ClientAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_ACharacter_ClientAdjustPosition_Implementation(this, TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		public void ClientCheatFly()
			=> E_ACharacter_ClientCheatFly(this);
		
		public virtual void ClientCheatFly_Implementation()
			=> E_ACharacter_ClientCheatFly_Implementation(this);
		
		public void ClientCheatGhost()
			=> E_ACharacter_ClientCheatGhost(this);
		
		public virtual void ClientCheatGhost_Implementation()
			=> E_ACharacter_ClientCheatGhost_Implementation(this);
		
		public void ClientCheatWalk()
			=> E_ACharacter_ClientCheatWalk(this);
		
		public virtual void ClientCheatWalk_Implementation()
			=> E_ACharacter_ClientCheatWalk_Implementation(this);
		
		public void ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_ACharacter_ClientVeryShortAdjustPosition(this, TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		public void ClientVeryShortAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_ACharacter_ClientVeryShortAdjustPosition_Implementation(this, TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		
		/// <summary>
		/// <para>Request the character to start crouching. The request is processed on the next update of the CharacterMovementComponent. </para>
		/// <para>@see OnStartCrouch </para>
		/// <para>@see IsCrouched </para>
		/// <para>@see CharacterMovement->WantsToCrouch </para>
		/// </summary>
		public virtual void Crouch(bool bClientSimulation)
			=> E_ACharacter_Crouch(this, bClientSimulation);
		
		
		/// <summary>
		/// <para>Called when the character's movement enters falling </para>
		/// </summary>
		public virtual void Falling()
			=> E_ACharacter_Falling(this);
		
		
		/// <summary>
		/// <para>Returns current value of AnimRootMotionScale </para>
		/// </summary>
		public float GetAnimRootMotionTranslationScale()
			=> E_ACharacter_GetAnimRootMotionTranslationScale(this);
		
		
		/// <summary>
		/// <para>Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation. </para>
		/// </summary>
		public virtual FQuat GetBaseRotationOffset()
			=> E_ACharacter_GetBaseRotationOffset(this);
		
		
		/// <summary>
		/// <para>Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation. </para>
		/// </summary>
		public FRotator GetBaseRotationOffsetRotator()
			=> E_ACharacter_GetBaseRotationOffsetRotator(this);
		
		
		/// <summary>
		/// <para>Get the saved translation offset of mesh. This is how much extra offset is applied from the center of the capsule. </para>
		/// </summary>
		public FVector GetBaseTranslationOffset()
			=> E_ACharacter_GetBaseTranslationOffset(this);
		
		
		/// <summary>
		/// <para>Returns CapsuleComponent subobject </para>
		/// </summary>
		public UCapsuleComponent GetCapsuleComponent()
			=> E_ACharacter_GetCapsuleComponent(this);
		
		
		/// <summary>
		/// <para>Returns CharacterMovement subobject </para>
		/// </summary>
		public UCharacterMovementComponent GetCharacterMovement()
			=> E_ACharacter_GetCharacterMovement(this);
		
		
		/// <summary>
		/// <para>Get the maximum jump time for the character. </para>
		/// <para>Note that if StopJumping() is not called before the max jump hold time is reached, </para>
		/// <para>then the character will carry on receiving vertical velocity. Therefore it is usually </para>
		/// <para>best to call StopJumping() when jump input has ceased (such as a button up event). </para>
		/// <return>Maximum jump time for the character </return>
		/// </summary>
		public virtual float GetJumpMaxHoldTime()
			=> E_ACharacter_GetJumpMaxHoldTime(this);
		
		
		/// <summary>
		/// <para>Returns Mesh subobject </para>
		/// </summary>
		public USkeletalMeshComponent GetMesh()
			=> E_ACharacter_GetMesh(this);
		
		
		/// <summary>
		/// <para>Returns ReplicatedMovementMode </para>
		/// </summary>
		public byte GetReplicatedMovementMode()
			=> E_ACharacter_GetReplicatedMovementMode(this);
		
		
		/// <summary>
		/// <para>Accessor for ReplicatedServerLastTransformUpdateTimeStamp. </para>
		/// </summary>
		public float GetReplicatedServerLastTransformUpdateTimeStamp()
			=> E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(this);
		
		
		/// <summary>
		/// <para>True if jump is actively providing a force, such as when the jump key is held and the time it has been held is less than JumpMaxHoldTime. </para>
		/// <para>@see CharacterMovement->IsFalling </para>
		/// </summary>
		public virtual bool IsJumpProvidingForce()
			=> E_ACharacter_IsJumpProvidingForce(this);
		
		
		/// <summary>
		/// <para>True if we are playing Root Motion right now, through a Montage with RootMotionMode == ERootMotionMode::RootMotionFromMontagesOnly. </para>
		/// <para>This means code path for networked root motion is enabled. </para>
		/// </summary>
		public bool IsPlayingNetworkedRootMotionMontage()
			=> E_ACharacter_IsPlayingNetworkedRootMotionMontage(this);
		
		
		/// <summary>
		/// <para>True if we are playing Root Motion right now </para>
		/// </summary>
		public bool IsPlayingRootMotion()
			=> E_ACharacter_IsPlayingRootMotion(this);
		
		
		/// <summary>
		/// <para>Make the character jump on the next update. </para>
		/// <para>If you want your character to jump according to the time that the jump key is held, </para>
		/// <para>then you can set JumpKeyHoldTime to some non-zero value. Make sure in this case to </para>
		/// <para>call StopJumping() when you want the jump's z-velocity to stop being applied (such </para>
		/// <para>as on a button up event), otherwise the character will carry on receiving the </para>
		/// <para>velocity until JumpKeyHoldTime is reached. </para>
		/// </summary>
		public virtual void Jump()
			=> E_ACharacter_Jump(this);
		
		
		/// <summary>
		/// <para>Event when Character stops crouching. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public void K2_OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
			=> E_ACharacter_K2_OnEndCrouch(this, HalfHeightAdjust, ScaledHalfHeightAdjust);
		
		
		/// <summary>
		/// <para>Called from CharacterMovementComponent to notify the character that the movement mode has changed. </para>
		/// <param name="PrevMovementMode">Movement mode before the change </param>
		/// <param name="NewMovementMode">New movement mode </param>
		/// <param name="PrevCustomMode">Custom mode before the change (applicable if PrevMovementMode is Custom) </param>
		/// <param name="NewCustomMode">New custom mode (applicable if NewMovementMode is Custom) </param>
		/// </summary>
		public void K2_OnMovementModeChanged(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
			=> E_ACharacter_K2_OnMovementModeChanged(this, (byte)PrevMovementMode, (byte)NewMovementMode, PrevCustomMode, NewCustomMode);
		
		
		/// <summary>
		/// <para>Event when Character crouches. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public void K2_OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
			=> E_ACharacter_K2_OnStartCrouch(this, HalfHeightAdjust, ScaledHalfHeightAdjust);
		
		
		/// <summary>
		/// <para>Event for implementing custom character movement mode. Called by CharacterMovement if MovementMode is set to Custom. </para>
		/// <para>@note C++ code should override UCharacterMovementComponent::PhysCustom() instead. </para>
		/// <para>@see UCharacterMovementComponent::PhysCustom() </para>
		/// </summary>
		public void UpdateCustomMovement(float DeltaTime)
			=> E_ACharacter_K2_UpdateCustomMovement(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Called upon landing when falling, to perform actions based on the Hit result. Triggers the OnLanded event. </para>
		/// <para>Note that movement mode is still "Falling" during this event. Current Velocity value is the velocity at the time of landing. </para>
		/// <para>Consider OnMovementModeChanged() as well, as that can be used once the movement mode changes to the new mode (most likely Walking). </para>
		/// <param name="Hit">Result describing the landing that resulted in a valid landing spot. </param>
		/// <para>@see OnMovementModeChanged() </para>
		/// </summary>
		public virtual void Landed(FHitResult Hit)
			=> E_ACharacter_Landed(this, Hit);
		
		
		/// <summary>
		/// <para>Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick, </para>
		/// <para>and will set it to the "falling" state. Triggers the OnLaunched event. </para>
		/// <para>@PARAM LaunchVelocity is the velocity to impart to the Character </para>
		/// <para>@PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it. </para>
		/// <para>@PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it. </para>
		/// </summary>
		public virtual void LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
			=> E_ACharacter_LaunchCharacter(this, LaunchVelocity, bXYOverride, bZOverride);
		
		
		/// <summary>
		/// <para>Called when pawn's movement is blocked </para>
		/// <param name="Impact">describes the blocking hit. </param>
		/// </summary>
		public virtual void MoveBlockedBy(FHitResult Impact)
			=> E_ACharacter_MoveBlockedBy(this, Impact);
		
		public virtual void NotifyActorBeginOverlap(AActor OtherActor)
			=> E_ACharacter_NotifyActorBeginOverlap(this, OtherActor);
		
		public virtual void NotifyActorEndOverlap(AActor OtherActor)
			=> E_ACharacter_NotifyActorEndOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Called when character's jump reaches Apex. Needs CharacterMovement->bNotifyApex = true </para>
		/// </summary>
		public virtual void NotifyJumpApex()
			=> E_ACharacter_NotifyJumpApex(this);
		
		
		/// <summary>
		/// <para>Called when Character stops crouching. Called on non-owned Characters through bIsCrouched replication. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public virtual void OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
			=> E_ACharacter_OnEndCrouch(this, HalfHeightAdjust, ScaledHalfHeightAdjust);
		
		
		/// <summary>
		/// <para>Event fired when the character has just started jumping </para>
		/// </summary>
		public void OnJumped()
			=> E_ACharacter_OnJumped(this);
		
		public virtual void OnJumped_Implementation()
			=> E_ACharacter_OnJumped_Implementation(this);
		
		public void OnLanded(FHitResult Hit)
			=> E_ACharacter_OnLanded(this, Hit);
		
		public void OnLaunched(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
			=> E_ACharacter_OnLaunched(this, LaunchVelocity, bXYOverride, bZOverride);
		
		
		/// <summary>
		/// <para>Called from CharacterMovementComponent to notify the character that the movement mode has changed. </para>
		/// <param name="PrevMovementMode">Movement mode before the change </param>
		/// <param name="PrevCustomMode">Custom mode before the change (applicable if PrevMovementMode is Custom) </param>
		/// </summary>
		public virtual void OnMovementModeChanged(EMovementMode PrevMovementMode, byte PreviousCustomMode)
			=> E_ACharacter_OnMovementModeChanged(this, (byte)PrevMovementMode, PreviousCustomMode);
		
		public virtual void OnRep_IsCrouched()
			=> E_ACharacter_OnRep_IsCrouched(this);
		
		public virtual void OnRep_ReplicatedBasedMovement()
			=> E_ACharacter_OnRep_ReplicatedBasedMovement(this);
		
		public void OnRep_RootMotion()
			=> E_ACharacter_OnRep_RootMotion(this);
		
		
		/// <summary>
		/// <para>Called when Character crouches. Called on non-owned Characters through bIsCrouched replication. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public virtual void OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
			=> E_ACharacter_OnStartCrouch(this, HalfHeightAdjust, ScaledHalfHeightAdjust);
		
		
		/// <summary>
		/// <para>Called on client after position update is received to respond to the new location and rotation. </para>
		/// <para>Actual change in location is expected to occur in CharacterMovement->SmoothCorrection(), after which this occurs. </para>
		/// <para>Default behavior is to check for penetration in a blocking object if bClientCheckEncroachmentOnNetUpdate is enabled, and set bSimGravityDisabled=true if so. </para>
		/// </summary>
		public virtual void OnUpdateSimulatedPosition(FVector OldLocation, FQuat OldRotation)
			=> E_ACharacter_OnUpdateSimulatedPosition(this, OldLocation, OldRotation);
		
		
		/// <summary>
		/// <para>Event fired when the Character is walking off a surface and is about to fall because CharacterMovement->CurrentFloor became unwalkable. </para>
		/// <para>If CharacterMovement->MovementMode does not change during this event then the character will automatically start falling afterwards. </para>
		/// <para>@note Z velocity is zero during walking movement, and will be here as well. Another velocity can be computed here if desired and will be used when starting to fall. </para>
		/// <param name="PreviousFloorImpactNormal">Normal of the previous walkable floor. </param>
		/// <param name="PreviousFloorContactNormal">Normal of the contact with the previous walkable floor. </param>
		/// <param name="PreviousLocation">Previous character location before movement off the ledge. </param>
		/// <param name="TimeTick">Time delta of movement update resulting in moving off the ledge. </param>
		/// </summary>
		public void OnWalkingOffLedge(FVector PreviousFloorImpactNormal, FVector PreviousFloorContactNormal, FVector PreviousLocation, float TimeDelta)
			=> E_ACharacter_OnWalkingOffLedge(this, PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
		
		public virtual void OnWalkingOffLedge_Implementation(FVector PreviousFloorImpactNormal, FVector PreviousFloorContactNormal, FVector PreviousLocation, float TimeDelta)
			=> E_ACharacter_OnWalkingOffLedge_Implementation(this, PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
		
		
		/// <summary>
		/// <para>Marks character as not trying to jump </para>
		/// </summary>
		public void ResetJumpState()
			=> E_ACharacter_ResetJumpState(this);
		
		
		/// <summary>
		/// <para>Restore actor to an old buffered move. </para>
		/// </summary>
		public bool RestoreReplicatedMove(FSimulatedRootMotionReplicatedMove RootMotionRepMove)
			=> E_ACharacter_RestoreReplicatedMove(this, RootMotionRepMove);
		
		public void RootMotionDebugClientPrintOnScreen(string InString)
			=> E_ACharacter_RootMotionDebugClientPrintOnScreen(this, InString);
		
		public virtual void RootMotionDebugClientPrintOnScreen_Implementation(string InString)
			=> E_ACharacter_RootMotionDebugClientPrintOnScreen_Implementation(this, InString);
		
		
		/// <summary>
		/// <para>Save a new relative location in BasedMovement and a new rotation with is either relative or absolute. </para>
		/// </summary>
		public void SaveRelativeBasedMovement(FVector NewRelativeLocation, FRotator NewRotation, bool bRelativeRotation)
			=> E_ACharacter_SaveRelativeBasedMovement(this, NewRelativeLocation, NewRotation, bRelativeRotation);
		
		
		/// <summary>
		/// <para>Sets scale to apply to root motion translation on this Character </para>
		/// </summary>
		public void SetAnimRootMotionTranslationScale(float InAnimRootMotionTranslationScale)
			=> E_ACharacter_SetAnimRootMotionTranslationScale(this, InAnimRootMotionTranslationScale);
		
		
		/// <summary>
		/// <para>Sets the component the Character is walking on, used by CharacterMovement walking movement to be able to follow dynamic objects. </para>
		/// </summary>
		public virtual void SetBase(UPrimitiveComponent NewBase, string BoneName, bool bNotifyActor)
			=> E_ACharacter_SetBase(this, NewBase, BoneName, bNotifyActor);
		
		
		/// <summary>
		/// <para>Returns true if the Landed() event should be called. Used by CharacterMovement to prevent notifications while playing back network moves. </para>
		/// </summary>
		public virtual bool ShouldNotifyLanded(FHitResult Hit)
			=> E_ACharacter_ShouldNotifyLanded(this, Hit);
		
		
		/// <summary>
		/// <para>Position fix up for Simulated Proxies playing Root Motion </para>
		/// </summary>
		public void SimulatedRootMotionPositionFixup(float DeltaSeconds)
			=> E_ACharacter_SimulatedRootMotionPositionFixup(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Stop the character from jumping on the next update. </para>
		/// <para>Call this from an input event (such as a button 'up' event) to cease applying </para>
		/// <para>jump Z-velocity. If this is not called, then jump z-velocity will be applied </para>
		/// <para>until JumpMaxHoldTime is reached. </para>
		/// </summary>
		public virtual void StopJumping()
			=> E_ACharacter_StopJumping(this);
		
		
		/// <summary>
		/// <para>Request the character to stop crouching. The request is processed on the next update of the CharacterMovementComponent. </para>
		/// <para>@see OnEndCrouch </para>
		/// <para>@see IsCrouched </para>
		/// <para>@see CharacterMovement->WantsToCrouch </para>
		/// </summary>
		public virtual void UnCrouch(bool bClientSimulation)
			=> E_ACharacter_UnCrouch(this, bClientSimulation);
		
		#endregion
		
		public static implicit operator IntPtr(ACharacter Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ACharacter(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ACharacter>(PtrDesc);
		}}}
