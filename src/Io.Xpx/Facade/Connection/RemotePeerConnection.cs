using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Io.Xpx.Facade.Connection
{
    class RemotePeerConnection : IPeerConnection
    {

   
        public RemotePeerConnection(String baseUrl)
        {
            //Configuration.setDefaultApiClient(new ApiClient().setBasePath(baseUrl));
        }

  
        public RemotePeerConnection setPeerBaseUrl(String baseUrl)
        {
            //Configuration.setDefaultApiClient(new ApiClient().setBasePath(baseUrl));
            return this;
        }
    }
}
