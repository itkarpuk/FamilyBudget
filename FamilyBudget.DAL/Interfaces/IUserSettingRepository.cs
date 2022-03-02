namespace FamilyBudget.DAL.Interfaces
{
    public interface IUserSettingRepository
    {
        UserSetting GetByUser(int userId);
        void Create(UserSetting userSetting);
        void Update(UserSetting userSetting);
        void Save();
    }
}
