using UnrealBuildTool;

public class TugasAkhirSIGWEBClientTarget : TargetRules
{
	public TugasAkhirSIGWEBClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TugasAkhirSIGWEB");
	}
}
