namespace FamilyBudget.DAL.Interfaces
{
    public interface IReceiptTypeRepository
    {
        ICollection<ReceiptType> GetAll();
    }
}
