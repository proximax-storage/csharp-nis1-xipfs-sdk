﻿using System;
using System.Collections.Generic;
using System.Text;

using CSharp2nem;
using CSharp2nem.CryptographicFunctions;
using CSharp2nem.Utils;
using CSharp2nem.Connectivity;
using CSharp2nem.Model;
using CSharp2nem.PrepareHttpRequests;
using CSharp2nem.ResponseObjects.Transaction;

using Newtonsoft.Json;

using System.IO;

using IO.XPX.Standard.Facades;
using IO.XPX.Standard.Facades.model;

namespace IO.XPX.Standard.Facades.Download
{
    class Download
    {
        public Download()
        {

        }

        public Download(PeerConnection peerConnection)
        {
            if (peerConnection == null)
                throw new Exception();


        }


        public DownloadData downloadPlain(string nemHash)
        {
            DownloadData downloadData = new DownloadData();
            byte[] securedResponse = null;

            Transactions.TransactionData transactionMetaDataPair;



            return downloadData;
        }

        public int Test() => 0;
    }
}
