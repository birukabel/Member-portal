using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECX.ECXInterface.UI
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = HttpContext.Current.Request.Url.AbsolutePath;
                SetCurrentPage();
        }
        /// <summary>
        /// The below method set a current page by coloring the navigation link(Button)  
        ///  
        /// </summary>
        private void SetCurrentPage()
        {
            var pagename = Convert.ToString(GetPageName());
            switch (pagename)
            {
                case "default.aspx":
                    homeLink.Attributes["class"] = "current";
                    break;
                case "Default.aspx":
                    homeLink.Attributes["class"] = "current";
                    break;
                case "ClientInfo.aspx":
                    clientLink.Attributes["class"] = "current";
                    break;
                case "ClientDetails.aspx?/d":
                    clientLink.Attributes["class"] = "current";
                    break;
                case "RepresentativeInfo.aspx":
                    repLink.Attributes["class"] = "current";
                    break;
                case "RepresentativeDetails.aspx?/d":
                    repLink.Attributes["class"] = "current";
                    break;
            }
        }
        /// <summary>
        /// Get current url 
        /// </summary>
        /// <returns>Url</returns>
        private object GetPageName()
        {
            return Request.Url.ToString().Split('/').Last();
        }
        protected void Logout(object sender, EventArgs e)
        {
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx");
        }
    }
}