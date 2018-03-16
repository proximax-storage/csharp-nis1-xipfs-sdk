# Io.Xpx.Api.NodeApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckNodeUsingGET**](NodeApi.md#checknodeusingget) | **GET** /node/check | Check if the Storage Node is up and running.
[**GetNodeInfoUsingGET**](NodeApi.md#getnodeinfousingget) | **GET** /node/info | Get Storage Node Information
[**SetBlockchainNodeConnectionUsingPOST**](NodeApi.md#setblockchainnodeconnectionusingpost) | **POST** /node/set/blockchain/connection | Get Storage Node Information


<a name="checknodeusingget"></a>
# **CheckNodeUsingGET**
> GenericResponseMessage CheckNodeUsingGET ()

Check if the Storage Node is up and running.

This endpoint is used to check if the P2P Storage Node instance is either alive or down.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class CheckNodeUsingGETExample
    {
        public void main()
        {
            var apiInstance = new NodeApi();

            try
            {
                // Check if the Storage Node is up and running.
                GenericResponseMessage result = apiInstance.CheckNodeUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.CheckNodeUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GenericResponseMessage**](GenericResponseMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodeinfousingget"></a>
# **GetNodeInfoUsingGET**
> NodeInfo GetNodeInfoUsingGET ()

Get Storage Node Information

This endpoint returns the information of the P2P Storage Node

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GetNodeInfoUsingGETExample
    {
        public void main()
        {
            var apiInstance = new NodeApi();

            try
            {
                // Get Storage Node Information
                NodeInfo result = apiInstance.GetNodeInfoUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.GetNodeInfoUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NodeInfo**](NodeInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setblockchainnodeconnectionusingpost"></a>
# **SetBlockchainNodeConnectionUsingPOST**
> string SetBlockchainNodeConnectionUsingPOST (string network, string domain, string port)

Get Storage Node Information

This endpoint returns the information of the P2P Storage Node

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class SetBlockchainNodeConnectionUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new NodeApi();
            var network = network_example;  // string | Blockchain Network
            var domain = domain_example;  // string | Blockchain Network Domain (xxx.xxx.xxx)
            var port = port_example;  // string | Blockchain Network Port (xxx.xxx.xxx)

            try
            {
                // Get Storage Node Information
                string result = apiInstance.SetBlockchainNodeConnectionUsingPOST(network, domain, port);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NodeApi.SetBlockchainNodeConnectionUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **network** | **string**| Blockchain Network | 
 **domain** | **string**| Blockchain Network Domain (xxx.xxx.xxx) | 
 **port** | **string**| Blockchain Network Port (xxx.xxx.xxx) | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

