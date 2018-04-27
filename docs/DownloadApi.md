# Io.Xpx.Api.DownloadApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadBinaryUsingGET**](DownloadApi.md#downloadbinaryusingget) | **GET** /download/binary | Download a binary using NEM Transaction Hash
[**DownloadSecureBinaryUsingGET**](DownloadApi.md#downloadsecurebinaryusingget) | **GET** /download/secure/binary | Download a secure resource/blob using NEM Private Key and Transaction Hash
[**DownloadSecureFileUsingGET**](DownloadApi.md#downloadsecurefileusingget) | **GET** /download/secure/file | Download a secure resource/file using NEM Private Key and Transaction Hash
[**DownloadTextUsingGET**](DownloadApi.md#downloadtextusingget) | **GET** /download/text | Download a base64 encoded plain text data using NEM Transaction Hash
[**DownloadUsingDataHashUsingGET**](DownloadApi.md#downloadusingdatahashusingget) | **GET** /download/direct/datahash | Download IPFS file associated to the datahash


<a name="downloadbinaryusingget"></a>
# **DownloadBinaryUsingGET**
> byte[] DownloadBinaryUsingGET (string nemHash, string transferMode)

Download a binary using NEM Transaction Hash

Download the binary file associated to a NEM Hash. If NEM Hash uses SECURE Message, it returns the NEM TXN Payload Instead

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadBinaryUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var nemHash = nemHash_example;  // string | The NEM Transaction Hash
            var transferMode = transferMode_example;  // string | Transfer Mode default: bytes (bytes,stream,base64)

            try
            {
                // Download a binary using NEM Transaction Hash
                byte[] result = apiInstance.DownloadBinaryUsingGET(nemHash, transferMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadBinaryUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemHash** | **string**| The NEM Transaction Hash | 
 **transferMode** | **string**| Transfer Mode default: bytes (bytes,stream,base64) | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadsecurebinaryusingget"></a>
# **DownloadSecureBinaryUsingGET**
> byte[] DownloadSecureBinaryUsingGET (string xPvkey, string nemHash, string transferType)

Download a secure resource/blob using NEM Private Key and Transaction Hash

Download a blob associated to a NEM Hash. If NEM Hash uses SECURE Message, it returns the NEM TXN Payload Instead

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadSecureBinaryUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var xPvkey = xPvkey_example;  // string | The Sender or Receiver's Private Key
            var nemHash = nemHash_example;  // string | The NEM Transaction Hash
            var transferType = transferType_example;  // string | Transfer Type default: bytes (bytes,stream,base64)

            try
            {
                // Download a secure resource/blob using NEM Private Key and Transaction Hash
                byte[] result = apiInstance.DownloadSecureBinaryUsingGET(xPvkey, nemHash, transferType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadSecureBinaryUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPvkey** | **string**| The Sender or Receiver&#39;s Private Key | 
 **nemHash** | **string**| The NEM Transaction Hash | 
 **transferType** | **string**| Transfer Type default: bytes (bytes,stream,base64) | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadsecurefileusingget"></a>
# **DownloadSecureFileUsingGET**
> byte[] DownloadSecureFileUsingGET (string xPvkey, string nemHash, string transferType)

Download a secure resource/file using NEM Private Key and Transaction Hash

Download a file associated to a NEM Hash. If NEM Hash uses SECURE Message, it returns the NEM TXN Payload Instead

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadSecureFileUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var xPvkey = xPvkey_example;  // string | The Sender or Receiver's Private Key
            var nemHash = nemHash_example;  // string | The NEM Transaction Hash
            var transferType = transferType_example;  // string | Transfer Type default: bytes (bytes,stream,base64)

            try
            {
                // Download a secure resource/file using NEM Private Key and Transaction Hash
                byte[] result = apiInstance.DownloadSecureFileUsingGET(xPvkey, nemHash, transferType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadSecureFileUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPvkey** | **string**| The Sender or Receiver&#39;s Private Key | 
 **nemHash** | **string**| The NEM Transaction Hash | 
 **transferType** | **string**| Transfer Type default: bytes (bytes,stream,base64) | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadtextusingget"></a>
# **DownloadTextUsingGET**
> byte[] DownloadTextUsingGET (string nemHash, string transferMode)

Download a base64 encoded plain text data using NEM Transaction Hash

Download a plain text data associated to a NEM Hash. If NEM Hash uses SECURE Message, it returns the NEM TXN Payload Instead

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadTextUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var nemHash = nemHash_example;  // string | The NEM Transaction Hash
            var transferMode = transferMode_example;  // string | Transfer Mode default: bytes (bytes,stream)

            try
            {
                // Download a base64 encoded plain text data using NEM Transaction Hash
                byte[] result = apiInstance.DownloadTextUsingGET(nemHash, transferMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadTextUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemHash** | **string**| The NEM Transaction Hash | 
 **transferMode** | **string**| Transfer Mode default: bytes (bytes,stream) | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadusingdatahashusingget"></a>
# **DownloadUsingDataHashUsingGET**
> byte[] DownloadUsingDataHashUsingGET (string dataHash)

Download IPFS file associated to the datahash

Download IPFS file associated to the datahash

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadUsingDataHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var dataHash = dataHash_example;  // string | The NEM Transaction Hash

            try
            {
                // Download IPFS file associated to the datahash
                byte[] result = apiInstance.DownloadUsingDataHashUsingGET(dataHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadUsingDataHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataHash** | **string**| The NEM Transaction Hash | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

