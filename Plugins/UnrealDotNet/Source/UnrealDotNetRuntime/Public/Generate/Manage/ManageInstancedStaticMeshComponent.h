#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/InstancedStaticMeshComponent.h"
#include "ManageInstancedStaticMeshComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageInstancedStaticMeshComponent : public UInstancedStaticMeshComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
