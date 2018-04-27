# Io.Xpx.Api.SearchApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchTransactionWithKeywordUsingGET**](SearchApi.md#searchtransactionwithkeywordusingget) | **GET** /search/by/keywords/{keywords} | Search through all the owners documents to find a content that matches the text specified.
[**SearchTransactionWithMetadataUsingGET**](SearchApi.md#searchtransactionwithmetadatausingget) | **GET** /search/by/metadata | Search through all the owners documents to find a key that matches the specified parameter key


<a name="searchtransactionwithkeywordusingget"></a>
# **SearchTransactionWithKeywordUsingGET**
> List<ResourceHashMessageJsonEntity> SearchTransactionWithKeywordUsingGET (string xPubkey, string keywords)

Search through all the owners documents to find a content that matches the text specified.

This endpoint can only be used to look up publicly available resources (PLAIN Message Types).

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class SearchTransactionWithKeywordUsingGETExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var xPubkey = xPubkey_example;  // string | The Sender or Receiver's Public Key
            var keywords = keywords_example;  // string | Comma delimited Keyword that will be match to the files available

            try
            {
                // Search through all the owners documents to find a content that matches the text specified.
                List&lt;ResourceHashMessageJsonEntity&gt; result = apiInstance.SearchTransactionWithKeywordUsingGET(xPubkey, keywords);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchTransactionWithKeywordUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPubkey** | **string**| The Sender or Receiver&#39;s Public Key | 
 **keywords** | **string**| Comma delimited Keyword that will be match to the files available | 

### Return type

[**List<ResourceHashMessageJsonEntity>**](ResourceHashMessageJsonEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchtransactionwithmetadatausingget"></a>
# **SearchTransactionWithMetadataUsingGET**
> List<ResourceHashMessageJsonEntity> SearchTransactionWithMetadataUsingGET (string xPubkey, string key = null, string value = null)

Search through all the owners documents to find a key that matches the specified parameter key

This endpoint can only be used to look up publicly available resources (PLAIN Message Types).

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class SearchTransactionWithMetadataUsingGETExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var xPubkey = xPubkey_example;  // string | The Sender or Receiver's Public Key
            var key = key_example;  // string | Meta key (optional) 
            var value = value_example;  // string | Meta value (optional) 

            try
            {
                // Search through all the owners documents to find a key that matches the specified parameter key
                List&lt;ResourceHashMessageJsonEntity&gt; result = apiInstance.SearchTransactionWithMetadataUsingGET(xPubkey, key, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchTransactionWithMetadataUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPubkey** | **string**| The Sender or Receiver&#39;s Public Key | 
 **key** | **string**| Meta key | [optional] 
 **value** | **string**| Meta value | [optional] 

### Return type

[**List<ResourceHashMessageJsonEntity>**](ResourceHashMessageJsonEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

