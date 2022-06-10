using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECX.ECXInterface.BE;
using System.Collections;
using System.Data;

namespace ECX.ECXInterface.DAL
{
    public class MemberDAL
    {
        #region memberVariables

        #endregion

        public DataTable GetMemberDetailByIdInterface(Guid memberId)
        {
            string strErrMSg = " ";

            ArrayList parVal = new ArrayList();
            ArrayList parName = new ArrayList();

            parName.Add("@memberId");
            parVal.Add(memberId);
            string spName = "spGetMemberDataByIdInterface";
           // List<Member> lstMemberDetail = new List<Member>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, spName, parName, parVal, ref strErrMSg);
            //if (strErrMSg.Equals(" "))
            //{
            //    lstMemberDetail = DataAccessProvider.ConvertDataTable<Member>(dt);
            //}
            return dt;
        }

 
        #region memberMethods

        /// <summary>
        /// Method that retruns member detail via Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public IEnumerable<Member> GetMemberLicenceDetails(Guid memberId, int BusinessLicenceIdGuid)
        {
            string strErrMSg = " ";

            ArrayList parVal = new ArrayList();
            ArrayList parName = new ArrayList();

            parName.Add("@memberId");
            parVal.Add(memberId);

            parName.Add("@BusinessLicenceIdGuid");
            parVal.Add(BusinessLicenceIdGuid);
            List<Member> lstMemberDetail = new List<Member>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, "GetMemberDataBusinessLidetailInterface", parName, parVal, ref strErrMSg);
            if (strErrMSg.Equals(" "))
            {
                lstMemberDetail = DataAccessProvider.ConvertDataTable<Member>(dt);
            }
            return lstMemberDetail;
        }

        #endregion

        #region memberAgreementMethods

        /// <summary>
        /// Method that retruns member detail via Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public IEnumerable<Member> GetMemberDetailByIdInterfacememberAgreement(Guid memberId)
        {
            string strErrMSg = " ";

            ArrayList parVal = new ArrayList();
            ArrayList parName = new ArrayList();

            parName.Add("@memberId");
            parVal.Add(memberId);
            List<Member> lstMemberDetail = new List<Member>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, "GetMemberDataAgrementByMemberIdInterface", parName, parVal, ref strErrMSg);
            if (strErrMSg.Equals(" "))
            {
                lstMemberDetail = DataAccessProvider.ConvertDataTable<Member>(dt);
            }
            return lstMemberDetail;
        }
        /// <summary>
        /// Method that retruns member detail via Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public IEnumerable<Member> GetMemberAgreementDetaildata(Guid memberId, Guid guidaggrement)
        {
            string strErrMSg = " ";

            ArrayList parVal = new ArrayList();
            ArrayList parName = new ArrayList();

            parName.Add("@memberId");
            parVal.Add(memberId);
            parName.Add("@guidaggrement");
            parVal.Add(guidaggrement);
            List<Member> lstMemberDetail = new List<Member>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, "GetMemberAgreementDetail", parName, parVal, ref strErrMSg);
            if (strErrMSg.Equals(" "))
            {
                lstMemberDetail = DataAccessProvider.ConvertDataTable<Member>(dt);
            }
            return lstMemberDetail;
        }

        #endregion 
        #region memberAgreementMethods

        /// <summary>
        /// Method that retruns member detail via Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public DataTable GetMemberLicenses(Guid memberId)
        {
            string strErrMSg = " ";

            ArrayList parVal = new ArrayList();
            ArrayList parName = new ArrayList();

            parName.Add("@memberId");
            parVal.Add(memberId);
            string spName = "spGetMemberBusinessLicenceData";
            List<Member> lstMemberDetail = new List<Member>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, spName, parName, parVal, ref strErrMSg);
            //if (strErrMSg.Equals(" "))
            //{
            //    lstMemberDetail = DataAccessProvider.ConvertDataTable<Member>(dt);
            //}
            return dt;
        }

        #endregion


        #region memberMethods

        /// <summary>
        /// Method that retruns member detail via Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public Member GetMemberDetailById(Guid memberId)
        {
            string strErrMSg = " ";

            ArrayList parVal = new ArrayList();
            ArrayList parName = new ArrayList();

            parName.Add("@memberId");
            parVal.Add(memberId);
            List<Member> lstMemberDetail = new List<Member>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, "GetMemberDataByIdInterface", parName, parVal, ref strErrMSg);
            if (strErrMSg.Equals(" "))
            {
                lstMemberDetail = DataAccessProvider.ConvertDataTable<Member>(dt);
            }
            return lstMemberDetail[0];
        }

        /// <summary>
        /// Method that returns list of active members
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> GetAllActiveMembers()
        {
            string strErrMSg = " ";

            List<Member> lstAllActiveMembers = new List<Member>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, "spGetAllActiveMembers", ref strErrMSg);
            if (strErrMSg.Equals(" "))
            {
                lstAllActiveMembers = DataAccessProvider.ConvertDataTable<Member>(dt);
            }
            return lstAllActiveMembers;
        }

        #endregion

        public Member GetMemberDetailByIdnO(string name)
        {
            string strErrMSg = " ";

            ArrayList parVal = new ArrayList();
            ArrayList parName = new ArrayList();

            parName.Add("@IDnumber");
            parVal.Add(name);
            List<Member> lstMemberDetail = new List<Member>();

            DataTable dt = DataAccessProvider.ExecuteDataTable(Common.MembershipConnectionString, Common.DboSchema, "spGetMemberIdInterface", parName, parVal, ref strErrMSg);
            if (strErrMSg.Equals(" "))
            {
                lstMemberDetail = DataAccessProvider.ConvertDataTable<Member>(dt);
            }
            return lstMemberDetail[0];
        }
    }
}
