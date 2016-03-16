# PackageableMVCAreaPOC
Proof of Concept for creating a nuget package for an ASP.NET MVC Area, from https://retinalamps.wordpress.com/2013/10/12/creating-an-asp-net-mvc-nuget-package/

To use this project, get the latest and build. After the solution is built, execute the following in a command prompt to create the nupkg file:
NuGet.exe pack PackageableMVCAreaPOC.nuspec

To consume this project, create a new ASP.NET MVC application and install a nuget package from the nupkg file created above. Beyond a POC, this is nupkg file is intented to be hosted on a NuGet server.

You will also need to add the namespace name to the routes.MapRoute in your RouteConfig, like this:
namespaces:  new[] {"WebApplication1.Controllers"}

See this SO issue for more information:
http://stackoverflow.com/questions/7842293/multiple-types-were-found-that-match-the-controller-named-home
