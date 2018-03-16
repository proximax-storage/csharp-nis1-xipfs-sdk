# Io.Xpx.Api.PublishAndAnnounceApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnnounceRequestPublishDataSignatureUsingPOST**](PublishAndAnnounceApi.md#announcerequestpublishdatasignatureusingpost) | **POST** /publish/announce | Announce the DataHash to NEM/P2P Storage and P2P Database
[**PublishAndSendSingleFileToAddressUsingPOST**](PublishAndAnnounceApi.md#publishandsendsinglefiletoaddressusingpost) | **POST** /publish/single/to/{address} | Store a single file that can only be access by the given address
[**PublishAndSendSingleFileToAddressesUsingPOST**](PublishAndAnnounceApi.md#publishandsendsinglefiletoaddressesusingpost) | **POST** /publish/single/to/addresses | Store a single file that can only be access by the given addresses


<a name="announcerequestpublishdatasignatureusingpost"></a>
# **AnnounceRequestPublishDataSignatureUsingPOST**
> string AnnounceRequestPublishDataSignatureUsingPOST (RequestAnnounceDataSignature requestAnnounceDataSignature = null)

Announce the DataHash to NEM/P2P Storage and P2P Database

Endpoint that can be use to announce the data hash transaction. This will grab the signed BinaryTransaferTransaction and create the P2P Database Entry for the specific data hash / transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class AnnounceRequestPublishDataSignatureUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new PublishAndAnnounceApi();
            var requestAnnounceDataSignature = new RequestAnnounceDataSignature(); // RequestAnnounceDataSignature | The Request Announce Data Signature Json Format (optional) 

            try
            {
                // Announce the DataHash to NEM/P2P Storage and P2P Database
                string result = apiInstance.AnnounceRequestPublishDataSignatureUsingPOST(requestAnnounceDataSignature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublishAndAnnounceApi.AnnounceRequestPublishDataSignatureUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestAnnounceDataSignature** | [**RequestAnnounceDataSignature**](RequestAnnounceDataSignature.md)| The Request Announce Data Signature Json Format | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishandsendsinglefiletoaddressusingpost"></a>
# **PublishAndSendSingleFileToAddressUsingPOST**
> string PublishAndSendSingleFileToAddressUsingPOST (string xPvkey, string address, string messageType, System.IO.Stream file)

Store a single file that can only be access by the given address

This endpoint can be used to share a file to a specific address only.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class PublishAndSendSingleFileToAddressUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new PublishAndAnnounceApi();
            var xPvkey = xPvkey_example;  // string | The Sender's Private Key
            var address = address_example;  // string | The Receiver's Address without dash ('-')
            var messageType = messageType_example;  // string | Message Type ( PLAIN or SECURE )
            var file = new System.IO.Stream(); // System.IO.Stream | The Multipart File

            try
            {
                // Store a single file that can only be access by the given address
                string result = apiInstance.PublishAndSendSingleFileToAddressUsingPOST(xPvkey, address, messageType, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublishAndAnnounceApi.PublishAndSendSingleFileToAddressUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPvkey** | **string**| The Sender&#39;s Private Key | 
 **address** | **string**| The Receiver&#39;s Address without dash (&#39;-&#39;) | 
 **messageType** | **string**| Message Type ( PLAIN or SECURE ) | 
 **file** | **System.IO.Stream**| The Multipart File | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishandsendsinglefiletoaddressesusingpost"></a>
# **PublishAndSendSingleFileToAddressesUsingPOST**
> string PublishAndSendSingleFileToAddressesUsingPOST (string xPvkey = null, List<string> addresses = null, string messageType = null, System.IO.Stream file = null)

Store a single file that can only be access by the given addresses

This endpoint can be used to exclusively share files across a set of given addresses. This means that the file that's published here can only be viewed or downloaded by the given addresses including the uploader.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class PublishAndSendSingleFileToAddressesUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new PublishAndAnnounceApi();
            var xPvkey = xPvkey_example;  // string | The Sender's Private Key (optional) 
            var addresses = new List<string>(); // List<string> | The List of receiving Addresses without dash ('-') (optional) 
            var messageType = messageType_example;  // string | Message Type ( PLAIN or SECURE ) (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | The Multipart File (optional) 

            try
            {
                // Store a single file that can only be access by the given addresses
                string result = apiInstance.PublishAndSendSingleFileToAddressesUsingPOST(xPvkey, addresses, messageType, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublishAndAnnounceApi.PublishAndSendSingleFileToAddressesUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPvkey** | **string**| The Sender&#39;s Private Key | [optional] 
 **addresses** | [**List&lt;string&gt;**](string.md)| The List of receiving Addresses without dash (&#39;-&#39;) | [optional] 
 **messageType** | **string**| Message Type ( PLAIN or SECURE ) | [optional] 
 **file** | **System.IO.Stream**| The Multipart File | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

