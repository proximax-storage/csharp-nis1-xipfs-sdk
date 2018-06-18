using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Models;

namespace IO.XPX.Standard.Service.Interface
{
    interface TransactionAndAnnounceAPI
    {
        string announceRequestPublishDataSignatureUsingPOST(RequestAnnounceDataSignature requestAnnounceDataSignature);

        string getXPXTransactionUsingGET(string nemHash);
    }
}
