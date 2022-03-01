namespace FamilyBudget.DAL.Entities
{
    public class UserSetting
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string ShortCountryName { get; set; }
        public byte[]? Picture { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
