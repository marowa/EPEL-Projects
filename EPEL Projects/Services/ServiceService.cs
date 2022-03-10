using EPEL_Projects.Data;
using EPEL_Projects.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EPEL_Projects.Services
{
    public class ServiceService
    {
        public List<Service> SelectAllService()
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter["@CompanyID"] = 15;
            DataTable dt = DataAccessLayer.ExecuteSelect("MProc_SelectAllServices", parameter, true);
            List<Service> serviceList = new List<Service>();
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    Service ser = new Service();
                    ser.Service_ID = int.Parse(dt.Rows[i]["Service_ID"].ToString());
                    ser.Service_Name = dt.Rows[i]["Service_Name"].ToString();
                    serviceList.Add(ser);
                }
            }
            return serviceList;
        }

        public Service SelectServiceByServiceID(int id)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter["@ServiceID"] = id;
            DataTable dt = DataAccessLayer.ExecuteSelect("MProc_SelectServiceByServiceID", parameter, true);
            Service service = new Service();
            if (dt.Rows.Count > 0)
            {
                service.Service_Name = dt.Rows[0]["Service_Name"].ToString();
            }
            else
            {
                service.Service_Name = "";
            }
            return service;
        }
    }
}
