namespace Evendjes.DataModel.Entities
{
    public class Accounts
    {
        public long Id { get; set; }
        public string Identity { get; set; }
        public IEnumerable<Users> Users { get; set; }
    }
}