using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPEL_Projects.Models
{
    public class Service
    {
        public int Service_ID { get; set; }
        public int Service_CompanyID { get; set; }
        public string Service_Name { get; set; }
        public int Service_DeleteStatus { get; set; }
    }
}
