using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

namespace UnrealEngine
{
	public partial class ManageDefaultPawn : ADefaultPawn
	{
		public ManageDefaultPawn(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageDefaultPawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageDefaultPawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDefaultPawn>(PtrDesc);
		}}}
