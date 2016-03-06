using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace AccessToClientsDB
{
    public partial class AccessToClientsDB
    {
        public List<Company> GetAllCompanies()
        {
            List<Company> list = new List<Company>();
            foreach (var currCompany in dataBase.company)
            {
                int code = currCompany.companyCode.HasValue ? currCompany.companyCode.Value : -1;
                DateTime date = currCompany.companyDate.HasValue
                    ? currCompany.companyDate.Value
                    : new DateTime();
                var companyContact = from c in dataBase.company_contact where c.ccCompanyId == currCompany.companyId select c;
                foreach (var currCompanyContact in companyContact)
                {
                    var contacts = (from c in dataBase.contact where c.contactId == currCompanyContact.ccContactId select c).FirstOrDefault();
                    Contact contact = new Contact(contacts.contactId, currCompany.companyId, contacts.contact1, contacts.holderId, 
                        contacts.contactType);
                }
                //var user = from c in dataBase.company where c.userId
                /*Company company = new Company(currCompany.companyId, currCompany.companyName, code, 
                    currCompany.companyPayment, currCompany.companyEdition, currCompany.department.name, currCompany.companyHead,
                    currCompany.companyDate, currCompany.companyComment, )*/
                Contact telephones = new Contact();
                //var ratesUsedInRate = from c in dataBase.Rate where c.rrate_name == rate.Name select c;
                
                //list.Add(company);
            }
            return list;
        }
    }
}
