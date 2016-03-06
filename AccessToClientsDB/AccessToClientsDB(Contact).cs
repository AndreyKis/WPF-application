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
        /*public List<Contact> GetAllTelephones()
        {

            List<Contact> list = new List<Contact>();
            foreach (var currTel in dataBase.telephone)
            {
                Contact prTelephone = new Contact(currTel.telephoneId, "+" + currTel.telCountryCode, currTel.telOperatorCode);
                foreach (var telNumber in currTel.company.telephone)
                {
                    prTelephone.SetTelephones(telNumber.ToString());
                }
                list.Add(prTelephone);
            }
            return list;

        }*/
    }
}
