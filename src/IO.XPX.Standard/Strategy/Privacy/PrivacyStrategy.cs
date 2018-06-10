using System;
using System.Collections.Generic;
using IO.XPX.Standard.Models;
using System.Text;
using CSharp2nem.Utils;
using CSharp2nem.Model.Transfer;
using IO.XPX.Standard.Models.Buffers;
namespace IO.XPX.Standard.Strategy.Privacy
{
    
    public abstract class PrivacyStrategy
    {
        public abstract NemMessageType.eNemMessageType GetNemMessageType();

        public abstract byte[] encrypt(byte[] data);

        public abstract byte[] decrypt(byte[] data, ResourceHashMessage hashMessage); //TransferTransaction

        //public //Message encodeToMessage(byte[] payload);

        public abstract byte[] decodeTransaction(); //TransferTransaction

    }
}
