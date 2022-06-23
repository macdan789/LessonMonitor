using LessonMonitor.DI.Practice.Controller;
using LessonMonitor.DI.Practice.Helpers;
using LessonMonitor.DI.Practice.Service;
using Microsoft.Extensions.DependencyInjection;

//Custom view how lifetimes works (except Transient yet)
//SingletonView();
//ScopedView();

//Add services using ServiceCollection
var collection = new ServiceCollection();

collection.AddScoped<UserService>();
collection.AddScoped<RepositoryService>();
//To see difference between Scoped & Transient just change AddMethod and see in console:
//1. Scoped: GithubClient will be the same object for both services
//2. Transiet: GithubCLient will have two different instances for each service
collection.AddScoped<GithubClient>();

var provider = collection.BuildServiceProvider();

using(var scope = provider.CreateScope())
{
    var userService = scope.ServiceProvider.GetService<UserService>();
    var repositoryService = scope.ServiceProvider.GetService<RepositoryService>();
    var controller = new UserController(userService, repositoryService);
    controller.GetGuid();
}

Console.WriteLine();

using (var scope = provider.CreateScope())
{
    var userService = scope.ServiceProvider.GetService<UserService>();
    var repositoryService = scope.ServiceProvider.GetService<RepositoryService>();
    var controller = new UserController(userService, repositoryService);
    controller.GetGuid();
}



void SingletonView()
{
    // more like Singleton behaviour (the same instances during program execution)

    var client = new GithubClient();
    var userService = new UserService(client);
    var repositoryService = new RepositoryService(client);

    //first request
    {
        var controller = new UserController(userService, repositoryService);
        controller.GetGuid();
    }

    //second request
    {
        var controller = new UserController(userService, repositoryService);
        controller.GetGuid();
    }

    //RESULT: we are using the same service & client objects for all request
    //objects lifetime: during whole program execution
}

void ScopedView()
{
    //first request
    {
        var client = new GithubClient();
        var userService = new UserService(client);
        var repositoryService = new RepositoryService(client);
        var controller = new UserController(userService, repositoryService);
        controller.GetGuid();
    }

    //second request
    {
        var client = new GithubClient();
        var userService = new UserService(client);
        var repositoryService = new RepositoryService(client);
        var controller = new UserController(userService, repositoryService);
        controller.GetGuid();
    }

    //RESULT: for each request we are using different service & client objects
    //objects lifetime: in scope of one request
}