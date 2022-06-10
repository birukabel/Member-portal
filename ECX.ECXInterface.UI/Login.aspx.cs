using ECX.ECXInterface.BE;
using ECX.ECXInterface.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECX.ECXInterface.UI
{
    public partial class Login : System.Web.UI.Page
    {
        static Guid userADID;
        MemberBLL memberBLL = new MemberBLL();
        /// <summary>
        /// Initial  Page entry method like main method for this page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetNoStore();

        }
        //
        protected void LogIn(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Focus();
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Focus();
            }

            if (txtPassword.Text != null && txtUserName.Text != null)
            {
                if (IsAuthenticated(SettingReader.ADPathForRepes, SettingReader.ADDomainNameForRepes, HttpUtility.HtmlEncode(txtUserName.Text), txtPassword.Text, ConfigurationManager.AppSettings["ACDUser"], ConfigurationManager.AppSettings["ACDPass"]))
                {
                    AssigenUserDataToSessionVariable(ConfigurationManager.AppSettings["User1"]);
                }

            }
        }

        /// <summary>
        /// Searching From active Directory 
        /// </summary>
        /// <param name="dirPath"></param>
        /// <param name="_domain"></param>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <param name="_adAdminUser"></param>
        /// <param name="_adAdminPass"></param>
        /// <returns></returns>
        public bool IsAuthenticated(string dirPath, string _domain, string userName, string pwd, string _adAdminUser, string _adAdminPass)
        {
            string domain = _domain;
            string ldapPath = dirPath;
            string adAdminUser = _adAdminUser;//System.Configuration.ConfigurationManager.AppSettings["ACDUser"];
            string adAdminPass = _adAdminPass;//System.Configuration.ConfigurationManager.AppSettings["ACDPass"];

            if (string.IsNullOrEmpty(domain) || string.IsNullOrEmpty(ldapPath))
                return false;
            string domainAndUsername = domain + "\\" + userName;

            try
            {

                #region   
                using (DirectoryEntry entry = new DirectoryEntry(ldapPath, userName, pwd, AuthenticationTypes.Secure | AuthenticationTypes.Sealing))
                {
                    //Bind to the native AdsObject to force authentication.
                    object obj = entry.NativeObject;
                    DirectorySearcher search = new DirectorySearcher(entry);

                    search.Filter = "(sAMAccountName=" + userName + ")";
                    search.PropertiesToLoad.Add("CN");
                    SearchResultCollection results = search.FindAll();
                    if (results == null || results.Count == 0)
                    {//no AD record found
                        return false;
                    }
                    if (results.Count > 1)
                    {//multiple AD records were found
                        results.Dispose();
                        return false;
                    }
                    SearchResult result = results[0];//take the first AD Record

                    if (result != null)
                    {
                        DirectoryEntry userADEntry = result.GetDirectoryEntry();
                        userADID = userADEntry.Guid;

                    }
                    else
                    {
                        return false;
                    }
                    entry.Close();
                    return true;
                }
                #endregion





            }
            catch (DirectoryServicesCOMException ex)
            {
                var s = ex.ExtendedErrorMessage.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (s.Length >= 2)
                {
                    var dataPart = s[s.Length - 2].Trim();//gets 'data xxx'
                    var str = dataPart.Substring(dataPart.IndexOf(' ')).Trim();
                    int d;
                    if (int.TryParse(str, NumberStyles.HexNumber, null, out d))
                    {
                        switch (d)
                        {
                            case 0x525://- user not found
                                AssignTextToNotificationLabel("User is not found.");

                                break;
                            case 0x52e://- invalid credentials
                                AssignTextToNotificationLabel(
                                    "Incorrect User name or Password.");
                                break;
                            case 0x530://- not permitted to logon at this time
                                AssignTextToNotificationLabel(
                                    "It is not permitted to logon at this time.");
                                break;
                            case 0x531://- not permitted to logon at this workstation
                                AssignTextToNotificationLabel("It is not permitted to logon via this workstation.");
                                break;
                            case 0x532://- password expired
                                AssignTextToNotificationLabel("Password is expired.");
                                break;
                            case 0x533://- account disabled
                                AssignTextToNotificationLabel("Account is disabled.");
                                break;
                            case 0x534://- The user has not been granted the requested logon type at this machine
                                AssignTextToNotificationLabel("Requested logon type is not granted at this machine.");
                                break;
                            case 0x701://- account expired
                                AssignTextToNotificationLabel("Account is expired.");
                                break;
                            case 0x773://- user must reset password
                                AssignTextToNotificationLabel("User must reset password.");
                                break;
                            case 0x775://- user account locked
                                AssignTextToNotificationLabel("User account is locked.");
                                break;
                            default:
                                break;
                        }
                    }
                }
                return false;
            }
        }
        /// <summary>
        /// Assign The User data to Session Variable 
        /// </summary>
        /// <param name="_userType"></param>
        public void AssigenUserDataToSessionVariable(string _userType)
        {
            Employees.User user = new Employees.User();
            user.UserName = txtUserName.Text;
            user.UserID = userADID;
            user.UserType = _userType;
            Session["LoggedUser"] = user;
            Session["MemberIds"] = memberBLL.GetMemberDetailByIdnO(user.UserName).MemberId;
            Session["LoggedUserId"] = user.UserID;
            Session["Username"] = user.UserName;
            Session["IDno"] = user.UserName;
            Response.Redirect("~/Default.aspx");

        }
        private void AssignTextToNotificationLabel(string strNotification)
        {
            lblNotification.Text = "";
            lblNotification.ForeColor = Color.Red;
            lblNotification.Text = strNotification;
        }

    }
}