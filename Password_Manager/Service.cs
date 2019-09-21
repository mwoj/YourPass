using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public class Service
    {
        public string service_name;
        public string email;
        public string username;

        public string ServiceName => service_name;
        public string Email => email;
        public string Name => username;
    }
}
