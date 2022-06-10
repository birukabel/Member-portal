using ECX.ECXInterface.BE;
using ECX.ECXInterface.BLL;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace ECX.ECXInterface.UI
{
    /// <summary>
    /// Class for returning client information based on Member id
    /// </summary>
    public partial class ClientInfo : System.Web.UI.Page
    {
        //
        ClientBLL clientBLL = new ClientBLL();
        /// <summary>
        /// In this page client information will bind to grid value based on member id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private Guid memberIdForTest;
        private Guid _memId;
        private Guid memberId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["LoggedUserId"]) != null)
            {
                _memId = new Guid(Session["MemberIds"].ToString());
                memberIdForTest = new Guid(Session["MemberIds"].ToString());
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            GetClientInformation();
        }
        /// <summary>
        ///Get clients information based on member id
        /// </summary>
        public void GetClientInformation()
        {
            IEnumerable<Client> data = clientBLL.GetClientInformation(memberIdForTest);
            List<Client> clientData = new List<Client>(data);
            if (clientData.Count > 0)
            {
                gvClientInfo.DataSource = clientData;
                gvClientInfo.DataBind();
                gvClientInfo.UseAccessibleHeader = true;
                gvClientInfo.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            else
            {
                lblNoDataFound.Text = "<h2> No Client Data Found Please Try later!</h2>";
            }
        }
        /// <summary>
        /// // display current number of table indexs and total table index as caption for user on the bottom of the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Determine the RowIndex of the Row whose Button was clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string toSearch = txtSearch.Text;
            if (toSearch != null)
            {
                Response.Redirect("~/ClientInfoSearch.aspx?search=" + (toSearch));
            }
            else
            {
                Response.Redirect("~/ClientInfo.aspx");
            }
        }

        //protected void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    string toSearch = txtSearch.Text;
        //    IEnumerable<Client> data = clientBLL.GetSearchClient(toSearch,memberIdForTest);
        //    List<Client> clientData = new List<Client>(data);
        //    if (clientData.Count > 0)
        //    {
        //        gvClientInfo.DataSource = clientData;
        //        gvClientInfo.DataBind();
        //    }
        //    else
        //    {
        //        lblNoDataFound.Text = "<h2> No Client Data Found Please Try later!</h2>";
        //    }

        //}

        //protected void gvClientInfo_DataBound(object sender, EventArgs e)
        //{
        //    GridViewRow row = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Normal);
        //    for (int i = 0; i < gvClientInfo.Columns.Count; i++)
        //    {
        //        TableHeaderCell tableHeaderCell = new TableHeaderCell();
        //        TextBox Search = new TextBox();
        //        if(gvClientInfo.Columns[i].HeaderText == "Client Id")
        //        {
        //            Search.Attributes["placeholder"] = gvClientInfo.Columns[i].HeaderText;
        //            Search.CssClass = "search_class";
        //            tableHeaderCell.Controls.Add(Search);
        //            row.Controls.Add(tableHeaderCell);
        //        }
        //    }
        //    gvClientInfo.HeaderRow.Parent.Controls.AddAt(1, row);
        //}
    }
}


//<system.web>
//  <customErrors mode = "On" defaultRedirect="DefaultError.aspx">
//    <error statusCode = "404" redirect="PageNotFound.aspx"/>
//    <error statusCode = "500" redirect="InternalServerError.aspx"/>
//  </customErrors>
//</system.web>