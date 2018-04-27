# Io.Xpx.Api.DataHashApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateHashForDataOnlyUsingPOST**](DataHashApi.md#generatehashfordataonlyusingpost) | **POST** /datahash/hash-only | Generates the datahash but doesn&#39;t upload the file on the network


<a name="generatehashfordataonlyusingpost"></a>
# **GenerateHashForDataOnlyUsingPOST**
> string GenerateHashForDataOnlyUsingPOST (byte[] data)

Generates the datahash but doesn't upload the file on the network

This endpoint can be used to generates the datahash and uploads the file in the process.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GenerateHashForDataOnlyUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DataHashApi();
            var data = data_example;  // byte[] | Free form string data that will be stored on the P2P Network

            try
            {
                // Generates the datahash but doesn't upload the file on the network
                string result = apiInstance.GenerateHashForDataOnlyUsingPOST(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataHashApi.GenerateHashForDataOnlyUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | **byte[]**| Free form string data that will be stored on the P2P Network | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

