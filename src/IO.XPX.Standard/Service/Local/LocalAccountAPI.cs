using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Service.Interface;
using IO.XPX.Standard.Models;

namespace IO.XPX.Standard.Service.Local
{
    class LocalAccountAPI : AccountAPI
    {
        private readonly NemTransactionAPI nemTransactionAPI;

        public LocalAccountAPI(NemTransactionAPI nemTransactionAPI)
        {
            this.nemTransactionAPI = nemTransactionAPI;
        }

        public string getAllIncomingNemAddressTransactionUsingGET(string publicKey)
        {
            List<>
        }
    }
}
