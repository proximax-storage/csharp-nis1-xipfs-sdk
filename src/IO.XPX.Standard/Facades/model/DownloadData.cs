using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Models.Buffers;

namespace IO.XPX.Standard.Facades.model
{
    [System.Serializable]
    public class DownloadData
    {
        private static readonly long serialVersionUID = 1L;

        private ResourceHashMessage dataMessage;

        private byte[] data;

        private int messageType;

        public ResourceHashMessage getDataMessage()
        {
            return dataMessage;
        }

        public void setDataMessage(ResourceHashMessage dataMessage)
        {
            this.dataMessage = dataMessage;
        }

        public byte[] getDate()
        {
            return data;
        }

        public void setData(byte[] data)
        {
            this.data = data;
        }

        public int getMessageType()
        {
            return messageType;
        }

        public void setMessageType(int messageType)
        {
            this.messageType = messageType;
        }

        public static long getSerializationuid()
        {
            return serialVersionUID;
        }


    }
}
