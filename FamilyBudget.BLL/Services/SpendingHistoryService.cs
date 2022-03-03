namespace FamilyBudget.BLL.Services
{
    public class SpendingHistoryService
    {
        private readonly ISpendingHistoryRepository _repository;
        public SpendingHistoryService(ISpendingHistoryRepository repository) => _repository = repository;
    }
}
