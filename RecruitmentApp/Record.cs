using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApp
{
    public class Record
    {
        public string id { get; private set; }
        public string type { get; private set; }


        public Record(string id, string type)
        {
            this.id = id;
            this.type = type;
        }
    }
}