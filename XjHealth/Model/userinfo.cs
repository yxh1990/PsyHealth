using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjHealth.Model
{
    public class Userinfo
    {
        private string name;
        private int id;
        private string picPath;
        private string code;
        private string logonName;
        private int age;
        private DateTime birthday;
        private int deptClassId;
        private string edu;
        private string nation;
        private string native2;
        private int roleId;
        private string roleName;
        private string sex;
        private string deptInfo;
        private string auxProps;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string PicPath
        {
            get
            {
                return picPath;
            }

            set
            {
                picPath = value;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string LogonName
        {
            get
            {
                return logonName;
            }

            set
            {
                logonName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public int DeptClassId
        {
            get
            {
                return deptClassId;
            }

            set
            {
                deptClassId = value;
            }
        }

        public string Edu
        {
            get
            {
                return edu;
            }

            set
            {
                edu = value;
            }
        }

        public string Nation
        {
            get
            {
                return nation;
            }

            set
            {
                nation = value;
            }
        }

        public string Native2
        {
            get
            {
                return native2;
            }

            set
            {
                native2 = value;
            }
        }

        public int RoleId
        {
            get
            {
                return roleId;
            }

            set
            {
                roleId = value;
            }
        }

        public string RoleName
        {
            get
            {
                return roleName;
            }

            set
            {
                roleName = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public string DeptInfo
        {
            get
            {
                return deptInfo;
            }

            set
            {
                deptInfo = value;
            }
        }

        public string AuxProps
        {
            get
            {
                return auxProps;
            }

            set
            {
                auxProps = value;
            }
        }
    }
}
