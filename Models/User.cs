namespace BlazorUsersJsonPlaceHolderApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Company Company { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }
    }
}