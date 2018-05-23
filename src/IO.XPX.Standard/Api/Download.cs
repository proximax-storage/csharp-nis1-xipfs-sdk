using System;
using System.Collections.Generic;
using System.Text;

using CSharp2nem;
using CSharp2nem.CryptographicFunctions;
using CSharp2nem.Utils;
using Newtonsoft.Json;

using IO.XPX.Standard.Facades;
using IO.XPX.Standard.Facades.model;

namespace IO.XPX.Standard.Api
{
    public interface PeerConnection
    {

    }





    public class Download
    {

        

        private PeerConnection peerConnection;

        

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


            return downloadData;
        }

        public int Test() => 0;

    }
}
