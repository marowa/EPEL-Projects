using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPEL_Projects.Models
{
    public class Region
    {
        public int Region_ID { get; set; }
        public int Region_CompanyID { get; set; }
        public int Region_GovernorateID { get; set; }
        public string Region_ArName { get; set; }
        public string Region_EnName { get; set; }
        public int Region_DeleteStatus { get; set; }

    }
}
