namespace LessonMonitor.DI.Practice
{
    class UserController : CommonClass
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _guid = Guid.NewGuid();
            _userService = userService;
        }

        public override void GetGuid()
        {
            Console.WriteLine(nameof(UserController) + " | " + this._guid);
            _userService.GetGuid();
        }
    }

    class UserService : CommonClass
    {
        private readonly GithubClient _githubClient;

        public UserService(GithubClient githubClient)
        {
            _guid = Guid.NewGuid();
            _githubClient = githubClient;
        }

        public override void GetGuid()
        {
            Console.WriteLine(nameof(UserService) + " | " + this._guid);
            _githubClient.GetGuid();
        }
    }

    class GithubClient : CommonClass
    {
        public GithubClient()
        {
            _guid = Guid.NewGuid();
        }

        public override void GetGuid()
            => Console.WriteLine(nameof(GithubClient) + " | " + this._guid);
    }


    public abstract class CommonClass
    {
        public Guid _guid;

        public abstract void GetGuid();
    }
}
