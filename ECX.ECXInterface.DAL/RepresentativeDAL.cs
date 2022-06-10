
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using ECX.ECXInterface.BE;

namespace ECX.ECXInterface.DAL
{
    /// <summary>
    /// Representative Data Acesss Logic Class to Get Member's Reperesentative list and Each Representative Detail's.
    /// </summary>
    public class RepresentativeDAL
    {
        #region RepresentativeMethods

        /// <summary>
        /// Method that returns list of All Active  Repersentative 
        /// </summary>
        /// <returns> List<Representative></returns>
        public IEnumerable<Representative> GetAllActiveRepersentative()
        {
            string strErrMSg = " ";
            List<Representative> lstRepersentative= new List<Representative>();

            DataTable dtRepersentative = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, "spGetAllActiveRepresentative", ref strErrMSg);

            if (strErrMSg.Equals(" "))
            {
                lstRepersentative = DataAccessProvider.ConvertDataTable<Representative>(dtRepersentative);
            }
            return lstRepersentative;

        }

        /// <summary>
        /// Method that retruns Representative list via memberId
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns>IEnumerable<Representative></returns>
        public IEnumerable<Representative> GetRepListByMemberId(Guid memberId)
        {
            string strErrMSg = " ";

            ArrayList parVal = new ArrayList();
            ArrayList parName = new ArrayList();

            parName.Add("@MemberID");
            parVal.Add(memberId);
            List<Representative> lstMemberDetail = new List<Representative>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, "spGetMemberlistBymemberId", parName, parVal, ref strErrMSg);
            if (strErrMSg.Equals(" "))
            {
                lstMemberDetail = DataAccessProvider.ConvertDataTable<Representative>(dt);
            }
            return lstMemberDetail;
        }

        /// <summary>
        /// Method to get Representative Detail from database.
        /// </summary>
        /// <param name="IdNo"></param>
        /// <param name="memberId"></param>
        /// <returns>DataTable</returns>
        public DataTable GetRepDetailByMemberId(string IdNo, Guid memberId)
        {
            string strErrMSg = " ";

            ArrayList parVal = new ArrayList();
            ArrayList parName = new ArrayList();

            parName.Add("@IdNo");
            parName.Add("@memberId");

            parVal.Add(IdNo);
            parVal.Add(memberId);
            // List<Representative> lstRepDetail = new List<Representative>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, "spGetRepDetailBymemberId&Idno", parName, parVal, ref strErrMSg);
            //if (strErrMSg.Equals(" "))
            //{
            //    lstRepDetail = DataAccessProvider.ConvertDataTable<Representative>(dt);

            //}

            return dt;
        }
        #endregion
    }
}
