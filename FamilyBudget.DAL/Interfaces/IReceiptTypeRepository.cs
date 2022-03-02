namespace FamilyBudget.DAL.Interfaces
{
    public interface IReceiptTypeRepository
    {
        IEnumerable<ReceiptType> GetAll();
    }
}
