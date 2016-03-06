using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ActionRights
    {
        //public int Sphere { get; private set; }
        public string GroupName { get; private set; }
        //public int SphereNumber { get; private set; }
        public Boolean[] Rights { get; private set; }

        public ActionRights(string group, int sphereNumber, Boolean[] rights)
        {
            
        }
    }
}
