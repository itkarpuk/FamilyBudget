namespace FamilyBudget.BLL.Services
{
    public class ReceiptHistoryService
    {
        private readonly IReceiptHistoryRepository _repository;
        public ReceiptHistoryService(IReceiptHistoryRepository repository) => _repository = repository;
    }
}
