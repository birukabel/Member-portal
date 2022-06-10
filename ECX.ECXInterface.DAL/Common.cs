using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.ECXInterface.DAL
{
    public class Common
    {
        #region memberProperties
        public static string DboSchema
        {
            get
            {
                return "dbo";
            }
        }

        public static string OnlineSchema
        {
            get
            {
                return "Online";
            }
        }

        public static string OutcrySchema
        {
            get
            {
                return "Outcry";
            }
        }

        public static string CDConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["dbCentralDepositoryConnectionString"].ConnectionString;
            }
        }

        public static string CNSConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["CNSConnectionString"].ConnectionString;
            }
        }

        public static string MembershipConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["MembershipConnectionString"].ConnectionString;
            }
        }

        public static string TradeConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["TradeConnectionString"].ConnectionString;
            }
        }

        public static string WorkingLanguage
        {
            get
            {
                return ConfigurationManager.AppSettings["WorkingLanguage"];
            }
        }

        public static string ECXIFConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ECXIFConnectionString"].ConnectionString;
            }
        }

        public static string LookUpConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["LookupConnectionString"].ConnectionString;
            }
        }      


        #endregion
    }
}
