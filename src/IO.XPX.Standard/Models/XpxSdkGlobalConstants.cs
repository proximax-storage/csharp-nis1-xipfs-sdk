using System;
using System.Collections.Generic;
using System.Text;
using CSharp2nem.Model.Mosaics;
using CSharp2nem.Connectivity;
using CSharp2nem.Utils;
namespace IO.XPX.Standard.Models
{
    class XpxSdkGlobalConstants
    {
        //fusestubfs
        //fusestubfs

        public static readonly DateTime TIME_PROVIDER = new DateTime();

        private static string ipfsMountPoint = "/ipfs";

        private static string ipnsMountPoint = "/ipns";

        public static readonly string URL_WS_W_MESSAGES = "/w/messages";

        public static readonly string URL_WS_W_API_ACCOUNT_SUBSCRIBE = "/w/api/account/subscribe";

        public static readonly string URL_WS_TRANSACTIONS = "/transactions";

        public static readonly string URL_WS_UNCONFIRMED = "/unconfirmed";

        public static readonly string WS_PORT = "7778";

        public static readonly string[] GLOBAL_GATEWAYS
            = { "https://ipfs.io", "https://gateway.ipfs.io" };

    }
}
