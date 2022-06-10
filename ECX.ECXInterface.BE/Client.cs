using System;

namespace ECX.ECXInterface.BE
{
    /// <summary>
    /// A Client Business Entity logic class the below properties are client data which are map with database columns
    /// and each rows are identical in data type and declaration variables with database columns
    /// </summary>
    public class Client
    {
        
        public Guid ClientId { get; set; }
        public string IDNo { get; set; }
        public string OrganizationName { get; set; }
        public string Status { get; set; }
        public int MemberClientId { get; set; }
        public bool NoClubContribution { get; set; }
        public string VATINO { get; set; }
        public string VATNo { get; set; }
        public string TIN { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Grandfather { get; set; }
        public string OrganizationType { get; set; }
        public string Client_Phone { get; set; }
        public int ClientType { get; set; }
        public int ClientTypeId { get; set; }
        public string MemberClientType { get; set; }
        public string CompanyType { get; set; }
        public string CommodityName { get; set; }
        public bool IsSTP { get; set; }
        public bool HasChangedAgreement { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime VATRegDate { get; set; }
        public bool VATExempt { get; set; }
        public bool TOTExempt { get; set; }
        public bool WithHoldingExempt { get; set; }
        public string ClientTypeName { get; set; }
        public bool IsOnlineTrained { get; set; }
        public DateTime OnlineTrainingExpiryDate { get; set; }
        public DateTime OnlineTrainingDate { get; set; }
        public int BussinessLicenceId { get; set; }
        public DateTime COCExpirationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
