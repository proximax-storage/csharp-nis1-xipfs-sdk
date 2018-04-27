# Io.Xpx.Api.TransactionAndAnnounceApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnnounceRequestPublishDataSignatureUsingPOST**](TransactionAndAnnounceApi.md#announcerequestpublishdatasignatureusingpost) | **POST** /transaction/announce | Announce the DataHash to NEM/P2P Storage and P2P Database
[**GetXPXTransactionUsingGET**](TransactionAndAnnounceApi.md#getxpxtransactionusingget) | **GET** /transaction/get/{nemHash} | Get the XPX Transaction Hash


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
            var apiInstance = new TransactionAndAnnounceApi();
            var requestAnnounceDataSignature = new RequestAnnounceDataSignature(); // RequestAnnounceDataSignature | The Request Announce Data Signature Json Format (optional) 

            try
            {
                // Announce the DataHash to NEM/P2P Storage and P2P Database
                string result = apiInstance.AnnounceRequestPublishDataSignatureUsingPOST(requestAnnounceDataSignature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionAndAnnounceApi.AnnounceRequestPublishDataSignatureUsingPOST: " + e.Message );
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

<a name="getxpxtransactionusingget"></a>
# **GetXPXTransactionUsingGET**
> string GetXPXTransactionUsingGET (string nemHash)

Get the XPX Transaction Hash

Endpoint can be used to get XPX Transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GetXPXTransactionUsingGETExample
    {
        public void main()
        {
            var apiInstance = new TransactionAndAnnounceApi();
            var nemHash = nemHash_example;  // string | XPX Transaction Hash

            try
            {
                // Get the XPX Transaction Hash
                string result = apiInstance.GetXPXTransactionUsingGET(nemHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionAndAnnounceApi.GetXPXTransactionUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemHash** | **string**| XPX Transaction Hash | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

