using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Io.Xpx.Facade.Connection
{
    class LocalPeerConnection : IPeerConnection
    {

        public LocalPeerConnection(NodeEndpoint nodeEndpoint)
        {
            //XpxSdkGlobalConstants.setNodeEndpoint(nodeEndpoint);
            //XpxSdkGlobalConstants.setProximaxConnection("/ip4/127.0.0.1/tcp/5001"); // yes, constant.
        }

        public LocalPeerConnection(NodeEndpoint nodeEndpoint, String multiAddress)
        {
            //XpxSdkGlobalConstants.setNodeEndpoint(nodeEndpoint);
            //XpxSdkGlobalConstants.setProximaxConnection(multiAddress);
        }
    }
}
