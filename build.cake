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


Task("BuildBe")
.Does(() => {
   CakeExecuteScript("./ITLab-Back/build.cake", cakeSettings);
});


Task("BuildAll")
   .IsDependentOn("BuildBe")
   .Does(() =>
{
   
});



RunTarget(target);