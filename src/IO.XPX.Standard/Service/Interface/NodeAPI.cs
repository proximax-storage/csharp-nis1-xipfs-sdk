using System;
using System.Collections.Generic;
using System.Text;
using CSharp2nem.ResponseObjects;

namespace IO.XPX.Standard.Service.Interface
{
    interface NodeAPI
    {
        SuperNodes.NodeDetail getNodeInfoPeersUsingGET();

        SuperNodes.NodeDetail getNodeInfoUsingGET();
    }
}
