using UnrealBuildTool;

public class Full_Body_IK_KazTarget : TargetRules
{
	public Full_Body_IK_KazTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Full_Body_IK_Kaz");
	}
}
