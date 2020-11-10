using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static SimpleExec.Command;

class Build : NukeBuild
{
    public static int Main () => Execute<Build>(x => x.BuildAll);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    AbsolutePath BackRootDirectory = RootDirectory / "ITLab-Back-Root";
    AbsolutePath FrontRootDirectory = RootDirectory / "ITLab-Front-Root";

    Target BuildBackRoot => _ => _
        .Executes(() =>
        {
            Run("nuke", workingDirectory: BackRootDirectory);
        });
    Target BuildFrontRoot => _ => _
        .Executes(() =>
        {
            Run("powershell", "./customBuild.ps1", workingDirectory: FrontRootDirectory);
        });

    Target BuildAll => _ => _
        .DependsOn(BuildBackRoot)
        .DependsOn(BuildFrontRoot)
        .Executes(() =>
        {
        });

}
