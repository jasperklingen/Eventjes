namespace Evendjes.DataModel.Entities
{
    public class Users
    {
        /// <summary>
        /// Database technical Id, not exposed to frontend, not mutable
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Functional Id for frontend, not mutable
        /// </summary>
        public long FunctionalId { get; set; }

        /// <summary>
        /// User name, readable, mutable by user
        /// </summary>
        public string Name { get; set; }

        public Accounts Accounts { get; set; }
    }
}
