using System;
using System.ComponentModel.DataAnnotations;

namespace ECX.ECXInterface.BE
{
    /// <summary>
    /// Representative Model 
    /// </summary>
    public class Representative
    {
        [Display(Name = "Representative Name")]
        public string Repname { get; set; }

        [Display(Name = "Representative Id No")]
        public string IdNo { get; set; }

        [Display(Name = "Certificate No")]
        public string CertificateNo { get; set; }

        [Display(Name = "Representative Type")]
        public string RepType { get; set; }

        [Display(Name = "Online Certificate No")]
        public string OnlineCertificateNo { get; set; }

        [Display(Name = "Member Name")]
        public string membername { get; set; }
        public string Status { get; set; }

        public string OnlineStatus { get; set; }
        public bool    IsOnlineCertified { get; set; }
        public DateTime?   OnlineCertificateExpiryDate { get; set; }
        public DateTime?  AuctionCertificateExpiryDate { get; set; }
        public bool   IsAuctionCertified { get; set; }
        public string  AuctionStatus { get; set; }
        public string Email { get; set; }

        [Display(Name = "Mobile Number")]
        public string PhoneMob { get; set; }

        [Display(Name = "Phone Office")]
        public string PhoneOffice { get; set; }

        [Display(Name = "Phone Home")]
        public string PhoneHome { get; set; }
        public string Fax { get; set; }
        public string City { get; set; }
        public Guid Zone { get; set; }
        public Guid Region { get; set; }
        public Guid Woreda { get; set; }
        public string Kebele { get; set; }
        public string HouseNo { get; set; }
        public string Description { get; set; }
    }
}
