using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ECX.ECXInterface.UI
{
    public class SettingReader
    {
        #region PropertiesToEnableEmployeesToLogIn

        public static string ADPathForEmployees
        {
            get
            {
                string domainPath = ConfigurationManager.AppSettings["DirPath"];

                return domainPath;
            }
        }

        public static string ADDomainNameForEmployees
        {
            get
            {
                string domainName = ConfigurationManager.AppSettings["domain"];

                return domainName;
            }
        }

        public static string ACDUserForEmployees
        {
            get
            {
                string user = ConfigurationManager.AppSettings["ACDUser"];
                return user;
            }
        }

        public static string ACDPwdForEmployees
        {
            get
            {
                string pwd = ConfigurationManager.AppSettings["ACDPass"];
                return pwd;
            }
        }

        #endregion

        #region PropertiesToEnableRepresentativesToLogIn

        public static string ADPathForRepes
        {
            get
            {
                string domainPath = ConfigurationManager.AppSettings["DirPath2"];

                return domainPath;
            }
        }

        public static string ADDomainNameForRepes
        {
            get
            {
                string domainName = ConfigurationManager.AppSettings["domain2"];

                return domainName;
            }
        }

        public static string ACDUserForRepes
        {
            get
            {
                string user = ConfigurationManager.AppSettings["ACDUser2"];
                return user;
            }
        }

        public static string ACDPwdForRepes
        {
            get
            {
                string pwd = ConfigurationManager.AppSettings["ACDPass2"];
                return pwd;
            }
        }
        public static string ACDPwdForMemberId
        {
            get
            {
                string pwd = ConfigurationManager.AppSettings["DirPathMembers"];
                return pwd;
            }
        }

        #endregion

    }
}