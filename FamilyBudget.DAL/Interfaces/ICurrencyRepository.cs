namespace FamilyBudget.DAL.Interfaces
{
    public interface ICurrencyRepository
    {
        IEnumerable<Currency> GetAll();
    }
}
