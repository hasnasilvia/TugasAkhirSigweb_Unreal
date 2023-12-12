using UnrealBuildTool;

public class TugasAkhirSIGWEBTarget : TargetRules
{
	public TugasAkhirSIGWEBTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TugasAkhirSIGWEB");
	}
}
