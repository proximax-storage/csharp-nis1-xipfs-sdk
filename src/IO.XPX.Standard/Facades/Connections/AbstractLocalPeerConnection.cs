using System;
using System.Collections.Generic;
using System.Text;
using CSharp2nem.ResponseObjects.Node;
using IO.XPX.Standard.Service.Interface;
using IO.XPX.Standard.Service;

namespace IO.XPX.Standard.Facades.Connections
{
    class AbstractLocalPeerConnection : PeerConnection
    {
        private readonly Endpoint nodeEndpoint;

        //ipfs here

        private AccountAPI accountAPI;

        private DataHashAPI dataHashAPI;

        private DownloadAPI downloadAPI;

        private NodeAPI nodeApi;

        private PublishAndSubscribeAPI publishAndSubscribeAPI;

        private SearchAPI searchAPI;

        private TransactionAndAnnounceAPI transactionAndAnnounceAPI;

        private UploadAPI uploadAPI;

        //Default async nem connector <APIID>

        private NemTransactionAPI nemTransactionAPI;

        private NemAccountAPI nemAccountAPI;

        private TransactionSender transactionSender;

        private TransactionFeeCalculators transactionFeeCalculators;
    }
}
