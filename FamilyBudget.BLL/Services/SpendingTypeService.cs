namespace FamilyBudget.BLL.Services
{
    public class SpendingTypeService
    {
        private readonly ISpendingTypeRepository _repository;
        public SpendingTypeService(ISpendingTypeRepository repository) => _repository = repository;
        public IEnumerable<SpendingType> GetAll() => _repository.GetAll();
    }
}
