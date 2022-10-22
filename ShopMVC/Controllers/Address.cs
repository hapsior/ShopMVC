namespace ShopMVC.Controllers
{
    internal class Address
    {
       

        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }


        public Address(string name, string street, string city, string state, string postalCode)
        {
            Name = name;
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

       
    }
}