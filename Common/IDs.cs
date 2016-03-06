using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class IDs
    {
        public String hour { get; set; }
        public String minute { get; set; }
        public String id1 { get; set; }
        public String id2 { get; set; }
        public String id3 { get; set; }
        public String actionOfID1 { get; set; }
        public String actionOfID2 { get; set; }
        public String actionOfID3 { get; set; }
        public IDs(string hour, string minute, string id1, string id2, string id3, 
            string actionOfID1, string actionOfID2, string actionOfID3)
        {
            this.hour = hour;
            this.minute = minute;
            this.id1 = id1;
            this.id2 = id2;
            this.id3 = id3;
            this.actionOfID1 = actionOfID1;
            this.actionOfID2 = actionOfID2;
            this.actionOfID3 = actionOfID3;
        }
    }
    
}
