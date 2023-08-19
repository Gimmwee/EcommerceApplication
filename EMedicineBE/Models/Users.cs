namespace EMedicineBE.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public decimal Fund { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
