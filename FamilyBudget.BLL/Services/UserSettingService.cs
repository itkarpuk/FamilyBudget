namespace FamilyBudget.BLL.Services
{
    public class UserSettingService
    {
        private readonly IUserSettingRepository _repository;
        public UserSettingService(IUserSettingRepository repository) => _repository = repository;

    }
}
