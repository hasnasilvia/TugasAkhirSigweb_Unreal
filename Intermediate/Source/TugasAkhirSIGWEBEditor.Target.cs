using UnrealBuildTool;

public class TugasAkhirSIGWEBEditorTarget : TargetRules
{
	public TugasAkhirSIGWEBEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TugasAkhirSIGWEB");
	}
}
