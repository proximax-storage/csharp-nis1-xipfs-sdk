# Io.Xpx.Api.DownloadApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadPlainMessageFileUsingNemHashUsingGET**](DownloadApi.md#downloadplainmessagefileusingnemhashusingget) | **GET** /download/data/plain/{nemhash} | Download resource/file using NEM Transaction Hash
[**DownloadRawBytesPlainMessageFileUsingNemHashUsingGET**](DownloadApi.md#downloadrawbytesplainmessagefileusingnemhashusingget) | **GET** /download/data/plain/rawbytes/{nemhash} | Download plain resource/file using NEM Transaction Hash
[**DownloadRawBytesSecureMessageFileUsingNemHashUsingGET**](DownloadApi.md#downloadrawbytessecuremessagefileusingnemhashusingget) | **GET** /download/data/secure/rawbytes/{nemhash} | Download secured resource/file using NEM Transaction Hash
[**DownloadRawBytesUsingHashUsingPOST**](DownloadApi.md#downloadrawbytesusinghashusingpost) | **POST** /download/data/rawbytes | Download secured encrypted resource/file using Data Hash
[**DownloadSecureMessageFileUsingNemHashUsingGET**](DownloadApi.md#downloadsecuremessagefileusingnemhashusingget) | **GET** /download/data/secure/{nemhash} | Download resource/file using NEM Transaction Hash
[**DownloadStreamPlainMessageFileUsingNemHashUsingGET**](DownloadApi.md#downloadstreamplainmessagefileusingnemhashusingget) | **GET** /download/data/plain/stream/{nemhash} | Download plain resource/file using NEM Transaction Hash
[**DownloadStreamSecureMessageFileUsingNemHashUsingGET**](DownloadApi.md#downloadstreamsecuremessagefileusingnemhashusingget) | **GET** /download/data/secure/stream/{nemhash} | Download secured resource/file using NEM Transaction Hash
[**DownloadStreamUsingHashUsingPOST**](DownloadApi.md#downloadstreamusinghashusingpost) | **POST** /download/data/stream | Download secured encrypted resource/file using Data Hash


<a name="downloadplainmessagefileusingnemhashusingget"></a>
# **DownloadPlainMessageFileUsingNemHashUsingGET**
> ResponseEntity DownloadPlainMessageFileUsingNemHashUsingGET (string nemhash)

Download resource/file using NEM Transaction Hash

This endpoint returns either a byte array format of the actual file OR a JSON format GenericMessageResponse.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadPlainMessageFileUsingNemHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var nemhash = nemhash_example;  // string | The NEM Transaction Hash

            try
            {
                // Download resource/file using NEM Transaction Hash
                ResponseEntity result = apiInstance.DownloadPlainMessageFileUsingNemHashUsingGET(nemhash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadPlainMessageFileUsingNemHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemhash** | **string**| The NEM Transaction Hash | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadrawbytesplainmessagefileusingnemhashusingget"></a>
# **DownloadRawBytesPlainMessageFileUsingNemHashUsingGET**
> byte[] DownloadRawBytesPlainMessageFileUsingNemHashUsingGET (string nemhash)

Download plain resource/file using NEM Transaction Hash

This endpoint returns a byte array format of the actual file

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadRawBytesPlainMessageFileUsingNemHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var nemhash = nemhash_example;  // string | The NEM Transaction Hash

            try
            {
                // Download plain resource/file using NEM Transaction Hash
                byte[] result = apiInstance.DownloadRawBytesPlainMessageFileUsingNemHashUsingGET(nemhash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadRawBytesPlainMessageFileUsingNemHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemhash** | **string**| The NEM Transaction Hash | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadrawbytessecuremessagefileusingnemhashusingget"></a>
# **DownloadRawBytesSecureMessageFileUsingNemHashUsingGET**
> byte[] DownloadRawBytesSecureMessageFileUsingNemHashUsingGET (string nemhash, string xPvkey = null)

Download secured resource/file using NEM Transaction Hash

This endpoint returns a byte array format of the actual file

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadRawBytesSecureMessageFileUsingNemHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var nemhash = nemhash_example;  // string | The NEM Transaction Hash
            var xPvkey = xPvkey_example;  // string | The Sender or Receiver's Private Key (optional) 

            try
            {
                // Download secured resource/file using NEM Transaction Hash
                byte[] result = apiInstance.DownloadRawBytesSecureMessageFileUsingNemHashUsingGET(nemhash, xPvkey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadRawBytesSecureMessageFileUsingNemHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemhash** | **string**| The NEM Transaction Hash | 
 **xPvkey** | **string**| The Sender or Receiver&#39;s Private Key | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadrawbytesusinghashusingpost"></a>
# **DownloadRawBytesUsingHashUsingPOST**
> byte[] DownloadRawBytesUsingHashUsingPOST (string hash)

Download secured encrypted resource/file using Data Hash

This endpoint returns a byte array format of the actual encrypted file

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadRawBytesUsingHashUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var hash = hash_example;  // string | The Data Hash

            try
            {
                // Download secured encrypted resource/file using Data Hash
                byte[] result = apiInstance.DownloadRawBytesUsingHashUsingPOST(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadRawBytesUsingHashUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| The Data Hash | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadsecuremessagefileusingnemhashusingget"></a>
# **DownloadSecureMessageFileUsingNemHashUsingGET**
> ResponseEntity DownloadSecureMessageFileUsingNemHashUsingGET (string xPvkey, string nemhash)

Download resource/file using NEM Transaction Hash

This endpoint returns either a byte array format of the actual file OR a JSON format GenericMessageResponse.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadSecureMessageFileUsingNemHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var xPvkey = xPvkey_example;  // string | The Sender or Receiver's Private Key
            var nemhash = nemhash_example;  // string | The NEM Transaction Hash

            try
            {
                // Download resource/file using NEM Transaction Hash
                ResponseEntity result = apiInstance.DownloadSecureMessageFileUsingNemHashUsingGET(xPvkey, nemhash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadSecureMessageFileUsingNemHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPvkey** | **string**| The Sender or Receiver&#39;s Private Key | 
 **nemhash** | **string**| The NEM Transaction Hash | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadstreamplainmessagefileusingnemhashusingget"></a>
# **DownloadStreamPlainMessageFileUsingNemHashUsingGET**
> byte[] DownloadStreamPlainMessageFileUsingNemHashUsingGET (string nemhash)

Download plain resource/file using NEM Transaction Hash

This endpoint returns a byte array format of the actual file

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadStreamPlainMessageFileUsingNemHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var nemhash = nemhash_example;  // string | The NEM Transaction Hash

            try
            {
                // Download plain resource/file using NEM Transaction Hash
                byte[] result = apiInstance.DownloadStreamPlainMessageFileUsingNemHashUsingGET(nemhash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadStreamPlainMessageFileUsingNemHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemhash** | **string**| The NEM Transaction Hash | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadstreamsecuremessagefileusingnemhashusingget"></a>
# **DownloadStreamSecureMessageFileUsingNemHashUsingGET**
> byte[] DownloadStreamSecureMessageFileUsingNemHashUsingGET (string nemhash, string xPvkey = null)

Download secured resource/file using NEM Transaction Hash

This endpoint returns a byte array format of the actual file

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadStreamSecureMessageFileUsingNemHashUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var nemhash = nemhash_example;  // string | The NEM Transaction Hash
            var xPvkey = xPvkey_example;  // string | The Sender or Receiver's Private Key (optional) 

            try
            {
                // Download secured resource/file using NEM Transaction Hash
                byte[] result = apiInstance.DownloadStreamSecureMessageFileUsingNemHashUsingGET(nemhash, xPvkey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadStreamSecureMessageFileUsingNemHashUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemhash** | **string**| The NEM Transaction Hash | 
 **xPvkey** | **string**| The Sender or Receiver&#39;s Private Key | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadstreamusinghashusingpost"></a>
# **DownloadStreamUsingHashUsingPOST**
> byte[] DownloadStreamUsingHashUsingPOST (string hash)

Download secured encrypted resource/file using Data Hash

This endpoint returns a byte array format of the actual encrypted file

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DownloadStreamUsingHashUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DownloadApi();
            var hash = hash_example;  // string | The Data Hash

            try
            {
                // Download secured encrypted resource/file using Data Hash
                byte[] result = apiInstance.DownloadStreamUsingHashUsingPOST(hash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DownloadApi.DownloadStreamUsingHashUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hash** | **string**| The Data Hash | 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

