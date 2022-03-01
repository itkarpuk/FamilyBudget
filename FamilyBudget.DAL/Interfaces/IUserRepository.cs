namespace FamilyBudget.DAL.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetAll();
        User Get(int id);
        void Create(User user);
        void Update(User user);
        void Delete(int id);
    }
}
