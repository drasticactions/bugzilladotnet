using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugzillaDotNet.Exception
{
    public class ManagerException : System.Exception
    {
        public ManagerException()
        {
        }

        public ManagerException(string message)
            : base(message)
        {
        }
    }
}
