using EPEL_Projects.Data;
using EPEL_Projects.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EPEL_Projects.Services
{
    public class GovernorateService
    {
        public List<Governorate> selectAllGovernments(int CompID)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter["@CompanyID"] = CompID;
            DataTable dt = DataAccessLayer.ExecuteSelect("MBProc_SelectAllGovernorate", parameter, true);
            List<Governorate> governments = new List<Governorate>();
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    Governorate gov = new Governorate();
                    gov.Governorate_ID = int.Parse(dt.Rows[i]["Governorate_ID"].ToString());
                    gov.Governorate_ArName = dt.Rows[i]["Governorate_ArName"].ToString();
                    gov.Governorate_EnName = dt.Rows[i]["Governorate_EnName"].ToString(); ;
                    governments.Add(gov);                    
                }
            }
            return governments;
        }

        public Governorate selectGovernmentByID(int GovID)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter["@GovernorateID"] = GovID;
            DataTable dt = DataAccessLayer.ExecuteSelect("MBProc_SelectGovernorateDataByGovernorateID", parameter, true);
            Governorate gov = new Governorate();
            if (dt.Rows.Count > 0)
            {
                gov.Governorate_ArName = dt.Rows[0]["Governorate_ArName"].ToString();
                gov.Governorate_EnName = dt.Rows[0]["Governorate_EnName"].ToString();
            }
            else
            {
                gov.Governorate_ArName = "";
                gov.Governorate_EnName = "";
            }
            return gov;
        }

        public int insertGovernment(Governorate gover)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter["@CompanyID"]=15;
            parameter["@UserID"]=1030;
            parameter["@ArName"]=gover.Governorate_ArName;
            parameter["@EnName"]="";

            int rows = DataAccessLayer.ExecuteDML("MBProc_InsertGovernorate", parameter, true);
            return rows;
        }

        public int deleteGovernment(int id,Governorate gov)
        {
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter["@CompanyID"] = 15;
            parameter["@UserID"] = 1030;
            //parameter["@GovernorateID"] = gov.Governorate_ID;
            parameter["@GovernorateID"] = id;

            int rows = DataAccessLayer.ExecuteDML("MBProc_DeleteGovernorate", parameter, true);
            return rows;
        }
    }
}
