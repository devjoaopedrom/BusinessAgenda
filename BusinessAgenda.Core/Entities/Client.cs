using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAgenda.Core.Entites
{
    public class Client : BaseEntity
    {
        public Client(string fullName, string email, string contact, string address)
        {
            FullName = fullName;
            Email = email;
            Contact = contact;
            Address = address;
            ClientMeetings = [];
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Contact { get; private set; }
        public string Address { get; private set; }
        public List<string> ClientMeetings { get; private set; }
    }
}
