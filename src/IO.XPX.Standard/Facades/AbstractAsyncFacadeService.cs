using System;
using System.Collections.Generic;
using System.Text;
using IO.XPX.Standard.Models.Buffers;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FlatBuffers;

namespace IO.XPX.Standard.Facades
{
    abstract class AbstractAsyncFacadeService
    {
        protected ResourceHashMessage byteToSerialObject(byte[] btye_object)
        {
            ResourceHashMessage resourceMessage = ResourceHashMessage
                    .getRootAsResourceHashMessage(ResourceHashMessage.convertToByteBufferObj(btye_object));

            return resourceMessage;
        }
    }
}
