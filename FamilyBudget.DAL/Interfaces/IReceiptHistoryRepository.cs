namespace FamilyBudget.DAL.Interfaces
{
    public interface IReceiptHistoryRepository
    {
        IEnumerable<ReceiptHistory> GetAll();
        ReceiptHistory Get(int id);
        void Create(ReceiptHistory history);
        void Update(ReceiptHistory history);
        void Delete(int id);
        void Save();
    }
}
