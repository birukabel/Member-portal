using ECX.ECXInterface.BE;
using ECX.ECXInterface.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECX.ECXInterface.UI
{
    public partial class ClientInfoSearch : System.Web.UI.Page
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
            string toSearch = Request.QueryString["search"];
            if (toSearch == "" || toSearch == null)
            {
                Response.Redirect("ClientInfo.aspx");
            }
           
            SearchClient(toSearch,memberId);
        }
       
        public void SearchClient(string toSearch,Guid memberId)
        {

            IEnumerable<Client> data = clientBLL.GetSearchClient(toSearch, memberId);
            List<Client> clientData = new List<Client>(data);
            if (clientData.Count > 0)
            {
                gvClientInfo.Visible = true;
                gvClientInfo.DataSource = clientData;
                gvClientInfo.DataBind();
                gvClientInfo.UseAccessibleHeader = true;
                gvClientInfo.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                gvClientInfo.Visible = false;
                lblNoDataFound.Text = "<h2> No Client Data Found!</h2>";
            }
        }
        protected void gvClientInfo_prerender(object sender, EventArgs e)
        {
            lbClientInfo.Text = "Display page " + (gvClientInfo.PageIndex + 1).ToString() + " of " + gvClientInfo.PageCount.ToString();
        }
        /// <summary>
        ///  Get the next page index when user click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvClientInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvClientInfo.PageIndex = e.NewPageIndex;
            gvClientInfo.DataBind();
        }
        protected void gvClientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowIndex = ((sender as LinkButton).NamingContainer as GridViewRow).RowIndex;

            //Get the value of column from the DataKeys using the RowIndex.
            string clientId = gvClientInfo.DataKeys[rowIndex].Values[0].ToString();
            if (clientId != null)
            {
                Response.Redirect("~/ClientDetails.aspx?Id=" + (clientId));
            }
            else
            {
                Response.Redirect("~/ClientInfo.aspx");
            }
        }
    }
}