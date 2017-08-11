#include "UnrealDotNet.h"
#include "ManageActor.h"
#include "CoreShell.h"

#pragma optimize("", off)

AManageActor::AManageActor()
{
	PrimaryActorTick.bCanEverTick = true;
}

void AManageActor::BeginPlay()
{
	Super::BeginPlay();

	if (!ManageClassName.IsEmpty())
	{
		//typedef void(__stdcall InvokeFp)(AManageActor*, char*, int);

		//InvokeFp* manageMethod = (InvokeFp*)UCoreShell::GetMethodPtr(
		//	"UnrealDotNetWrapper, Version=1.0.0.0, Culture=neutral",
		//	"UnrealEngine.UObject", "AddWrapper");

		//manageMethod(this, TCHAR_TO_UTF8(*ManageClassName), 0);

		bIsManageAttach = UCoreShell::InvokeInWrapper<bool>("UnrealEngine.UObject", "AddWrapper", this, TCHAR_TO_UTF8(*ManageClassName));
	}
}

void AManageActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

	if(bIsManageAttach)
		UCoreShell::InvokeInWrapper("UnrealEngine.UObject", "CallMethod", this, "Tick", DeltaTime);
}

void AManageActor::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	if (bIsManageAttach)
		UCoreShell::InvokeInWrapper("UnrealEngine.UObject", "RemoveWrapper", this);

	Super::EndPlay(EndPlayReason);
}

#pragma optimize("", on)