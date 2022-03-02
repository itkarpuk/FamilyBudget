namespace FamilyBudget.DAL.Interfaces
{
    public interface ISpendingTypeRepository
    {
        IEnumerable<SpendingType> GetAll();
    }
}
