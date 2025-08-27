using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace passmng
{
    public static class Session
    {
        public static int? CurrentUserId { get; set; }
        public static SecureString? masterPassword { get; set; }
    }
}
