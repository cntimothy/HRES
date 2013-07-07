using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class UserInfo
    {
        #region Private Field
        string id;
        string name;
        AccessLevel accessLevel;
        string depart;
        #endregion

        #region Public Field
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public AccessLevel AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }

        public string Depart
        {
            get { return depart; }
            set { depart = value; }
        }
        #endregion
    }
}
