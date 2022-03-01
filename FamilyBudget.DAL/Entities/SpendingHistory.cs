﻿namespace FamilyBudget.DAL.Entities
{
    public class SpendingHistory
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Sum { get; set; }
        public string? Note { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        public int SpendingTypeId { get; set; }
        public SpendingType SpendingType { get; set; }

        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
