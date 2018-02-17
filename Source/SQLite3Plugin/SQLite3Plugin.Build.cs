// 

using System.IO;
using System.Collections;
using UnrealBuildTool;

public class SQLite3Plugin : ModuleRules
{
    public SQLite3Plugin(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[] {
                "Engine",
                "Core",
                "CoreUObject"
            }
        );

        string ThirdPartyPath = Path.Combine(ModuleDirectory, "../../ThirdParty");

        // -- SQLite3 include and lib path

        string SQLite3Path = Path.Combine(ThirdPartyPath, "SQLite3");
        string SQLite3Include = Path.Combine(SQLite3Path, "include");
        string SQLite3Lib = Path.Combine(SQLite3Path, "lib");

		PublicIncludePaths.Add(Path.GetFullPath(SQLite3Include));
        PublicLibraryPaths.Add(Path.GetFullPath(SQLite3Lib));

        PublicAdditionalLibraries.Add("SQLite3.lib");
    }
}
