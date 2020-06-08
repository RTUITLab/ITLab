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
   Arguments = new Dictionary<string, string>{{"configuration", configuration}}
};


Task("BuildBack")
.Does(() => {
   CakeExecuteScript("./ITLab-Back/build.cake", cakeSettings);
});

Task("BuildFront")
.Does(() => {
   CakeExecuteScript("./ITLab-Front/build.cake", cakeSettings);
});

Task("BuildAll")
   .IsDependentOn("BuildBack")
   .IsDependentOn("BuildFront")
   .Does(() =>
{
   
});



RunTarget(target);