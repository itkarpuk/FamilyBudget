namespace FamilyBudget.BLL.Services
{
    public class ReceiptTypeService
    {
        private readonly IReceiptTypeRepository _repository;
        public ReceiptTypeService(IReceiptTypeRepository repository) => _repository = repository;
        public IEnumerable<ReceiptType> GetAll() => _repository.GetAll();
    }
}
