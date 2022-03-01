namespace FamilyBudget.DAL.Interfaces
{
    public interface ICurrencyRepository
    {
        ICollection<Currency> GetAll();
    }
}
