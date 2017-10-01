#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/SceneCaptureComponent2D.h"
#include "ManageSceneCaptureComponent2D.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSceneCaptureComponent2D : public USceneCaptureComponent2D
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS