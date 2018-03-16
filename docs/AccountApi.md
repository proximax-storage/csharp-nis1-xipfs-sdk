# Io.Xpx.Api.AccountApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllIncomingNemAddressTransactionsUsingGET**](AccountApi.md#getallincomingnemaddresstransactionsusingget) | **GET** /account/get/all-incoming-transactions/{publicKey} | getAllIncomingNemAddressTransactions
[**GetAllNemAddressTransactionsUsingGET**](AccountApi.md#getallnemaddresstransactionsusingget) | **GET** /account/get/all-transactions/{publicKey} | getAllNemAddressTransactions
[**GetAllNemAddressTransactionsWithPageSizeUsingGET**](AccountApi.md#getallnemaddresstransactionswithpagesizeusingget) | **GET** /account/get/all-transactions/{publicKey}/{pageSize} | getAllNemAddressTransactionsWithPageSize
[**GetAllOutgoingNemAddressTransactionsUsingGET**](AccountApi.md#getalloutgoingnemaddresstransactionsusingget) | **GET** /account/get/all-outgoing-transactions/{publicKey} | getAllOutgoingNemAddressTransactions
[**GetAllUnconfirmedNemAddressTransactionsUsingGET**](AccountApi.md#getallunconfirmednemaddresstransactionsusingget) | **GET** /account/get/all-unconfirmed-transactions/{publicKey} | getAllUnconfirmedNemAddressTransactions
[**GetNemAddressDetailsUsingGET**](AccountApi.md#getnemaddressdetailsusingget) | **GET** /account/get/info/{publicKey} | Get the NEM Address Details


<a name="getallincomingnemaddresstransactionsusingget"></a>
# **GetAllIncomingNemAddressTransactionsUsingGET**
> string GetAllIncomingNemAddressTransactionsUsingGET (string publicKey)

getAllIncomingNemAddressTransactions

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GetAllIncomingNemAddressTransactionsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var publicKey = publicKey_example;  // string | The NEM Account Public Key

            try
            {
                // getAllIncomingNemAddressTransactions
                string result = apiInstance.GetAllIncomingNemAddressTransactionsUsingGET(publicKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAllIncomingNemAddressTransactionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicKey** | **string**| The NEM Account Public Key | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallnemaddresstransactionsusingget"></a>
# **GetAllNemAddressTransactionsUsingGET**
> string GetAllNemAddressTransactionsUsingGET (string publicKey)

getAllNemAddressTransactions

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GetAllNemAddressTransactionsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var publicKey = publicKey_example;  // string | The NEM Account Public Key

            try
            {
                // getAllNemAddressTransactions
                string result = apiInstance.GetAllNemAddressTransactionsUsingGET(publicKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAllNemAddressTransactionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicKey** | **string**| The NEM Account Public Key | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallnemaddresstransactionswithpagesizeusingget"></a>
# **GetAllNemAddressTransactionsWithPageSizeUsingGET**
> string GetAllNemAddressTransactionsWithPageSizeUsingGET (string publicKey, string pageSize)

getAllNemAddressTransactionsWithPageSize

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GetAllNemAddressTransactionsWithPageSizeUsingGETExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var publicKey = publicKey_example;  // string | The NEM Account Public Key
            var pageSize = pageSize_example;  // string | Page Size

            try
            {
                // getAllNemAddressTransactionsWithPageSize
                string result = apiInstance.GetAllNemAddressTransactionsWithPageSizeUsingGET(publicKey, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAllNemAddressTransactionsWithPageSizeUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicKey** | **string**| The NEM Account Public Key | 
 **pageSize** | **string**| Page Size | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalloutgoingnemaddresstransactionsusingget"></a>
# **GetAllOutgoingNemAddressTransactionsUsingGET**
> string GetAllOutgoingNemAddressTransactionsUsingGET (string publicKey)

getAllOutgoingNemAddressTransactions

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GetAllOutgoingNemAddressTransactionsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var publicKey = publicKey_example;  // string | The NEM Account Public Key

            try
            {
                // getAllOutgoingNemAddressTransactions
                string result = apiInstance.GetAllOutgoingNemAddressTransactionsUsingGET(publicKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAllOutgoingNemAddressTransactionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicKey** | **string**| The NEM Account Public Key | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallunconfirmednemaddresstransactionsusingget"></a>
# **GetAllUnconfirmedNemAddressTransactionsUsingGET**
> string GetAllUnconfirmedNemAddressTransactionsUsingGET (string publicKey)

getAllUnconfirmedNemAddressTransactions

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GetAllUnconfirmedNemAddressTransactionsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var publicKey = publicKey_example;  // string | The NEM Account Public Key

            try
            {
                // getAllUnconfirmedNemAddressTransactions
                string result = apiInstance.GetAllUnconfirmedNemAddressTransactionsUsingGET(publicKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetAllUnconfirmedNemAddressTransactionsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicKey** | **string**| The NEM Account Public Key | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnemaddressdetailsusingget"></a>
# **GetNemAddressDetailsUsingGET**
> AccountMetaDataPair GetNemAddressDetailsUsingGET (string publicKey)

Get the NEM Address Details

This endpoint returns the NEM Address/Account Information of a given address

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GetNemAddressDetailsUsingGETExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var publicKey = publicKey_example;  // string | The NEM Account Public Key

            try
            {
                // Get the NEM Address Details
                AccountMetaDataPair result = apiInstance.GetNemAddressDetailsUsingGET(publicKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.GetNemAddressDetailsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **publicKey** | **string**| The NEM Account Public Key | 

### Return type

[**AccountMetaDataPair**](AccountMetaDataPair.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

