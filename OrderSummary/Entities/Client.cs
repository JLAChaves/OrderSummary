using System;

namespace OrderSummary.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            BirthDate = date;
        }

        public override string ToString()
        {
            return ($"Client: {Name} ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}");
        }
    }
}
