namespace FamilyBudget.BLL.Services
{
    public class PaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository) => _paymentRepository = paymentRepository;
        public IEnumerable<Payment> GetAll() => _paymentRepository.GetAll();
    }
}
