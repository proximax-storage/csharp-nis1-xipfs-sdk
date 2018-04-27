# Io.Xpx.Api.PublishAndSubscribeApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PublishTopicUsingGET**](PublishAndSubscribeApi.md#publishtopicusingget) | **GET** /pubsub/init/{topic} | Publish and Subscribe. Make sure that the IPFS daemon has pubsub enabled.
[**SendToTopicUsingGET**](PublishAndSubscribeApi.md#sendtotopicusingget) | **GET** /pubsub/send/to/{topic} | Send a message to a published topic


<a name="publishtopicusingget"></a>
# **PublishTopicUsingGET**
> Object PublishTopicUsingGET (string topic, string message = null)

Publish and Subscribe. Make sure that the IPFS daemon has pubsub enabled.

Publish and Subscribe. Make sure that the IPFS daemon has pubsub enabled.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class PublishTopicUsingGETExample
    {
        public void main()
        {
            var apiInstance = new PublishAndSubscribeApi();
            var topic = topic_example;  // string | Topic
            var message = message_example;  // string | Initial Message (optional) 

            try
            {
                // Publish and Subscribe. Make sure that the IPFS daemon has pubsub enabled.
                Object result = apiInstance.PublishTopicUsingGET(topic, message);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublishAndSubscribeApi.PublishTopicUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topic** | **string**| Topic | 
 **message** | **string**| Initial Message | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtotopicusingget"></a>
# **SendToTopicUsingGET**
> Object SendToTopicUsingGET (string topic, string message = null)

Send a message to a published topic

Publish and Subscribe. Make sure that the IPFS daemon has pubsub enabled.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class SendToTopicUsingGETExample
    {
        public void main()
        {
            var apiInstance = new PublishAndSubscribeApi();
            var topic = topic_example;  // string | Topic
            var message = message_example;  // string | Initial Message (optional) 

            try
            {
                // Send a message to a published topic
                Object result = apiInstance.SendToTopicUsingGET(topic, message);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublishAndSubscribeApi.SendToTopicUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topic** | **string**| Topic | 
 **message** | **string**| Initial Message | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

