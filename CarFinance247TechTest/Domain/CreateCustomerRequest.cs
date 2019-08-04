using System;

namespace CarFinance247TechTest.Domain
{
    public class CreateCustomerRequest
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string CustomerPassword { get; set; }
    }
}