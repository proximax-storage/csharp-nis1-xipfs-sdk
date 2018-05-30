using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Facades
{
    abstract class AbstractAsyncFacadeService
    {
        protected ResourceHashMessage byteToSerialObject(byte[] object)
        {
            ResourceHashMessage resourceMessage = ResourceHashMessage
                    .getRootAsResourceHashMessage(ByteBuffer.wrap(Base64.decodeBase64(object)));
            return resourceMessage;
        }
    }
}
