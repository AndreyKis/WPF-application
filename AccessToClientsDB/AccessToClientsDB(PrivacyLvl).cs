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
        public List<AccessLevel> GetUserAccessLevel(int userId, int sphereId)
        {
            /*var accessLvl = (from c in dataBase.user where c.userId == userId select c).FirstOrDefault().privacylvl;
            //var accessLvl = user.privacylvl;
            foreach (var somelvl in accessLvl.)
            {
                
            }
            AccessLevel lvl = new AccessLevel(accessLvl.privacyLvlId, accessLvl.groupNumber, accessLvl.act, 
                accessLvl.agreement, accessLvl.persInfo, accessLvl.columns, accessLvl.letter, accessLvl.payment, accessLvl.redact,
                accessLvl.layout);*/

            var accessLvl = from c in dataBase.user where c.userId == userId select c.privacylvl;
            List<AccessLevel> listOfLevels = new List<AccessLevel>();
            
            foreach (var lvl in accessLvl)
            {
                AccessLevel prLevel = new AccessLevel(lvl.privacyLvlId, lvl.groupNumber);
                switch (sphereId)
                {
                    case 0:
                        prLevel.SetSphere(lvl.persInfo);
                        break;
                    case 1:
                        prLevel.SetSphere(lvl.redact);
                        break;
                    case 2:
                        prLevel.SetSphere(lvl.letter);
                        break;
                    case 3:
                        prLevel.SetSphere(lvl.agreement);
                        break;
                    case 4:
                        prLevel.SetSphere(lvl.layout);
                        break;
                    case 5:
                        prLevel.SetSphere(lvl.payment);
                        break;
                    case 6:
                        prLevel.SetSphere(lvl.act);
                        break;
                    case 7:
                        prLevel.SetSphere(lvl.columnName);
                        break;
                    case 8:
                        prLevel.SetSphere(lvl.columnDepartment);
                        break;
                    case 9:
                        prLevel.SetSphere(lvl.columnCode);
                        break;
                    case 10:
                        prLevel.SetSphere(lvl.columnFullName);
                        break;
                    case 11:
                        prLevel.SetSphere(lvl.columnContacts);
                        break;
                    case 12:
                        prLevel.SetSphere(lvl.columnState);
                        break;
                }
                listOfLevels.Add(prLevel);
            }
            return listOfLevels;
        }
    }
}
