namespace FamilyBudget.DAL.Interfaces
{
    public interface ISpendingTypeRepository
    {
        ICollection<SpendingType> GetAll();
    }
}
