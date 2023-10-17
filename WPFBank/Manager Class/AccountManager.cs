using System.Collections.Generic;
using WPFBank.Interface;

namespace WPFBank.Manager_Class
{
    static class AccountManager
    {
        public static List<IAccount> clientAccountList { get; set; } = new();
    }
}
