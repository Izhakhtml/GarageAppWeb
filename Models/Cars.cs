using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageAppWeb.Models
{
    public class Cars
    {
        public int ID { get; set; }
        public string NameOwner { get; set; }
        public int CarNumber { get; set; }
        public bool IfPastTest { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}