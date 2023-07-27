using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Entities
{
    public class DirectoryRegistration
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumberI { get; set; }
        public string PhoneNumberII { get; set; }
        public string PhoneNumberIII { get; set; }
        public string Adress { get; set; }
        public string EmailAdress { get; set; }
        public string WebSite { get; set; }
        public string Explanation { get; set; }
        public override string ToString() // override to string 
        {
            return $"{Name} {Surname}";
        }
    }
}
