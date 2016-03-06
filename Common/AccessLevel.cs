using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class AccessLevel
    {
        public int Id { get; private set; }
        public string GroupName {get; private set; }
        public Boolean[] Rights { get; private set; }
        //public List<ActionRights> Rights { get; private set; }

        /*public AccessLevel(int id, int groupID, Int16 act, Int16 agreement, Int16 persInfo, Int16 columns, Int16 letter,
            Int16 payment, Int16 redact, Int16 layout)
        {
            string groupName = "Своя база";
            if (groupID != 0)
                groupName = "Группа " + groupID;
            
            ActionRights right = new ActionRights(groupName, 0, TransformToBool(act));
        }*/


        public AccessLevel()
        {
        }


        public AccessLevel(int id, int groupId, Int16 sphere)
        {
            Id = id;
            GroupName = "Своя база";
            if (groupId != -1)
                GroupName = "Группа " + groupId;
            Rights = TransformToBool(sphere);
        }
        public AccessLevel(int id, int groupId)
        {
            Id = id;
            GroupName = "Своя база";
            if (groupId != 0)
                GroupName = "Группа " + groupId;
        }

        public void SetSphere(Int16 sphere)
        {
            Rights = TransformToBool(sphere);
        }
        public Boolean[] TransformToBool(Int16 value)
        {
            String stringBoolValue = Convert.ToString(value, 2);
            Boolean[] result = new bool[stringBoolValue.Length];
            int i = 0;
            foreach (char c in stringBoolValue.ToCharArray())
            {
                if ("1".Equals(c.ToString()))
                    result[i] = true;
                else
                    result[i] = false;
                i++;

            }
            return result;
        }
    }
}
