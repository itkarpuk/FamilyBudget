namespace FamilyBudget.DAL.Interfaces
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> GetAll();
    }
}
