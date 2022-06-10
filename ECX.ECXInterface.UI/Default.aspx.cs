using ECX.ECXInterface.BLL;
using System;
using System.Data;

namespace ECX.ECXInterface.UI
{
    /// <summary>
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        MemberBLL memberBLL = new MemberBLL();
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
                GetMemberData(memberId);
                GetMemberLicenceData(memberId);
            }
        }

        private void GetMemberData(Guid guid)
        {
            DataTable dataTable = memberBLL.GetMemberDetailByIdInterface(guid);
            if (dataTable.Rows.Count < 1)
            {

            }
            try
            {
                DataRow dataRow = dataTable.Rows[0];
                string idNo = dataRow["IDNO"].ToString();
                string organizationName = dataRow["OrganizationName"].ToString();
                string status = dataRow["Status"].ToString();
                string memberClassName = dataRow["MemberClassName"].ToString();
                string classificationName = dataRow["ClassificationName"].ToString();
                string organizationTypeName = dataRow["OrgnTypeName"].ToString();
                string memberClientType = dataRow["MemberClientType"].ToString();
                string vatNo = dataRow["VATNO"].ToString();
                string tinNo = dataRow["TINNO"].ToString();
                string MemberClassName = dataRow["MemberClassName"].ToString();
                string IsNonMember = dataRow["IsNonMember"].ToString();

                string vATexemption = dataRow["VatExempt"].ToString();
                string totExempt = dataRow["TOTExempt"].ToString();

                if (dataRow["IsNonMember"].ToString()=="True")
                    lblMemberType.Text = "True";
               else
                    lblMemberType.Text = "False";

                lblClassificationName.Text = classificationName;
                lblMemberClassName.Text = memberClassName;
                lblMemberClientType.Text = memberClientType;
                lblMemberId.Text = idNo;
                lblOrganizationName.Text = organizationName;
                lblOrganizationTypeName.Text = organizationTypeName;
                lblStatus.Text = status;
                lblTinNumber.Text = tinNo;
                lblVatNumber.Text = vatNo;

                lblVATexemption.Text = vATexemption;
                Label1.Text = totExempt;
            }
            catch (Exception e)
            {
                lblError.Text = "<h2 class='text-center' style='color:red'>Error : </h2/>" + e.Message;
            }
        }
        public void GetMemberLicenceData(Guid guid)
        {
            DataTable dataTable = memberBLL.GetMemberLicenses(guid);
            gvMemberLicence.DataSource = dataTable;
            gvMemberLicence.DataBind();
        }
    }
}