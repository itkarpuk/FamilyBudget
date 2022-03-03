namespace FamilyBudget.BLL.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository repository) => _userRepository = repository;
    }
}
