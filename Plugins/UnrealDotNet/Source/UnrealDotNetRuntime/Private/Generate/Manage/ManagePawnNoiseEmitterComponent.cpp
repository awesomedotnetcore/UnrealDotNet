#include "UnrealDotNetRuntime.h"
#include "Generate/Manage/ManagePawnNoiseEmitterComponent.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS

void UManagePawnNoiseEmitterComponent::MakeNoise(AActor* NoiseMaker, float Loudness, const FVector& NoiseLocation)
{
	Super::MakeNoise(NoiseMaker, Loudness, NoiseLocation);
	if(bIsManageAttach) UCoreShell::InvokeInObject(this, "MakeNoise", NoiseMaker, Loudness, NoiseLocation);
}

PRAGMA_ENABLE_DEPRECATION_WARNINGS