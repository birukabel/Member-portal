using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ECX.ECXInterface.BE;
using ECX.ECXInterface.BLL;
namespace ECX.ECXInterface.UI
{
    /// <summary>
    /// In this class members can get information of  a single client based on the client guid
    /// </summary>
    public partial class ClientDetails : System.Web.UI.Page
    {
        ClientBLL clientBLL = new ClientBLL();
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
                //Check the requested client id is not null, if it's null it will return to previous page
                string ClientId = Request.QueryString["ID"];
                if (ClientId == "" || ClientId == null)
                {
                    Response.Redirect("ClientInfo.aspx");
                }
                Guid clientId = new Guid(ClientId);
                GetOrganiztionData(clientId);
                GetClientBusinessLicence(clientId);
            }
        }
        public void GetOrganiztionData(Guid cientId)
        {
            //Get the client information based on client Guid id 
            IEnumerable<Client> clientDetailInformation = clientBLL.GetClientDetailInformation(cientId);
            List<Client> clientDetails = new List<Client>(clientDetailInformation);
            //if the list is null, return to previous page
            if (clientDetails.Count < 1)
            {
                Response.Redirect("ClientInfo.aspx");
            }
            else
            {
                try
                {
                    //retriving client information to labels and checkbox for user
                    foreach (Client clients in clientDetails)
                    {
                        lblClientId.Text = clients.IDNo;
                        lblClientType.Text = clients.ClientType.ToString();
                        lblFullName.Text = clients.First_Name + " " + clients.Last_Name + " " + clients.Grandfather;
                        lblClientTypeName.Text = clients.ClientTypeName;
                        lblCompanyType.Text = clients.CompanyType;
                        lblIsOnlineTrained.Text = clients.IsOnlineTrained.ToString();
                        lblOrganizationName.Text = clients.OrganizationName;
                        lblOrganizationType.Text = clients.OrganizationType;
                        lblPhoneNumber.Text = clients.Client_Phone;
                        lblStatus.Text = clients.Status;
                        lblTinNo.Text = clients.TIN;
                        lblVatNumber.Text = clients.VATNo;
                        DateTime vatRegDate = Convert.ToDateTime(clients.VATRegDate);
                        string vatRegData2 = string.Format("{0:MMM, dd, yyyy}", vatRegDate);
                        lblVatRegistrationDate.Text = vatRegData2;
                        if (clients.TOTExempt == true)
                        {
                            cbTotExempt.Checked = true;
                        }
                        if (clients.VATExempt == true)
                        {
                            cbVatExempt.Checked = true;
                        }
                        if (clients.WithHoldingExempt == true)
                        {
                            cbWithholdingExempt.Checked = true;
                        }
                        if (clients.IsOnlineTrained == true)
                        {
                            lblOTDDisplay.Text = "Online Training Date : ";
                            lblOTD.Text = clients.IsOnlineTrained.ToString();
                            lblOTEDDisplay.Text = "Online Training Expired Date : ";
                            lblOTED.Text = clients.OnlineTrainingExpiryDate.ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    String message = e.Message;
                    Response.Redirect("DefaultError.aspx? Message=" + message);
                }
            }
        }
        public void GetClientBusinessLicence(Guid clientId)
        {
            //Get the current client business licence information and bind to grid
            IEnumerable<Client> clients = clientBLL.GetBusinessLicenceData(clientId);
            List<Client> listClient = new List<Client>(clients);
            if (listClient.Count > 0)
            {
                gvClientBusinessLicence.DataSource = listClient;
                gvClientBusinessLicence.DataBind();
            }
        }
    }
}