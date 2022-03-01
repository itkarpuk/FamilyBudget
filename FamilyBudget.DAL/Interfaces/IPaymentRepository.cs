namespace FamilyBudget.DAL.Interfaces
{
    public interface IPaymentRepository
    {
        ICollection<Payment> GetAll();
    }
}
