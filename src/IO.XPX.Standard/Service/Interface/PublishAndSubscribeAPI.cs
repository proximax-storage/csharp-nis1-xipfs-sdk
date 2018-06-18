using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Service.Interface
{
    interface PublishAndSubscribeAPI
    {
        Object sendToTopicUsingGET(string topic, string message);

        Object publishTopicUsingGET(string topic, string message);
    }
}
