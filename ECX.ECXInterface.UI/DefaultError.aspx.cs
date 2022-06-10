using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECX.ECXInterface.UI
{
    public partial class DefaultError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string message = Request.QueryString["Message"];
            lblError.Text = message;
             
        }
    }
}