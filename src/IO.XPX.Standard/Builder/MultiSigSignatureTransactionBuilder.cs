using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Connection;
using CSharp2nem.ResponseObjects.Account;
using CSharp2nem.ResponseObjects.Transaction;
using CSharp2nem.Utils;
using CSharp2nem.Model.MultiSig;

namespace IO.XPX.Standard.Builder
{


    class MultiSigSignatureTransactionBuilder
    {
        private MultiSigSignatureTransactionBuilder() { }

        public interface IPeerConnection
        {
            virtual ISigner multisig(AccountForwarded.Account multisig)
        }

        public static IPeerConnection peerConnection(PeerConnection peerConnection)
        {
            return new MultiSigSignatureTransactionBuilder.Builder(peerConnection);
        }

        public interface ISigner
        {
            ITransaction signer(AccountForwarded.Account signer);

            ITransaction addSigners(List<AccountForwarded.Account> signers);

            ITransaction endAssignSigners();

            ISigner startAssignSigners();

            ISigner AddSigners(List<AccountForwarded.Account> signers);
        }

        public interface ITransaction
        {
            IBuild otherTransaction(Transactions.Transaction transaction);

            IBuild otherTransaction(Transactions.Hash hashTransaction);
        }

        public interface IBuild
        {
            IBuild timeStamp(TimeDateUtils timeInstance);

            IBuild signBy(AccountForwarded.Account account);

            IBuild fee(Amount amount);

            IBuild feeCalculator(TransactionFeeCalculator feeCalculator);

            IBuild deadline(TimeDateUtils timeInstance);

            IBuild signature(Transactions.Signature signature);

            // MultisigTransaction -- must find it on the code....
            // same with completablefuture<Deserializer>
        }

        private static class Builder : IPeerConnection, ISigner, ITransaction, IBuild
        {
            
            public static ISigner startAssignSigners()
            {
                return this;
            }

            public  ITransaction endAssignSingers()
            {
                return this;
            }

            private static PeerConnection peerConnection;

            //TimeDateUtils is already static

            private static AccountForwarded.Account multisig;

            private static Transactions.OtherTrans otherTransaction;

            private static Transactions.Hash hashTransaction;

            private static Transactions.Signature signature;

            private static Amount fee;

            

       }





    }
}
