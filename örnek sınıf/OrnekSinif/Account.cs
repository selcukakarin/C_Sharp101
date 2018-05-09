using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekSinif
{
    class Account
    {
        public Account()
        {

        }

        public string GetAccount(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                //işlem yap
            }
            if (!string.IsNullOrWhiteSpace(userName))
            {
                //işlem yap
            }

            return "Selçuk Akarın";
        }

        public string GetAccount(int userId)
        {
            string result = string.Empty;

            if (userId > 0)
            {
                //..
                result = "Selçuk";
            }
            else
            {
                throw new Exception("Hata!");
            }
            return result;
        }

    }
}
