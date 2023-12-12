using UnrealBuildTool;

public class TugasAkhirSIGWEBServerTarget : TargetRules
{
	public TugasAkhirSIGWEBServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TugasAkhirSIGWEB");
	}
}
