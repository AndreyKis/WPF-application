using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Contact
    {
        public int ID { get; private set; }
        public String RealContact { get; private set; }
        public String CountryCode { get; private set; }
        public String OperatorCode { get; private set; }
        public int CompanyId { get; private set; }
        public int HolderId { get; private set; }
        public int ContactType { get; private set; }

        public Contact()
        {
            
        }

        public Contact(int id, int companyId, string realContact, int holderId, int contacttype)
        {
            //These 2 fields must be initialised in separate method
            CountryCode = "+7";
            OperatorCode = "495";
            ID = id;
            CompanyId = companyId;
            RealContact = realContact;
            HolderId = holderId;
            ContactType = contacttype;
        }
    }
}
