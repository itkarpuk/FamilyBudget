namespace FamilyBudget.DAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Create(User user);
        void Update(User user);
        void Delete(int id);
        void Save();
    }
}
