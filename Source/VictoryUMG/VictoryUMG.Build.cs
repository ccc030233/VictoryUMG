/*
	By Rama for You
	
	You are welcome to use this code anywhere as long as you include this notice.
	
	copyright 2015
*/
using UnrealBuildTool;
using System.IO;

public class VictoryUMG : ModuleRules
{
    public VictoryUMG(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
        PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));

        PublicDependencyModuleNames.AddRange(
			new string[] { 
				"Core", 
				"CoreUObject", 
				"Engine", 
				"InputCore",
				"RHI",
				"RenderCore",		 
				"UMG", 
				"Slate", 
				"SlateCore", 
                "APPFRAMEWORK" //for color picker! -Rama
		
			}
		);
	}
}
