using LessonMonitor.DI.Practice;
using Microsoft.Extensions.DependencyInjection;

//Custom view how lifetimes works (except Transient yet)
SingletonView();
ScopedView();

//Add services using ServiceCollection
var collection = new ServiceCollection();

collection.AddTransient<GithubClient>();
collection.AddTransient<UserService>();

var provider = collection.BuildServiceProvider();

using(var scope = provider.CreateScope())
{
    var service = scope.ServiceProvider.GetService<UserService>();
    var controller = new UserController(service);
    controller.GetGuid();
}

using (var scope = provider.CreateScope())
{
    var service = scope.ServiceProvider.GetService<UserService>();
    var controller = new UserController(service);
    controller.GetGuid();
}



void SingletonView()
{
    // more like Singleton behaviour (the same instances during program execution)

    var client = new GithubClient();
    var service = new UserService(client);

    //first request
    {
        var controller = new UserController(service);
        controller.GetGuid();
    }

    //second request
    {
        var controller = new UserController(service);
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
        var service = new UserService(client);
        var controller = new UserController(service);
        controller.GetGuid();
    }

    //second request
    {
        var client = new GithubClient();
        var service = new UserService(client);
        var controller = new UserController(service);
        controller.GetGuid();
    }

    //RESULT: for each request we are using different service & client objects
    //objects lifetime: in scope of one request
}