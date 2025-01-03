namespace UserAddressDbEf.models;

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
       
        public virtual Address Address { get; set; }
    }
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
