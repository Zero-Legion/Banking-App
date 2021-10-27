using UnrealBuildTool;

public class BankingTarget : TargetRules
{
	public BankingTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Banking");
	}
}
