# Io.Xpx.Api.UploadApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CleanupPinnedContentUsingPOST**](UploadApi.md#cleanuppinnedcontentusingpost) | **POST** /upload/cleanup | Calls the garbage clean up and tries to unpin the given hash
[**DirectoryExtractUsingPOST**](UploadApi.md#directoryextractusingpost) | **POST** /upload/dir/extract | Grabs a zip file with static content, extract and load directory to the IPFS/P2P Network
[**UploadBase64StringBinaryUsingPOST**](UploadApi.md#uploadbase64stringbinaryusingpost) | **POST** /upload/base64/binary | Uploads a Base64 encoded String binary file to the IPFS/P2P Storage Network
[**UploadBytesBinaryUsingPOST**](UploadApi.md#uploadbytesbinaryusingpost) | **POST** /upload/bytes/binary | Uploads a Base64 encoded byte[] binary file to the IPFS/P2P Storage Network
[**UploadGenerateAndSignUsingPOST**](UploadApi.md#uploadgenerateandsignusingpost) | **POST** /upload/generate-sign | uploadGenerateAndSign
[**UploadPlainTextUsingPOST**](UploadApi.md#uploadplaintextusingpost) | **POST** /upload/text | Upload the Text to the IPFS/P2P Storage Network


<a name="cleanuppinnedcontentusingpost"></a>
# **CleanupPinnedContentUsingPOST**
> string CleanupPinnedContentUsingPOST (string multihash)

Calls the garbage clean up and tries to unpin the given hash

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
    public class CleanupPinnedContentUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new UploadApi();
            var multihash = multihash_example;  // string | The pinned multihash

            try
            {
                // Calls the garbage clean up and tries to unpin the given hash
                string result = apiInstance.CleanupPinnedContentUsingPOST(multihash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadApi.CleanupPinnedContentUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **multihash** | **string**| The pinned multihash | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="directoryextractusingpost"></a>
# **DirectoryExtractUsingPOST**
> string DirectoryExtractUsingPOST (System.IO.Stream file, string name = null, string keywords = null, string metadata = null)

Grabs a zip file with static content, extract and load directory to the IPFS/P2P Network

Generates the Root hash of your directory.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class DirectoryExtractUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new UploadApi();
            var file = new System.IO.Stream(); // System.IO.Stream | Base64 byte[] representation of the data object to be uploaded
            var name = name_example;  // string | Custom Name of the data. If none is specified, timestamp will be used. (optional) 
            var keywords = keywords_example;  // string | Comma delimited Keyword/Tags (optional) 
            var metadata = metadata_example;  // string | Additional data in a JSON Format (optional) 

            try
            {
                // Grabs a zip file with static content, extract and load directory to the IPFS/P2P Network
                string result = apiInstance.DirectoryExtractUsingPOST(file, name, keywords, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadApi.DirectoryExtractUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| Base64 byte[] representation of the data object to be uploaded | 
 **name** | **string**| Custom Name of the data. If none is specified, timestamp will be used. | [optional] 
 **keywords** | **string**| Comma delimited Keyword/Tags | [optional] 
 **metadata** | **string**| Additional data in a JSON Format | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadbase64stringbinaryusingpost"></a>
# **UploadBase64StringBinaryUsingPOST**
> Object UploadBase64StringBinaryUsingPOST (UploadBase64BinaryRequestParameter uploadBase64BinaryRequestParameter)

Uploads a Base64 encoded String binary file to the IPFS/P2P Storage Network

This endpoint can be used to generate the data that will be injected to the NEM Blockchain.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class UploadBase64StringBinaryUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new UploadApi();
            var uploadBase64BinaryRequestParameter = new UploadBase64BinaryRequestParameter(); // UploadBase64BinaryRequestParameter | Base64 String representation of the data object to be uploaded

            try
            {
                // Uploads a Base64 encoded String binary file to the IPFS/P2P Storage Network
                Object result = apiInstance.UploadBase64StringBinaryUsingPOST(uploadBase64BinaryRequestParameter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadApi.UploadBase64StringBinaryUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadBase64BinaryRequestParameter** | [**UploadBase64BinaryRequestParameter**](UploadBase64BinaryRequestParameter.md)| Base64 String representation of the data object to be uploaded | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadbytesbinaryusingpost"></a>
# **UploadBytesBinaryUsingPOST**
> Object UploadBytesBinaryUsingPOST (UploadBytesBinaryRequestParameter uploadBytesBinaryRequestParameter)

Uploads a Base64 encoded byte[] binary file to the IPFS/P2P Storage Network

This endpoint can be used to generate the data that will be injected to the NEM Blockchain.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class UploadBytesBinaryUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new UploadApi();
            var uploadBytesBinaryRequestParameter = new UploadBytesBinaryRequestParameter(); // UploadBytesBinaryRequestParameter | Base64 byte[] representation of the data object to be uploaded

            try
            {
                // Uploads a Base64 encoded byte[] binary file to the IPFS/P2P Storage Network
                Object result = apiInstance.UploadBytesBinaryUsingPOST(uploadBytesBinaryRequestParameter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadApi.UploadBytesBinaryUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadBytesBinaryRequestParameter** | [**UploadBytesBinaryRequestParameter**](UploadBytesBinaryRequestParameter.md)| Base64 byte[] representation of the data object to be uploaded | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadgenerateandsignusingpost"></a>
# **UploadGenerateAndSignUsingPOST**
> string UploadGenerateAndSignUsingPOST (string xPvkey = null, string xPubkey = null, string messageType = null, System.IO.Stream file = null, string keywords = null, string metadata = null)

uploadGenerateAndSign

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class UploadGenerateAndSignUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new UploadApi();
            var xPvkey = xPvkey_example;  // string | Sender Private Key (optional) 
            var xPubkey = xPubkey_example;  // string | Receiver Public Key (optional) 
            var messageType = messageType_example;  // string | Message Type ( PLAIN or SECURE ) (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | The Multipart File (optional) 
            var keywords = keywords_example;  // string | Comma delimited Keyword/Tags (optional) 
            var metadata = metadata_example;  // string | Json Format Data Structure (optional) 

            try
            {
                // uploadGenerateAndSign
                string result = apiInstance.UploadGenerateAndSignUsingPOST(xPvkey, xPubkey, messageType, file, keywords, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadApi.UploadGenerateAndSignUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPvkey** | **string**| Sender Private Key | [optional] 
 **xPubkey** | **string**| Receiver Public Key | [optional] 
 **messageType** | **string**| Message Type ( PLAIN or SECURE ) | [optional] 
 **file** | **System.IO.Stream**| The Multipart File | [optional] 
 **keywords** | **string**| Comma delimited Keyword/Tags | [optional] 
 **metadata** | **string**| Json Format Data Structure | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadplaintextusingpost"></a>
# **UploadPlainTextUsingPOST**
> Object UploadPlainTextUsingPOST (UploadTextRequestParameter uploadTextParameter)

Upload the Text to the IPFS/P2P Storage Network

This endpoint can be used to generate the data that will be injected to the NEM Blockchain.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class UploadPlainTextUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new UploadApi();
            var uploadTextParameter = new UploadTextRequestParameter(); // UploadTextRequestParameter | A Plain Text

            try
            {
                // Upload the Text to the IPFS/P2P Storage Network
                Object result = apiInstance.UploadPlainTextUsingPOST(uploadTextParameter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadApi.UploadPlainTextUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uploadTextParameter** | [**UploadTextRequestParameter**](UploadTextRequestParameter.md)| A Plain Text | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

