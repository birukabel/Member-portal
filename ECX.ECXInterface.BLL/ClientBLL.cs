using System;
using System.Collections.Generic;
using ECX.ECXInterface.DAL;
using ECX.ECXInterface.BE;
using System.Data;

namespace ECX.ECXInterface.BLL
{
    /// <summary>
    ///  Client Business logic layer Class to get the member clients list and detail information
    /// </summary>
    public class ClientBLL
    {
        /// <summary>
        ///returns list of clients information list based on member id
        /// </summary>
        /// <param name="memberID"></param>
        /// <returns></returns>
        public IEnumerable<Client> GetClientInformation(Guid memberID)
        {
            return new ClientDAL().GetClientInformation(memberID);
        }
        public IEnumerable<Client> GetSearchClient(string toSearch,Guid memberID)
        {
            return new ClientDAL().GetSearchClient(toSearch,memberID);
        }
        

        /// <summary>
        /// returns one record of client detail 
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public IEnumerable<Client> GetClientDetailInformation(Guid clientId)
        {
            return new ClientDAL().GetClientDetailInformation(clientId); 
        }
        /// <summary>
        /// Returns one record of client business licence information
        /// </summary>
        /// <param name="clientID"></param>
        /// <returns></returns>
        public IEnumerable<Client> GetBusinessLicenceData(Guid clientID)
        {
            return new ClientDAL().GetBusinessLicenceData(clientID);
        }
        
    }
}
