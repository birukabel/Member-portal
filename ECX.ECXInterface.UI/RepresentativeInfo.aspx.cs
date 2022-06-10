using System;
using System.Web.UI.WebControls;
using ECX.ECXInterface.BLL;

namespace ECX.ECXInterface.UI
{
    /// <summary>
    ///Class for Returning Member's Representative List
    /// </summary>
    public partial class RepresentativeInfo : System.Web.UI.Page
    {
        //private attribute created for get record from session.
        private Guid _empId;
        private Guid _memId;

        /// <summary>
        /// On page load Login user memberId or EmployeeId record read from session and representative list bind to grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["LoggedUserId"]) != null)
            {
                _empId = new Guid(Session["LoggedUserId"].ToString());
                _memId = new Guid(Session["MemberIds"].ToString());
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            if (!IsPostBack)
            {
                BindGrid();


            }
        }

        /// <summary>
        /// Member's Representative List from business logic class object bind to GridView1 on view.
        /// </summary>
        private void BindGrid()
        {
            RepresentativeBLL replist = new RepresentativeBLL();
            GridView1.DataSource = replist.GetRepresentativeListByMemberId(_memId);
            
            GridView1.DataBind();

        }
        protected void gvRepresentative_prerender(object sender, EventArgs e)
        {
            lblRepresentativeInfo.Text = "Display page" + (GridView1.PageIndex + 1).ToString() + " of " + GridView1.PageCount.ToString();
        }

        /// <summary>
        /// Page Changing event handler .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        /// <summary>
        /// Detail button Event handler.To redirect to RepresentativeDetails.aspx with parameter Idno from view passed,
        /// _memId from session.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            // Determine the RowIndex of the Row whose Button was clicked.
            int rowIndex = ((sender as LinkButton).NamingContainer as GridViewRow).RowIndex;

            //Get the value of column from the DataKeys using the RowIndex.
            string Idno = GridView1.DataKeys[rowIndex].Values[0].ToString();
            if (Idno != null)
            {
                
                Response.Redirect(String.Format("~/RepresentativeDetails.aspx?IdNo={0}&MemberId={1}", Idno, _memId));
            }
        }
        
        
    }
}