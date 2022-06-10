using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECX.ECXInterface.BE;
using ECX.ECXInterface.DAL;

namespace ECX.ECXInterface.BLL
{
    public class MemberBLL
    {
        #region memberVariables

        #endregion

        /// <summary>
        /// Method that returns Member Detail by Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public DataTable GetMemberDetailByIdInterface(Guid memberId)
        {
            return new MemberDAL().GetMemberDetailByIdInterface(memberId);
        }
      
        /// <summary>
        /// Method that returns Member Detail by Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public IEnumerable<Member> GetMembermemberLicenceDetails(Guid memberId, int BusinessLicenceIdGuid)
        {
            return new MemberDAL().GetMemberLicenceDetails(memberId, BusinessLicenceIdGuid);
        }
        /// <summary>
        /// Method that returns Member Detail by Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public IEnumerable<Member> GetMemberAgreement(Guid memberId)
        {
            return new MemberDAL().GetMemberDetailByIdInterfacememberAgreement(memberId);
        }
        /// <summary>
        /// Method that returns Member Detail by Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public IEnumerable<Member> GetMemberAgreementDetail(Guid memberId, Guid Aggrement)
        {
            return new MemberDAL().GetMemberAgreementDetaildata(memberId, Aggrement);
        }

        public DataTable GetMemberLicenses(Guid memberId)
        {

            return new MemberDAL().GetMemberLicenses(memberId);
        }


        /// <summary>
        /// Method that returns Member Detail by Id
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public Member GetMemberDetailById(Guid memberId)
        {
            return new MemberDAL().GetMemberDetailById(memberId);
        }

        /// <summary>
        /// Method that returns list of all Active Members
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Member> GetAllActiveMembers()
        {
            return new MemberDAL().GetAllActiveMembers();
        }
        public Member GetMemberDetailByIdnO(string Idno)
        {
            return new MemberDAL().GetMemberDetailByIdnO(Idno);
        }
    }
}
