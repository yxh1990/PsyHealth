using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjHealth.Model
{
   public class ResultInfo
    {
        private string resultcode;
        private string resultmsg;
        private string id;

        public string Resultcode
        {
            get
            {
                return resultcode;
            }

            set
            {
                resultcode = value;
            }
        }

        public string Resultmsg
        {
            get
            {
                return resultmsg;
            }

            set
            {
                resultmsg = value;
            }
        }

        public string Id
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
    }
}
