using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPEL_Projects.Models
{
    public class Governorate
    {
        public int Governorate_ID { get; set; }
        public int Governorate_CompanyID { get; set; }
        public string Governorate_ArName { get; set; }
        public string Governorate_EnName { get; set; }
        public int Governorate_DeleteStatus { get; set; }
    }
}
