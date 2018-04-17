using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ActorComponent.h:91

namespace UnrealEngine
{
	public  partial class UActorComponent : UObject
	{
		public UActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UActorComponent(UObject Parent = null, string Name = "ActorComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UActorComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UActorComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bAllowConcurrentTick_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bAllowConcurrentTick_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bAutoActivate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bAutoActivate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bAutoRegister_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bAutoRegister_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bEditableWhenInherited_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bEditableWhenInherited_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bIsActive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bIsActive_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bIsEditorOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bIsEditorOnly_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bNavigationRelevant_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bNavigationRelevant_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bNeverNeedsRenderUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bNeverNeedsRenderUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bTickInEditor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bTickInEditor_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bWantsBeginPlay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bWantsBeginPlay_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_bWantsInitializeComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_bWantsInitializeComponent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UActorComponent_CreationMethod_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UActorComponent_CreationMethod_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UActorComponent_OnComponentActivated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UActorComponent_OnComponentActivated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UActorComponent_OnComponentDeactivated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UActorComponent_OnComponentDeactivated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UActorComponent_PrimaryComponentTick_GET(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_Activate(IntPtr Self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_AllowReregistration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_CanEverAffectNavigation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ClearNeedEndOfFrameUpdate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ComponentHasTag(IntPtr Self, string Tag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ComponentIsInPersistentLevel(IntPtr Self, bool bIncludeLevelStreamingPersistent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_CreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_CreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_Deactivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DestroyComponent(IntPtr Self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DestroyRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DetermineUCSModifiedProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_DoDeferredRenderUpdates_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_GetComponentClassCanReplicate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UActorComponent_GetComponentTickInterval(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_GetIsReplicated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UActorComponent_GetNetMode(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UActorComponent_GetOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UActorComponent_GetOwnerRole(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UActorComponent_GetReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UActorComponent_GetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_HandleCanEverAffectNavigationChange(IntPtr Self, bool bForceUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_HasBeenCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_HasBeenInitialized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_HasBegunPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_HasValidPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_InitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_InvalidateLightingCache(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_InvalidateLightingCacheDetailed(IntPtr Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsBeingDestroyed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsComponentTickEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsCreatedByConstructionScript(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsEditableWhenInherited(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsNavigationRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsNetMode(IntPtr Self, byte Mode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsNetSimulating(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsNetStartupComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsOwnerRunningUserConstructionScript(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsOwnerSelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsPhysicsStateCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsReadyForOwnerToAutoDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsRegistered(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsRenderStateCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsRenderStateDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsRenderTransformDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_K2_DestroyComponent(IntPtr Self, IntPtr Object);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkForNeededEndOfFrameRecreate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkForNeededEndOfFrameUpdate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkRenderDynamicDataDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkRenderStateDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_MarkRenderTransformDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnActorEnableCollisionChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnComponentCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnComponentDestroyed(IntPtr Self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnDestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnRegister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnRep_IsActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnUnregister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ReceiveBeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ReceiveTick(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RecreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RecreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RegisterAllComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RegisterComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RegisterComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RegisterComponentWithWorld(IntPtr Self, IntPtr InWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_RequiresGameThreadEndOfFrameRecreate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_RequiresGameThreadEndOfFrameUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ReregisterComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SendRenderDynamicData_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SendRenderTransform_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetActive(IntPtr Self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetAutoActivate(IntPtr Self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetCanEverAffectNavigation(IntPtr Self, bool bRelevant);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetComponentTickEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetComponentTickEnabledAsync(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetComponentTickInterval(IntPtr Self, float TickInterval);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetIsNetStartupComponent(IntPtr Self, bool bInIsNetStartupComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetIsReplicated(IntPtr Self, bool ShouldReplicate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetNetAddressable(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetTickableWhenPaused(IntPtr Self, bool bTickableWhenPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_SetTickGroup(IntPtr Self, byte NewTickGroup);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ShouldActivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ShouldCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_ShouldCreateRenderState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ToggleActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_UninitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_UnregisterComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_UpdateComponentToWorld(IntPtr Self, byte UpdateTransformFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UActorComponent_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UActorComponent_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UActorComponent_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UActorComponent_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Can this component be destroyed (via K2_DestroyComponent) by any parent </para>
		/// </summary>
		public byte bAllowAnyoneToDestroyMe
		{
			get => E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_GET(NativePointer);
			set => E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Can we tick this concurrently on other threads? </para>
		/// </summary>
		public byte bAllowConcurrentTick
		{
			get => E_PROP_UActorComponent_bAllowConcurrentTick_GET(NativePointer);
			set => E_PROP_UActorComponent_bAllowConcurrentTick_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether the component is activated at creation or must be explicitly activated. </para>
		/// </summary>
		public byte bAutoActivate
		{
			get => E_PROP_UActorComponent_bAutoActivate_GET(NativePointer);
			set => E_PROP_UActorComponent_bAutoActivate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Does this component automatically register with its owner </para>
		/// </summary>
		public byte bAutoRegister
		{
			get => E_PROP_UActorComponent_bAutoRegister_GET(NativePointer);
			set => E_PROP_UActorComponent_bAutoRegister_SET(NativePointer, value);
		}

		public byte bEditableWhenInherited
		{
			get => E_PROP_UActorComponent_bEditableWhenInherited_GET(NativePointer);
			set => E_PROP_UActorComponent_bEditableWhenInherited_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether the component is currently active. </para>
		/// </summary>
		public byte bIsActive
		{
			get => E_PROP_UActorComponent_bIsActive_GET(NativePointer);
			set => E_PROP_UActorComponent_bIsActive_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, the component will be excluded from non-editor builds </para>
		/// </summary>
		public byte bIsEditorOnly
		{
			get => E_PROP_UActorComponent_bIsEditorOnly_GET(NativePointer);
			set => E_PROP_UActorComponent_bIsEditorOnly_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Cached navigation relevancy flag for collision updates </para>
		/// </summary>
		public byte bNavigationRelevant
		{
			get => E_PROP_UActorComponent_bNavigationRelevant_GET(NativePointer);
			set => E_PROP_UActorComponent_bNavigationRelevant_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this component never needs a render update. </para>
		/// </summary>
		public byte bNeverNeedsRenderUpdate
		{
			get => E_PROP_UActorComponent_bNeverNeedsRenderUpdate_GET(NativePointer);
			set => E_PROP_UActorComponent_bNeverNeedsRenderUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Should this component be ticked in the editor </para>
		/// </summary>
		public byte bTickInEditor
		{
			get => E_PROP_UActorComponent_bTickInEditor_GET(NativePointer);
			set => E_PROP_UActorComponent_bTickInEditor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, we call the virtual BeginPlay </para>
		/// </summary>
		public byte bWantsBeginPlay
		{
			get => E_PROP_UActorComponent_bWantsBeginPlay_GET(NativePointer);
			set => E_PROP_UActorComponent_bWantsBeginPlay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, we call the virtual InitializeComponent </para>
		/// </summary>
		public byte bWantsInitializeComponent
		{
			get => E_PROP_UActorComponent_bWantsInitializeComponent_GET(NativePointer);
			set => E_PROP_UActorComponent_bWantsInitializeComponent_SET(NativePointer, value);
		}

		public EComponentCreationMethod CreationMethod
		{
			get => (EComponentCreationMethod)E_PROP_UActorComponent_CreationMethod_GET(NativePointer);
			set => E_PROP_UActorComponent_CreationMethod_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Main tick function for the Actor </para>
		/// </summary>
		public FActorComponentTickFunction PrimaryComponentTick
		{
			get => E_PROP_UActorComponent_PrimaryComponentTick_GET(NativePointer);
		}

		#endregion
		
		#region Events
		public event FActorComponentActivatedSignature OnComponentActivated
		{
			add
			{
				E_EVENT_ADD_UActorComponent_OnComponentActivated(NativePointer);
				_Event_OnComponentActivated += value;
			}

			remove
			{
				E_EVENT_DEL_UActorComponent_OnComponentActivated(NativePointer);
				_Event_OnComponentActivated -= value;
			}

		}

		private event FActorComponentActivatedSignature _Event_OnComponentActivated;
		
		internal void InvokeEvent_OnComponentActivated(ObjectPointerDescription Component, bool bReset)
		{
			_Event_OnComponentActivated?.Invoke(Component, bReset);
		}

		public event FActorComponentDeactivateSignature OnComponentDeactivated
		{
			add
			{
				E_EVENT_ADD_UActorComponent_OnComponentDeactivated(NativePointer);
				_Event_OnComponentDeactivated += value;
			}

			remove
			{
				E_EVENT_DEL_UActorComponent_OnComponentDeactivated(NativePointer);
				_Event_OnComponentDeactivated -= value;
			}

		}

		private event FActorComponentDeactivateSignature _Event_OnComponentDeactivated;
		
		internal void InvokeEvent_OnComponentDeactivated(ObjectPointerDescription Component)
		{
			_Event_OnComponentDeactivated?.Invoke(Component);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Activates the SceneComponent </para>
		/// <param name="bReset">The value to assign to HiddenGame. </param>
		/// </summary>
		public virtual void Activate(bool bReset)
			=> E_UActorComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public virtual void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UActorComponent_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public virtual void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UActorComponent_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Checked whether the component class allows reregistration </para>
		/// </summary>
		public bool AllowReregistration()
			=> E_UActorComponent_AllowReregistration(this);
		
		
		/// <summary>
		/// <para>Called by owner actor on position shifting </para>
		/// <para>Component should update all relevant data structures to reflect new actor location </para>
		/// <param name="InWorldOffset">Offset vector the actor shifted by </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public virtual void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_UActorComponent_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		public override void BeginDestroy()
			=> E_UActorComponent_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>BeginsPlay for the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// <para>Actor/Component gets BeginPlay. </para>
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public virtual void BeginPlay()
			=> E_UActorComponent_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Can this component potentially influence navigation </para>
		/// </summary>
		public bool CanEverAffectNavigation()
			=> E_UActorComponent_CanEverAffectNavigation(this);
		
		
		/// <summary>
		/// <para>If we belong to a world, clear the request to do a deferred update. </para>
		/// </summary>
		public void ClearNeedEndOfFrameUpdate()
			=> E_UActorComponent_ClearNeedEndOfFrameUpdate(this);
		
		
		/// <summary>
		/// <para>See if this component contains the supplied tag </para>
		/// </summary>
		public bool ComponentHasTag(string Tag)
			=> E_UActorComponent_ComponentHasTag(this, Tag);
		
		
		/// <summary>
		/// <para>See if this component is in the persistent level </para>
		/// </summary>
		public bool ComponentIsInPersistentLevel(bool bIncludeLevelStreamingPersistent)
			=> E_UActorComponent_ComponentIsInPersistentLevel(this, bIncludeLevelStreamingPersistent);
		
		
		/// <summary>
		/// <para>Create any physics engine information for this component </para>
		/// </summary>
		public void CreatePhysicsState()
			=> E_UActorComponent_CreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to create any rendering thread information for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public virtual void CreateRenderState_Concurrent()
			=> E_UActorComponent_CreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>Deactivates the SceneComponent. </para>
		/// </summary>
		public virtual void Deactivate()
			=> E_UActorComponent_Deactivate(this);
		
		
		/// <summary>
		/// <para>Unregister the component, remove it from its outer Actor's Components array and mark for pending kill. </para>
		/// </summary>
		public virtual void DestroyComponent(bool bPromoteChildren)
			=> E_UActorComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// <para>Shut down any physics engine structure for this component </para>
		/// </summary>
		public void DestroyPhysicsState()
			=> E_UActorComponent_DestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public virtual void DestroyRenderState_Concurrent()
			=> E_UActorComponent_DestroyRenderState_Concurrent(this);
		
		public void DetermineUCSModifiedProperties()
			=> E_UActorComponent_DetermineUCSModifiedProperties(this);
		
		
		/// <summary>
		/// <para>Uses the bRenderStateDirty/bRenderTransformDirty to perform any necessary work on this component. </para>
		/// <para>Do not call this directly, call MarkRenderStateDirty, MarkRenderDynamicDataDirty, </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public void DoDeferredRenderUpdates_Concurrent()
			=> E_UActorComponent_DoDeferredRenderUpdates_Concurrent(this);
		
		public virtual bool GetComponentClassCanReplicate()
			=> E_UActorComponent_GetComponentClassCanReplicate(this);
		
		
		/// <summary>
		/// <para>Returns whether this component has tick enabled or not </para>
		/// </summary>
		public float GetComponentTickInterval()
			=> E_UActorComponent_GetComponentTickInterval(this);
		
		
		/// <summary>
		/// <para>Returns whether replication is enabled or not. </para>
		/// </summary>
		public bool GetIsReplicated()
			=> E_UActorComponent_GetIsReplicated(this);
		
		
		/// <summary>
		/// <para>Get the network mode (dedicated server, client, standalone, etc) for this component. </para>
		/// <para>@see IsNetMode() </para>
		/// </summary>
		public ENetMode GetNetMode()
			=> (ENetMode)E_UActorComponent_GetNetMode(this);
		
		
		/// <summary>
		/// <para>Follow the Outer chain to get the  AActor  that 'Owns' this component </para>
		/// </summary>
		public AActor GetOwner()
			=> E_UActorComponent_GetOwner(this);
		
		
		/// <summary>
		/// <para>Get the network role of the Owner, or ROLE_None if there is no owner. </para>
		/// </summary>
		public ENetRole GetOwnerRole()
			=> (ENetRole)E_UActorComponent_GetOwnerRole(this);
		
		
		/// <summary>
		/// <para>Returns a readable name for this component, including the asset name if applicable </para>
		/// <para>By default this appends a space plus AdditionalStatObject() </para>
		/// </summary>
		public virtual string GetReadableName()
			=> E_UActorComponent_GetReadableName(this);
		
		public override UWorld GetWorld()
			=> E_UActorComponent_GetWorld(this);
		
		
		/// <summary>
		/// <para>Makes sure navigation system has up to date information regarding component's navigation relevancy </para>
		/// <para>and if it can affect navigation at all </para>
		/// <param name="bForceUpdate">by default updating navigation system will take place only if the component has </param>
		/// <para>already been registered. Setting bForceUpdate to true overrides that check </para>
		/// </summary>
		protected void HandleCanEverAffectNavigationChange(bool bForceUpdate = false)
			=> E_UActorComponent_HandleCanEverAffectNavigationChange(this, bForceUpdate);
		
		public bool HasBeenCreated()
			=> E_UActorComponent_HasBeenCreated(this);
		
		public bool HasBeenInitialized()
			=> E_UActorComponent_HasBeenInitialized(this);
		
		public bool HasBegunPlay()
			=> E_UActorComponent_HasBegunPlay(this);
		
		
		/// <summary>
		/// <para>Used to check that DestroyPhysicsState() is working correctly </para>
		/// </summary>
		public virtual bool HasValidPhysicsState()
			=> E_UActorComponent_HasValidPhysicsState(this);
		
		
		/// <summary>
		/// <para>Initializes the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components in the level will be Initialized on load before any Actor/Component gets BeginPlay </para>
		/// <para>Requires component to be registered, and bWantsInitializeComponent to be true. </para>
		/// </summary>
		public virtual void InitializeComponent()
			=> E_UActorComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// <para>Invalidate lighting cache with default options. </para>
		/// </summary>
		public void InvalidateLightingCache()
			=> E_UActorComponent_InvalidateLightingCache(this);
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E_UActorComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns whether the component is active or not </para>
		/// <return>The active state of the component. </return>
		/// </summary>
		public virtual bool IsActive()
			=> E_UActorComponent_IsActive(this);
		
		
		/// <summary>
		/// <para>Returns whether the component is in the process of being destroyed. </para>
		/// </summary>
		public bool IsComponentBeingDestroyed()
			=> E_UActorComponent_IsBeingDestroyed(this);
		
		
		/// <summary>
		/// <para>Returns whether this component has tick enabled or not </para>
		/// </summary>
		public bool IsComponentTickEnabled()
			=> E_UActorComponent_IsComponentTickEnabled(this);
		
		public bool IsCreatedByConstructionScript()
			=> E_UActorComponent_IsCreatedByConstructionScript(this);
		
		public bool IsEditableWhenInherited()
			=> E_UActorComponent_IsEditableWhenInherited(this);
		
		
		/// <summary>
		/// <para>Returns whether this component is an editor-only object or not </para>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_UActorComponent_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_UActorComponent_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>override to supply actual logic </para>
		/// </summary>
		public virtual bool IsNavigationRelevant()
			=> E_UActorComponent_IsNavigationRelevant(this);
		
		
		/// <summary>
		/// <para>Test whether net mode is the given mode. </para>
		/// <para>In optimized non-editor builds this can be more efficient than GetNetMode() </para>
		/// <para>because it can check the static build flags without considering PIE. </para>
		/// </summary>
		public bool IsNetMode(ENetMode Mode)
			=> E_UActorComponent_IsNetMode(this, (byte)Mode);
		
		
		/// <summary>
		/// <para>Returns true if we are replicating and not authorative </para>
		/// </summary>
		public bool IsNetSimulating()
			=> E_UActorComponent_IsNetSimulating(this);
		
		
		/// <summary>
		/// <para>Returns true if this component was owned by a net startup actor during level load. </para>
		/// </summary>
		public bool IsNetStartupComponent()
			=> E_UActorComponent_IsNetStartupComponent(this);
		
		
		/// <summary>
		/// <para>See if the owning Actor is currently running the UCS </para>
		/// </summary>
		public bool IsOwnerRunningUserConstructionScript()
			=> E_UActorComponent_IsOwnerRunningUserConstructionScript(this);
		
		
		/// <summary>
		/// <para>Returns whether the component's owner is selected. </para>
		/// </summary>
		public bool IsOwnerSelected()
			=> E_UActorComponent_IsOwnerSelected(this);
		
		
		/// <summary>
		/// <return>true if the physics 'state' (e.g. physx bodies) are created for this component </return>
		/// </summary>
		public bool IsPhysicsStateCreated()
			=> E_UActorComponent_IsPhysicsStateCreated(this);
		
		
		/// <summary>
		/// <para>Overridable check for a component to indicate to its Owner that it should prevent the Actor from auto destroying when finished </para>
		/// </summary>
		public virtual bool IsReadyForOwnerToAutoDestroy()
			=> E_UActorComponent_IsReadyForOwnerToAutoDestroy(this);
		
		
		/// <summary>
		/// <para>See if this component is currently registered </para>
		/// </summary>
		public bool IsRegistered()
			=> E_UActorComponent_IsRegistered(this);
		
		
		/// <summary>
		/// <return>true if the render 'state' (e.g. scene proxy) is created for this component </return>
		/// </summary>
		public bool IsRenderStateCreated()
			=> E_UActorComponent_IsRenderStateCreated(this);
		
		public bool IsRenderStateDirty()
			=> E_UActorComponent_IsRenderStateDirty(this);
		
		public bool IsRenderTransformDirty()
			=> E_UActorComponent_IsRenderTransformDirty(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_UActorComponent_IsSupportedForNetworking(this);
		
		
		/// <summary>
		/// <para>Unregister and mark for pending kill a component.  This may not be used to destroy a component that is owned by an actor unless the owning actor is calling the function. </para>
		/// </summary>
		public void K2_DestroyComponent(UObject Object)
			=> E_UActorComponent_K2_DestroyComponent(this, Object);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_UActorComponent_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// <para>If we belong to a world, mark this for a deferred update, otherwise do it now. </para>
		/// </summary>
		public void MarkForNeededEndOfFrameRecreate()
			=> E_UActorComponent_MarkForNeededEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>If we belong to a world, mark this for a deferred update, otherwise do it now. </para>
		/// </summary>
		public void MarkForNeededEndOfFrameUpdate()
			=> E_UActorComponent_MarkForNeededEndOfFrameUpdate(this);
		
		
		/// <summary>
		/// <para>Indicate that dynamic data for this component needs to be sent at the end of the frame. </para>
		/// </summary>
		public void MarkRenderDynamicDataDirty()
			=> E_UActorComponent_MarkRenderDynamicDataDirty(this);
		
		
		/// <summary>
		/// <para>Mark the render state as dirty - will be sent to the render thread at the end of the frame. </para>
		/// </summary>
		public void MarkRenderStateDirty()
			=> E_UActorComponent_MarkRenderStateDirty(this);
		
		
		/// <summary>
		/// <para>Marks the transform as dirty - will be sent to the render thread at the end of the frame </para>
		/// </summary>
		public void MarkRenderTransformDirty()
			=> E_UActorComponent_MarkRenderTransformDirty(this);
		
		public override bool NeedsLoadForClient()
			=> E_UActorComponent_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_UActorComponent_NeedsLoadForEditorGame(this);
		
		public override bool NeedsLoadForServer()
			=> E_UActorComponent_NeedsLoadForServer(this);
		
		
		/// <summary>
		/// <para>Called on each component when the Actor's bEnableCollisionChanged flag changes </para>
		/// </summary>
		public virtual void OnActorEnableCollisionChanged()
			=> E_UActorComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public virtual void OnComponentCreated()
			=> E_UActorComponent_OnComponentCreated(this);
		
		
		/// <summary>
		/// <para>Called when a component is destroyed </para>
		/// <param name="bDestroyingHierarchy">True if the entire component hierarchy is being torn down, allows avoiding expensive operations </param>
		/// </summary>
		public virtual void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E_UActorComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		
		/// <summary>
		/// <para>Used to create any physics engine information for this component </para>
		/// </summary>
		protected virtual void OnCreatePhysicsState()
			=> E_UActorComponent_OnCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down and physics engine structure for this component </para>
		/// </summary>
		protected virtual void OnDestroyPhysicsState()
			=> E_UActorComponent_OnDestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Called when a component is registered, after Scene is set, but before CreateRenderState_Concurrent or OnCreatePhysicsState are called. </para>
		/// </summary>
		public virtual void OnRegister()
			=> E_UActorComponent_OnRegister(this);
		
		public void OnRep_IsActive()
			=> E_UActorComponent_OnRep_IsActive(this);
		
		
		/// <summary>
		/// <para>Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called. </para>
		/// </summary>
		public virtual void OnUnregister()
			=> E_UActorComponent_OnUnregister(this);
		
		public override void PostInitProperties()
			=> E_UActorComponent_PostInitProperties(this);
		
		public override void PostLoad()
			=> E_UActorComponent_PostLoad(this);
		
		public override void PostNetReceive()
			=> E_UActorComponent_PostNetReceive(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_UActorComponent_PostRename(this, OldOuter, OldName);
		
		public override void PreNetReceive()
			=> E_UActorComponent_PreNetReceive(this);
		
		
		/// <summary>
		/// <para>Blueprint implementable event for when the component is beginning play, called before its Owner's BeginPlay on Actor BeginPlay </para>
		/// <para>or when the component is dynamically created if the Actor has already BegunPlay. </para>
		/// </summary>
		public void ReceiveBeginPlay()
			=> E_UActorComponent_ReceiveBeginPlay(this);
		
		
		/// <summary>
		/// <para>Event called every frame </para>
		/// </summary>
		public void Tick(float DeltaSeconds)
			=> E_UActorComponent_ReceiveTick(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Recreate the physics state right way. </para>
		/// </summary>
		public void RecreatePhysicsState()
			=> E_UActorComponent_RecreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Recreate the render state right away. Generally you always want to call MarkRenderStateDirty instead. </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public void RecreateRenderState_Concurrent()
			=> E_UActorComponent_RecreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>When called, will call the virtual call chain to register all of the tick functions </para>
		/// <para>Do not override this function or make it virtual </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		public void RegisterAllComponentTickFunctions(bool bRegister)
			=> E_UActorComponent_RegisterAllComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Register this component, creating any rendering/physics state. Will also adds to outer Actor's Components array, if not already present. </para>
		/// </summary>
		public void RegisterComponent()
			=> E_UActorComponent_RegisterComponent(this);
		
		
		/// <summary>
		/// <para>Virtual call chain to register all tick functions </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		public virtual void RegisterComponentTickFunctions(bool bRegister)
			=> E_UActorComponent_RegisterComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <param name="InWorld">The world to register the component with. </param>
		/// </summary>
		public void RegisterComponentWithWorld(UWorld InWorld)
			=> E_UActorComponent_RegisterComponentWithWorld(this, InWorld);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public virtual void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UActorComponent_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public virtual void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UActorComponent_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame recreates to happen from the game thread. </para>
		/// </summary>
		public virtual bool RequiresGameThreadEndOfFrameRecreate()
			=> E_UActorComponent_RequiresGameThreadEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame updates to happen from the game thread. </para>
		/// </summary>
		public virtual bool RequiresGameThreadEndOfFrameUpdates()
			=> E_UActorComponent_RequiresGameThreadEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Unregisters and immediately re-registers component.  Handles bWillReregister properly. </para>
		/// </summary>
		public void ReregisterComponent()
			=> E_UActorComponent_ReregisterComponent(this);
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected virtual void SendRenderDynamicData_Concurrent()
			=> E_UActorComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the rendering thread </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public virtual void SendRenderTransform_Concurrent()
			=> E_UActorComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// </summary>
		public virtual void SetActive(bool bNewActive, bool bReset)
			=> E_UActorComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public virtual void SetAutoActivate(bool bNewAutoActivate)
			=> E_UActorComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// <para>set value of bCanEverAffectNavigation flag and update navigation octree if needed </para>
		/// </summary>
		public void SetCanEverAffectNavigation(bool bRelevant)
			=> E_UActorComponent_SetCanEverAffectNavigation(this, bRelevant);
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public virtual void SetComponentTickEnabled(bool bEnabled)
			=> E_UActorComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public virtual void SetComponentTickEnabledAsync(bool bEnabled)
			=> E_UActorComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// <para>Sets the tick interval for this component's primary tick function. Does not enable the tick interval. Takes effect on next tick. </para>
		/// <param name="TickInterval">The duration between ticks for this component's primary tick function </param>
		/// </summary>
		public void SetComponentTickInterval(float TickInterval)
			=> E_UActorComponent_SetComponentTickInterval(this, TickInterval);
		
		
		/// <summary>
		/// <para>This should only be called by the engine in ULevel::InitializeNetworkActors to initialize bIsNetStartupComponent. </para>
		/// </summary>
		public void SetIsNetStartupComponent(bool bInIsNetStartupComponent)
			=> E_UActorComponent_SetIsNetStartupComponent(this, bInIsNetStartupComponent);
		
		
		/// <summary>
		/// <para>Enable or disable replication. This is the equivalent of RemoteRole for actors (only a bool is required for components) </para>
		/// </summary>
		public void SetIsReplicated(bool ShouldReplicate)
			=> E_UActorComponent_SetIsReplicated(this, ShouldReplicate);
		
		
		/// <summary>
		/// <para>This signifies the component can be ID'd by name over the network. This only needs to be called by engine code when constructing blueprint components. </para>
		/// </summary>
		public void SetNetAddressable()
			=> E_UActorComponent_SetNetAddressable(this);
		
		
		/// <summary>
		/// <para>Sets whether this component can tick when paused. </para>
		/// </summary>
		public void SetTickableWhenPaused(bool bTickableWhenPaused)
			=> E_UActorComponent_SetTickableWhenPaused(this, bTickableWhenPaused);
		
		
		/// <summary>
		/// <para>Changes the ticking group for this component </para>
		/// </summary>
		public void SetTickGroup(ETickingGroup NewTickGroup)
			=> E_UActorComponent_SetTickGroup(this, (byte)NewTickGroup);
		
		
		/// <summary>
		/// <para>"Trigger" related function. Return true if it should activate </para>
		/// </summary>
		protected virtual bool ShouldActivate()
			=> E_UActorComponent_ShouldActivate(this);
		
		
		/// <summary>
		/// <para>Return true if CreatePhysicsState() should be called. </para>
		/// <para>Ideally CreatePhysicsState() should always succeed if this returns true, but this isn't currently the case </para>
		/// </summary>
		public virtual bool ShouldCreatePhysicsState()
			=> E_UActorComponent_ShouldCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Return true if CreateRenderState() should be called </para>
		/// </summary>
		public virtual bool ShouldCreateRenderState()
			=> E_UActorComponent_ShouldCreateRenderState(this);
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public virtual void ToggleActive()
			=> E_UActorComponent_ToggleActive(this);
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public virtual void UninitializeComponent()
			=> E_UActorComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// <para>Unregister this component, destroying any rendering/physics state. </para>
		/// </summary>
		public void UnregisterComponent()
			=> E_UActorComponent_UnregisterComponent(this);
		
		
		/// <summary>
		/// <para>Recalculate the value of our component to world transform </para>
		/// </summary>
		public virtual void UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
			=> E_UActorComponent_UpdateComponentToWorld(this, (byte)UpdateTransformFlags, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_UActorComponent_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public override bool CheckDefaultSubobjectsInternal()
			=> E_UActorComponent_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E_UActorComponent_FinishDestroy(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_UActorComponent_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_UActorComponent_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_UActorComponent_IsAsset(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_UActorComponent_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_UActorComponent_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_UActorComponent_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the </para>
		/// <para>potentially asynchronous object cleanup. </para>
		/// <return>True if the object's asynchronous cleanup has completed and it is ready for FinishDestroy to be called. </return>
		/// </summary>
		public override bool IsReadyForFinishDestroy()
			=> E_UActorComponent_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_UActorComponent_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_UActorComponent_Modify(this, bAlwaysMarkDirty);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_UActorComponent_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_UActorComponent_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_UActorComponent_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies()
			=> E_UActorComponent_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UActorComponent_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_UActorComponent_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_UActorComponent_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_UActorComponent_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_UActorComponent_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public override bool CanBeInCluster()
			=> E_UActorComponent_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_UActorComponent_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_UActorComponent_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(UActorComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UActorComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UActorComponent>(PtrDesc);
		}}}
