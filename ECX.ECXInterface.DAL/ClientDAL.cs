using ECX.ECXInterface.BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.ECXInterface.DAL
{
    /// <summary>
    /// Client Data Access Logic class which interact with database through DataAccessLayer.cs class
    /// In this class all arguments are prepared and ready for database server
    /// </summary>
    public class ClientDAL
    {
        /// <summary>
        /// Returns list of client information 
        /// </summary>
        /// <param name="memberID"></param>
        /// <returns></returns>
        public IEnumerable<Client> GetClientInformation(Guid memberID)
        {
            string strErrMSg = " ";
            ArrayList parameter = new ArrayList();
            ArrayList value = new ArrayList();
            parameter.Add("@memberId");
            value.Add(memberID);
            string procedureName = "spGetClientInformation";
            List<Client> listClient = new List<Client>();
            DataTable data = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, procedureName, parameter, value, ref strErrMSg);
            if (strErrMSg.Equals(" "))
            {
                listClient = DataAccessProvider.ConvertDataTable<Client>(data);
            }
            return listClient;
        }

        public IEnumerable<Client> GetSearchClient(string toSearch,Guid memberID)
        {
            string strErrMSg = " ";
            ArrayList parameter = new ArrayList();
            ArrayList value = new ArrayList();
            parameter.Add("@searchInput");
            parameter.Add("@memberId");
            
            value.Add(toSearch);
            value.Add(memberID);
            
            string procedureName = "spSearchClient";
            List<Client> listClient = new List<Client>();
            DataTable data = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, procedureName, parameter, value, ref strErrMSg);
            if (strErrMSg.Equals(" "))
            {
                listClient = DataAccessProvider.ConvertDataTable<Client>(data);
            }
            return listClient;
        }
        /// <summary>
        /// Returns a Detail record of single client information 
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public IEnumerable<Client> GetClientDetailInformation(Guid clientId)
        {
            string strErrMSg = " ";
            string procedureName = "spGetClientDetailInfomation";

            ArrayList parameter = new ArrayList();
            ArrayList value = new ArrayList();
            parameter.Add("@clientId");
            value.Add(clientId);
            List<Client> listClient = new List<Client>();
            DataTable data = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, procedureName, parameter, value, ref strErrMSg);
            if (strErrMSg == " ")
            {
                listClient = DataAccessProvider.ConvertDataTable<Client>(data);
            }
            return listClient;
        }
        /// <summary>
        /// Returns a business licence data of a single client record
        /// </summary>
        /// <param name="clientID"></param>
        /// <returns></returns>
        public IEnumerable<Client> GetBusinessLicenceData(Guid clientID)
        {
            string strErrorMSg = " ";
            string procedureName = "spGetClientBusinessLicence";
            ArrayList parameter = new ArrayList();
            ArrayList value = new ArrayList();
            parameter.Add("@clientId");
            value.Add(clientID);
            List<Client> listClient = new List<Client>();
            DataTable data = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, procedureName, parameter, value, ref strErrorMSg);
            if (strErrorMSg == " ")
            {
                listClient = DataAccessProvider.ConvertDataTable<Client>(data);
            }

            return listClient;
        }
    }
}
