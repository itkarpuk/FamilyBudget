namespace FamilyBudget.BLL.Services
{
    public class CurrencyService
    {
        private readonly ICurrencyRepository _repository;
        public CurrencyService(ICurrencyRepository repository) => _repository = repository;
        
        public IEnumerable<Currency> GetAll() => _repository.GetAll();
    }
}
