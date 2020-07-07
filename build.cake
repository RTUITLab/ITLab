#addin nuget:?package=Cake.Docker&version=0.11.0

var target = Argument("target", "BuildAll");
var configuration = Argument("configuration", "Release");

Setup(ctx =>
{
});

Teardown(ctx =>
{
});

var cakeSettings = new CakeSettings 
{
   Arguments = new Dictionary<string, string>{
      ["configuration"] = configuration
   }
};


Task("BuildBack")
.Does(() => 
{
   CakeExecuteScript("./ITLab-Back/build.cake", cakeSettings);
});

Task("BuildIdentity")
.Does(() => 
{
   CakeExecuteScript("./ITLab-Identity/build.cake", cakeSettings);
});


Task("BuildFront")
.Does(() => 
{
   CakeExecuteScript("./ITLab-Front/build.cake", new CakeSettings {
      Arguments = new Dictionary<string, string> {
         ["target"] = "GenAppSettings",
         ["rewriteConfig"] = ""
      }
   });
   CakeExecuteScript("./ITLab-Front/build.cake");
});

Task("BuildAll")
   .IsDependentOn("BuildBack")
   .IsDependentOn("BuildIdentity")
   .IsDependentOn("BuildFront")
   .Does(() =>
{
   
});

Task("RunInDocker")
   .IsDependentOn("BuildAll")
   .Does(() => 
{
   DockerComposeBuild();
   DockerComposeUp(new DockerComposeUpSettings {
      DetachedMode = false
   });
});



RunTarget(target);