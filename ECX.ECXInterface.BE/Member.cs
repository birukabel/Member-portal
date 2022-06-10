using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.ECXInterface.BE
{
    public class Member
    {
        #region Member
        // MemberId
        public Guid MemberId { get; set; }
        public string IDNO { get; set; }
        public string Status { get; set; }
        public string StatusChangeReason { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int SecondaryStatus { get; set; }
        public Guid TransactionId { get; set; }
        public string BankStatus { get; set; }
        public string BankStatusChangedBy { get; set; }
        public bool NoClubContribution { get; set; }
        public int MemberClientTypeId { get; set; }

        public string MemberClassName { get; set; }
        public Guid OrganizationId { get; set; }
        public int MemberClass { get; set; }
        public Guid CommodityId { get; set; }
        public int ClassificationId { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid LanguagePreference { get; set; }
        public DateTime LastAnnualPaymentDate { get; set; }
        public string Note { get; set; }
        public int OldId { get; set; }
        public int GhostClientId { get; set; }
        public bool TempAuthorityApproved { get; set; }
        public DateTime TempAuthorityApprovedDate { get; set; }
        public int OnlineStatusId { get; set; }

        #endregion

        #region Orginazation type

        public string OrgnTypeName { get; set; }
        public string Description { get; set; }
        #endregion

        #region Organization
        public string OrganizationName { get; set; }
        public int OrganizationType { get; set; }
        public string Organization_Status { get; set; }
        public string TradeAs { get; set; }
        public int NoOfFarmers { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string VATNo { get; set; }
        public string TINNo { get; set; }
        public DateTime VATRegistrationDate { get; set; }
        public bool VatExempt { get; set; }
        public bool TOTExepmt { get; set; }
        public bool WithHoldingExepmt { get; set; }

        #endregion

        #region Individual
        public Guid PersonId { get; set; }
        public int BusinessType { get; set; }
        #endregion
        public Guid ClientId { get; set; }

        public string ClientName { get; set; }
        public string SettingName { get; set; }
        public Guid AggreementId { get; set; }
        public int SettingId { get; set; }
        public bool Active { get; set; }
        public string FormNumber { get; set; }
        public Guid DocumentId { get; set; }
        public bool IsSTP { get; set; }
        public string Remark { get; set; }
        public Guid RepresentativeID { get; set; }
        public bool HasChangedAgreement { get; set; }
        public string Symbol { get; set; }
        public string CompanyType { get; set; }
        public string CClient_Phone { get; set; }
        public string OrganizationTypeName { get; set; }
        #region
        public int BusinessLicenceId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Expiration { get; set; }
        public DateTime COCExpirationDate { get; set; }
        public string Name { get; set; }
        #endregion

        public string ClassificationName { get; set; }
        public string MemberClientType { get; set; }

        public bool IsNonMember { get; set; }
        public string IsMember { get; set; }
    }
}
