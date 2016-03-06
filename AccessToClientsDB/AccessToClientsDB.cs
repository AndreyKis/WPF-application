using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToClientsDB
{
    public partial class AccessToClientsDB
    {
        
        clientdbEntities dataBase = new clientdbEntities();
        /*
        public AccessToClientsDB()
        {
            dataBase.company.Load();
            dataBase.user.Load();
            dataBase.contact.Load();
            dataBase.department.Load();
            dataBase.contactholder.Load();
            dataBase.privacylvl.Load();
        }*/
    }
}
