
using System;
using System.Data;
using ECX.ECXInterface.BLL;

namespace ECX.ECXInterface.UI
{
    /// <summary>
    ///Class for Returning Representative Details
    /// </summary>
    public partial class RepresentativeDetails : System.Web.UI.Page
    {
        // Representative Business Logical class object created 
        RepresentativeBLL representativeBLL = new RepresentativeBLL();

        /// <summary>
        /// On page load RepresentativeID and MemberId retrieved and pass to  GetRepresentativeDetails(Idno, memberId2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private Guid _empId;
        private Guid _memId;
        private Guid memberId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["LoggedUserId"]) != null)
            {
                _empId = new Guid(Session["LoggedUserId"].ToString());
                _memId = new Guid(Session["MemberIds"].ToString());
                memberId = new Guid(Session["MemberIds"].ToString());
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            if (!IsPostBack)
            {
                string Idno = Request.QueryString["IdNo"];
                string memberId = Request.QueryString["memberId"];
                Guid memberId2 = new Guid(memberId);
                if (Idno == "" || Idno == null)
                {
                    Response.Redirect("~/RepresentativeInfo.aspx");

                }
                GetRepresentativeDetails(Idno, memberId2);
            }
        }

        /// <summary>
        /// GetRepresentativeDetails to pass Repersentative detail records to the view 
        /// </summary>
        /// <param name="Idno"></param>
        /// <param name="membeId"></param>
        public void GetRepresentativeDetails(string Idno, Guid membeId)
        {
            //Representative record passed from business logical to datable
            DataTable repdataTable = representativeBLL.GetRepresentativeDetails(Idno, membeId);

            //repdataTable passed to view lable
            if (repdataTable.Rows.Count < 1)
            {
                Response.Redirect("RepresentativeInfo.aspx");
            }
            try
            {
                DataRow dataRow = repdataTable.Rows[0];
                string repId = dataRow["IDNO"].ToString();
                string onlineCertificateNumber = dataRow["OnlineCertificateNo"].ToString();
                string certifcateNumber = dataRow["CertificateNo"].ToString();
                string memberName = dataRow["MemberName"].ToString();
                string repName = dataRow["RepName"].ToString();
                string repType = dataRow["RepType"].ToString();
                string repTypeDescription = dataRow["RepTypeDescription"].ToString();
                string city = dataRow["City"].ToString();
                string email = dataRow["EMail"].ToString();
                string fax = dataRow["Fax"].ToString();
                string kebele = dataRow["Kebele"].ToString();
                string houseNumber = dataRow["HouseNo"].ToString();
                string phoneNumberHome = dataRow["PhoneHome"].ToString();
                string region = dataRow["Region"].ToString();
                string phoneNumberMobile = dataRow["PhoneMob"].ToString();
                string woreda = dataRow["Woreda"].ToString();
                string zone = dataRow["Zone"].ToString();
                string phoneOffice = dataRow["PhoneOffice"].ToString();
                string auctionCertificateExpireDate = string.Format("{0:MMM dd, yyyy}", dataRow["AuctionCertificateExpiryDate"]).ToString();
                string auctionCertificateIssueDate = string.Format("{0:MMM dd, yyyy}", dataRow["AuctionCertificateIssueDate"]).ToString();
                string auctionCertificateNo = dataRow["AuctionCertificateNo"].ToString();
                string onlineCertificateExpireDate = string.Format("{0:MMM dd, yyyy}", dataRow["OnlineCertificateExpiryDate"]).ToString();
                string onlineCertificateExpireDate1 = string.Format("{0:MMM dd, yyyy}", dataRow["OnlineCertificateExpiryDate1"]).ToString();
                string onlineCertificateIssueDate = string.Format("{0:MMM dd, yyyy}", dataRow["OnlineCertificateIssueDate"]).ToString();
                string onlineStatus = dataRow["AuctionStatus"].ToString();

                lblAuctionCertificateNumber.Text = auctionCertificateIssueDate;
                lblAuctionCertificateIssueDate.Text = auctionCertificateIssueDate;
                lblAuctionExpireDate.Text = auctionCertificateExpireDate;
                lblCertificateNumber.Text = certifcateNumber;
                lblCity.Text = city;
                lblEmail.Text = email;
                lblFax.Text = fax;
                lblHouseNumber.Text = houseNumber;
                lblKebele.Text = kebele;
                lblMemberName.Text = memberName;
                lblMopilePhoneNumber.Text = phoneNumberMobile;
                lblOCN.Text = onlineCertificateNumber;
                lblOfficePhoneNumber.Text = phoneOffice;
                lblOnlineCertificateExpireDate.Text = onlineCertificateExpireDate;
                lblOnlineCertificateExpireDate1.Text = onlineCertificateExpireDate1;
                lblOnlineCertificateIssueDate.Text = onlineCertificateIssueDate;
                lblOnlineStatus.Text = onlineStatus;
                lblPhoneNumber.Text = phoneNumberHome;
                lblRegion.Text = region;
                lblRepId.Text = repId;
                lblRepName.Text = repName;
                lblRepType.Text = repType;
                lblRepTypeDescription.Text = repTypeDescription;
                lblWoreda.Text = woreda;
                lblZone.Text = zone;
            }
            catch (Exception e)
            {
                string exeptionError = e.Message;

            }

        }
       
        //Back Button to reture to Reperesentative list 
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("RepresentativeInfo.aspx");
        }
    }
}