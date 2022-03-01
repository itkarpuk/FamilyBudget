namespace FamilyBudget.DAL.Entities
{
    public class ReceiptHistory
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Sum { get; set; }
        public string? Note { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        public int ReceiptTypeId { get; set; }
        public ReceiptType ReceiptType { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
