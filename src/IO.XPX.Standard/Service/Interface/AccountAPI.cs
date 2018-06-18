using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Models;

namespace IO.XPX.Standard.Service.Interface
{
    interface AccountAPI
    {
        string getAllIncomingNemAddressTransactionsUsingGET(string publicKey);

        string getAllNemAddressTransactionsUsingGET(string publicKey);

        string getAllNemAddressTransactionsWithPageSizeUsingGet(string publicKey, string pageSize); //why not int?

        string getAllOutgoingNemAddressTransactionsUsingGet(string publicKey);

        string getAllUnconfirmedNemAddressTransactionsUsingGET(string publicKey);

        AccountMetaDataPair getNemAddressDetailsUsingGET(string publicKey)
    }
}
