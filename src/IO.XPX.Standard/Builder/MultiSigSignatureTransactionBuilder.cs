using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Connection;

namespace IO.XPX.Standard.Builder
{


    class MultiSigSignatureTransactionBuilder
    {
        private MultiSigSignatureTransactionBuilder() { }

        public interface IPeerConnection
        {

        }

        public static IPeerConnection peerConnection(PeerConnection peerConnection)
        {
            return new MultiSigSignatureTransactionBuilder.Builder(peerConnection);
        }

    }
}
