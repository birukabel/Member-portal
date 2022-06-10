using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECX.ECXInterface.BE
{
    public class Employees
    {
        public List<Employee> LoadEmployeeList()
        {

            //Name = Name.ToUpper();
            List<Employee> empList = new List<Employee>();
            SearchResultCollection results = null;
            DirectoryEntry de = new DirectoryEntry(ConfigurationManager.AppSettings["DirPath"]);
            de.Username = ConfigurationManager.AppSettings["ACDUser"];
            de.Password = ConfigurationManager.AppSettings["ACDPass"];
            DirectorySearcher deSearch = new DirectorySearcher();
            deSearch.SearchRoot = de;
            deSearch.Filter = "(&(objectCategory=user))";
            deSearch.SearchScope = SearchScope.Subtree;
            results = deSearch.FindAll();
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i].GetDirectoryEntry().Properties["CN"].Value != null && results[i].GetDirectoryEntry().Properties["CN"].Value.ToString().Contains(" ") == true
                    && !(results[i].GetDirectoryEntry().Properties["CN"].Value.ToString().ToUpper().Contains("admin".ToUpper())))
                {
                    Employee e = new Employee();
                    e.Name = results[i].GetDirectoryEntry().Properties["CN"].Value.ToString();
                    e.Guid = results[i].GetDirectoryEntry().Guid;
                    e.Photo = null;
                    empList.Add(e);
                }
            }
            empList.Sort();
            return empList;
        }

        public List<Employee> LoadEmployeeListByName(string Name)
        {
            Name = Name.ToUpper();
            List<Employee> empList = new List<Employee>();
            SearchResultCollection results = null;
            DirectoryEntry de = new DirectoryEntry(ConfigurationManager.AppSettings["DirPath"]);
            de.Username = ConfigurationManager.AppSettings["ACDUser"];
            de.Password = ConfigurationManager.AppSettings["ACDPass"];
            DirectorySearcher deSearch = new DirectorySearcher();
            deSearch.SearchRoot = de;
            deSearch.Filter = "(&(objectCategory=user)(anr=" + Name + "))";
            deSearch.SearchScope = SearchScope.Subtree;
            results = deSearch.FindAll();
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i].GetDirectoryEntry().Properties["CN"].Value != null && results[i].GetDirectoryEntry().Properties["CN"].Value.ToString().Contains(" ") == true)
                {
                    if (results[i].GetDirectoryEntry().Properties["CN"].Value.ToString().ToUpper().StartsWith(Name.ToUpper()) == true && !(results[i].GetDirectoryEntry().Properties["CN"].Value.ToString().ToUpper().Contains("admin".ToUpper())))
                    {
                        Employee e = new Employee();
                        e.Name = results[i].GetDirectoryEntry().Properties["CN"].Value.ToString();
                        e.Guid = results[i].GetDirectoryEntry().Guid;
                        e.Photo = null;
                        empList.Add(e);
                    }
                }
            }
            empList.Sort();
            return empList;
        }

        public Employee GetEmployeeNameByGuid(Guid UniqueIdentifier)
        {
            Employee e = new Employee();
            SearchResultCollection results = null;
            DirectoryEntry de = new DirectoryEntry(ConfigurationManager.AppSettings["DirPath"]);
            de.Username = ConfigurationManager.AppSettings["ACDUser"];
            de.Password = ConfigurationManager.AppSettings["ACDPass"];
            DirectorySearcher deSearch = new DirectorySearcher();
            deSearch.SearchRoot = de;
            byte[] byteGuid = UniqueIdentifier.ToByteArray();
            string queryGuid = "";
            foreach (byte b in byteGuid)
            {
                queryGuid += @"\" + b.ToString("x2");
            }
            deSearch.Filter = "(objectGUID=" + queryGuid + ")";
            deSearch.SearchScope = SearchScope.Subtree;
            results = deSearch.FindAll();
            if (results.Count > 0)
            {
                e.Name = results[0].GetDirectoryEntry().Properties["CN"].Value.ToString();
                e.Guid = results[0].GetDirectoryEntry().Guid;
            }
            return e;
        }
        public Employee GetRepNameByGuid(Guid UniqueIdentifier)
        {
            Employee e = new Employee();
            SearchResultCollection results = null;
            DirectoryEntry de = new DirectoryEntry(ConfigurationManager.AppSettings["DirPath2"]);
            de.Username = ConfigurationManager.AppSettings["ACDUser2"];
            de.Password = ConfigurationManager.AppSettings["ACDPass2"];
            DirectorySearcher deSearch = new DirectorySearcher();
            deSearch.SearchRoot = de;
            byte[] byteGuid = UniqueIdentifier.ToByteArray();
            string queryGuid = "";
            foreach (byte b in byteGuid)
            {
                queryGuid += @"\" + b.ToString("x2");
            }
            deSearch.Filter = "(objectGUID=" + queryGuid + ")";
            deSearch.SearchScope = SearchScope.Subtree;
            results = deSearch.FindAll();
            if (results.Count > 0)
            {
                e.Name = results[0].GetDirectoryEntry().Properties["CN"].Value.ToString();
                e.Guid = results[0].GetDirectoryEntry().Guid;
            }
            return e;
        }

        [Serializable]
        public class Employee : IComparable
        {
            Guid _Id;
            string _Name;
            byte[] _Photo;
            public Guid Guid
            {
                get { return this._Id; }
                set { this._Id = value; }
            }
            public string Name
            {
                get { return this._Name; }
                set { this._Name = value; }
            }
            public byte[] Photo
            {
                get { return this._Photo; }
                set { this._Photo = value; }
            }
            public int CompareTo(object obj)
            {
                if (obj is Employee)
                {
                    Employee e = (Employee)obj;
                    return this.Name.CompareTo(e.Name);
                }
                else
                {
                    throw new ArgumentException("object is not an employee");
                }
            }
        }

        public class User
        {
            public User()
            {

            }
            string _userName;
            public string UserName
            {
                get { return _userName; }
                set { _userName = value; }
            }
            Guid _guid;
            public Guid UserID
            {
                get { return _guid; }
                set { _guid = value; }
            }

            string _IDNo;
            public string IDNo
            {
                get { return _IDNo; }
                set { _IDNo = value; }
            }

            string _userType;
            public string UserType
            {
                get { return _userType; }
                set { _userType = value; }
            }
        }
    }
}
