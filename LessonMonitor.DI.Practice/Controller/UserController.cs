using LessonMonitor.DI.Practice.Helpers;
using LessonMonitor.DI.Practice.Service;

namespace LessonMonitor.DI.Practice.Controller
{
    class UserController : CommonClass
    {
        private readonly IUserService _userService;
        private readonly IRepositoryService _repositoryService;

        public UserController(IUserService userService, IRepositoryService repositoryService)
        {
            _guid = Guid.NewGuid();
            _userService = userService;
            _repositoryService = repositoryService;
        }

        public override void GetGuid()
        {
            Console.WriteLine(nameof(UserController) + " | " + _guid);
            _userService.GetGuid();
            _repositoryService.GetGuid();
        }
    }
}
