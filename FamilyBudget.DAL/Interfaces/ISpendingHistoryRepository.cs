namespace FamilyBudget.DAL.Interfaces
{
    public interface ISpendingHistoryRepository
    {
        IEnumerable<SpendingHistory> GetAll();
        SpendingHistory Get(int id);
        void Update(SpendingHistory history);
        void Create(SpendingHistory history);
        void Delete(int id);
        void Save();
    }
}
