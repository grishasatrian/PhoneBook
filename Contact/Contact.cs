using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contact
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Contact(string name, string email, string phone, string address)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
        }
    }
}
