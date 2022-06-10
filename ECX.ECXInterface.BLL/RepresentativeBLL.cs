
using System;
using System.Data;
using System.Collections.Generic;
using ECX.ECXInterface.BE;
using ECX.ECXInterface.DAL;

namespace ECX.ECXInterface.BLL
{
    /// <summary>
    /// Representative Business Logic Class Pass Reperesentaive list and Detail innformation.
    /// </summary>
    public class RepresentativeBLL
    {
        /// <summary>
        /// Method that returns  Member's Representative List by MemberId
        /// </summary>
        /// <param name=" RepresentativeId"></param>
        /// <returns>IEnumerable<Representative></returns>
        public IEnumerable<Representative> GetRepresentativeListByMemberId(Guid MemberId)
        {
            return new RepresentativeDAL().GetRepListByMemberId(MemberId);
        }

        /// <summary>
        /// Method for returning Reperesentative Details.
        /// </summary>
        /// <param name="IdNo"></param>
        /// <param name="memberId"></param>
        /// <returns>DataTable</returns>
        public DataTable GetRepresentativeDetails(string IdNo, Guid memberId)
        {
            return new RepresentativeDAL().GetRepDetailByMemberId(IdNo, memberId);
        }

        /// <summary>
        /// Method that returns list of all Active Representative
        /// </summary>
        /// <returns>IEnumerable<Representative></returns>
        public IEnumerable<Representative> GetAllActiveRepresentative()
        {
            return new RepresentativeDAL().GetAllActiveRepersentative();
        }
    }
}
