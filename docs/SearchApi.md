# Io.Xpx.Api.SearchApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchContentUsingAllNemHashUsingGET**](SearchApi.md#searchcontentusingallnemhashusingget) | **GET** /search/all/content/hash/{nemHash} | Search through all the owner&#39;s documents to find a content that matches the text specified.
[**SearchContentUsingPublicNemHashUsingGET**](SearchApi.md#searchcontentusingpublicnemhashusingget) | **GET** /search/public/content/hash/{nemHash} | Search through all the owner&#39;s documents to find a content that matches the text specified.
[**SearchContentUsingTextUsingGET**](SearchApi.md#searchcontentusingtextusingget) | **GET** /search/public/content/{text} | Search through all the owner&#39;s documents to find a content that matches the text specified.
[**SearchDataHashUsingPublicNemHashUsingGET**](SearchApi.md#searchdatahashusingpublicnemhashusingget) | **GET** /search/public/content/hashonly/{nemHash} | Search through all the owner&#39;s documents to find the data hash that matches the nemhash specified.
[**SearchTransactionPvKeyWithKeywordUsingGET**](SearchApi.md#searchtransactionpvkeywithkeywordusingget) | **GET** /search/all/content/keyword/{keywords} | Search through all the owners documents to find a content that matches the text specified.
[**SearchTransactionWithKeywordUsingGET**](SearchApi.md#searchtransactionwithkeywordusingget) | **GET** /search/public/content/keyword/{keywords} | Search through all the owners documents to find a content that matches the text specified.
[**SearchTransactionWithMetadataUsingGET**](SearchApi.md#searchtransactionwithmetadatausingget) | **GET** /search/public/content/metadata/{text} | Search through all the owners documents to find a key that matches the specified parameter key


<a name="searchcontentusingallnemhashusingget"></a>
# **SearchContentUsingAllNemHashUsingGET**
> string SearchContentUsingAllNemHashUsingGET (string xPvkey, string nemHash)

Search through all the owner's documents to find a content that matches the text specified.

This endpoint can only be used to look up publicly available resources (PLAIN and SECURE Message Types).

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class SearchContentUsingAllNemHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var xPvkey = xPvkey_example;  // string | The Sender or Receiver's Public Key
            var nemHash = nemHash_example;  // string | NEM Hash that will be matched to the files available

            try
            {
                // Search through all the owner's documents to find a content that matches the text specified.
                string result = apiInstance.SearchContentUsingAllNemHashUsingGET(xPvkey, nemHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchContentUsingAllNemHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPvkey** | **string**| The Sender or Receiver&#39;s Public Key | 
 **nemHash** | **string**| NEM Hash that will be matched to the files available | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcontentusingpublicnemhashusingget"></a>
# **SearchContentUsingPublicNemHashUsingGET**
> string SearchContentUsingPublicNemHashUsingGET (string xPubkey, string nemHash)

Search through all the owner's documents to find a content that matches the text specified.

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
    public class SearchContentUsingPublicNemHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var xPubkey = xPubkey_example;  // string | The Sender or Receiver's Public Key
            var nemHash = nemHash_example;  // string | NEM Hash that will be matched to the files available

            try
            {
                // Search through all the owner's documents to find a content that matches the text specified.
                string result = apiInstance.SearchContentUsingPublicNemHashUsingGET(xPubkey, nemHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchContentUsingPublicNemHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPubkey** | **string**| The Sender or Receiver&#39;s Public Key | 
 **nemHash** | **string**| NEM Hash that will be matched to the files available | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcontentusingtextusingget"></a>
# **SearchContentUsingTextUsingGET**
> string SearchContentUsingTextUsingGET (string xPubkey, string text)

Search through all the owner's documents to find a content that matches the text specified.

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
    public class SearchContentUsingTextUsingGETExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var xPubkey = xPubkey_example;  // string | The Sender or Receiver's Public Key
            var text = text_example;  // string | Text or Keyword that will be match to the files available

            try
            {
                // Search through all the owner's documents to find a content that matches the text specified.
                string result = apiInstance.SearchContentUsingTextUsingGET(xPubkey, text);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchContentUsingTextUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPubkey** | **string**| The Sender or Receiver&#39;s Public Key | 
 **text** | **string**| Text or Keyword that will be match to the files available | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchdatahashusingpublicnemhashusingget"></a>
# **SearchDataHashUsingPublicNemHashUsingGET**
> string SearchDataHashUsingPublicNemHashUsingGET (string nemHash)

Search through all the owner's documents to find the data hash that matches the nemhash specified.

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
    public class SearchDataHashUsingPublicNemHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var nemHash = nemHash_example;  // string | NEM Hash that will be matched to the files available

            try
            {
                // Search through all the owner's documents to find the data hash that matches the nemhash specified.
                string result = apiInstance.SearchDataHashUsingPublicNemHashUsingGET(nemHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchDataHashUsingPublicNemHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemHash** | **string**| NEM Hash that will be matched to the files available | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchtransactionpvkeywithkeywordusingget"></a>
# **SearchTransactionPvKeyWithKeywordUsingGET**
> List<BinaryTransactionEncryptedMessage> SearchTransactionPvKeyWithKeywordUsingGET (string xPvkey, string keywords)

Search through all the owners documents to find a content that matches the text specified.

This endpoint can only be used to look up publicly available resources (PLAIN and SECURE Message Types).

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class SearchTransactionPvKeyWithKeywordUsingGETExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var xPvkey = xPvkey_example;  // string | The Sender or Receiver's Private Key
            var keywords = keywords_example;  // string | Comma delimited Keyword that will be match to the files available

            try
            {
                // Search through all the owners documents to find a content that matches the text specified.
                List&lt;BinaryTransactionEncryptedMessage&gt; result = apiInstance.SearchTransactionPvKeyWithKeywordUsingGET(xPvkey, keywords);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchTransactionPvKeyWithKeywordUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPvkey** | **string**| The Sender or Receiver&#39;s Private Key | 
 **keywords** | **string**| Comma delimited Keyword that will be match to the files available | 

### Return type

[**List<BinaryTransactionEncryptedMessage>**](BinaryTransactionEncryptedMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchtransactionwithkeywordusingget"></a>
# **SearchTransactionWithKeywordUsingGET**
> List<BinaryTransactionEncryptedMessage> SearchTransactionWithKeywordUsingGET (string xPubkey, string keywords)

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
                List&lt;BinaryTransactionEncryptedMessage&gt; result = apiInstance.SearchTransactionWithKeywordUsingGET(xPubkey, keywords);
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

[**List<BinaryTransactionEncryptedMessage>**](BinaryTransactionEncryptedMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchtransactionwithmetadatausingget"></a>
# **SearchTransactionWithMetadataUsingGET**
> List<BinaryTransactionEncryptedMessage> SearchTransactionWithMetadataUsingGET (string xPubkey, string text)

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
            var text = text_example;  // string | Index-based searching on metadata

            try
            {
                // Search through all the owners documents to find a key that matches the specified parameter key
                List&lt;BinaryTransactionEncryptedMessage&gt; result = apiInstance.SearchTransactionWithMetadataUsingGET(xPubkey, text);
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
 **text** | **string**| Index-based searching on metadata | 

### Return type

[**List<BinaryTransactionEncryptedMessage>**](BinaryTransactionEncryptedMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

