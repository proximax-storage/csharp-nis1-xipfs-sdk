# Io.Xpx.Api.DataHashApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CleanupPinnedContentUsingPOST**](DataHashApi.md#cleanuppinnedcontentusingpost) | **POST** /datahash/cleanup | Calls the garbage clean up and tries to unpin the given hash
[**GenerateHashAndExposeDataToNetworkUsingPOST**](DataHashApi.md#generatehashandexposedatatonetworkusingpost) | **POST** /datahash/upload/data/generate | Generates the encrypted datahash and uploads the JSON Format String data to the P2P Storage Network.
[**GenerateHashAndExposeFileToNetworkUsingPOST**](DataHashApi.md#generatehashandexposefiletonetworkusingpost) | **POST** /datahash/upload/generate | Generates the encrypted datahash and uploads the file in the process.
[**GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOST**](DataHashApi.md#generatehashexposebytearraytonetworkbuildandsignusingpost) | **POST** /datahash/upload/data/generate-sign | This endpoint can be used to generate the transaction along with the data hash with the private key signature.
[**GenerateHashExposeFileToNetworkBuildAndSignUsingPOST**](DataHashApi.md#generatehashexposefiletonetworkbuildandsignusingpost) | **POST** /datahash/upload/generate-sign | This endpoint can be used to generate the transaction along with the data hash with the private key signature.
[**GenerateHashForDataOnlyUsingPOST**](DataHashApi.md#generatehashfordataonlyusingpost) | **POST** /datahash/generate/data/hashonly | Generates the datahash but doesn&#39;t upload the entire file.
[**GenerateHashForFileOnlyUsingPOST**](DataHashApi.md#generatehashforfileonlyusingpost) | **POST** /datahash/generate/hashonly | Generates the datahash but doesn&#39;t upload the entire file.


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
            var apiInstance = new DataHashApi();
            var multihash = multihash_example;  // string | The pinned multihash

            try
            {
                // Calls the garbage clean up and tries to unpin the given hash
                string result = apiInstance.CleanupPinnedContentUsingPOST(multihash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataHashApi.CleanupPinnedContentUsingPOST: " + e.Message );
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

<a name="generatehashandexposedatatonetworkusingpost"></a>
# **GenerateHashAndExposeDataToNetworkUsingPOST**
> BinaryTransactionEncryptedMessage GenerateHashAndExposeDataToNetworkUsingPOST (string data, string name = null, string keywords = null, string metadata = null)

Generates the encrypted datahash and uploads the JSON Format String data to the P2P Storage Network.

This endpoint can be used to generates the encrypted datahash and uploads the file in the process.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GenerateHashAndExposeDataToNetworkUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DataHashApi();
            var data = data_example;  // string | Free form string data that will be stored on the P2P Network
            var name = name_example;  // string | Custom Name of the data. If none is specified, timestamp will be used. (optional) 
            var keywords = keywords_example;  // string | Comma delimited Keyword/Tags (optional) 
            var metadata = metadata_example;  // string | JSON Format MetaData stored on the NEM Txn Message (optional) 

            try
            {
                // Generates the encrypted datahash and uploads the JSON Format String data to the P2P Storage Network.
                BinaryTransactionEncryptedMessage result = apiInstance.GenerateHashAndExposeDataToNetworkUsingPOST(data, name, keywords, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataHashApi.GenerateHashAndExposeDataToNetworkUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | **string**| Free form string data that will be stored on the P2P Network | 
 **name** | **string**| Custom Name of the data. If none is specified, timestamp will be used. | [optional] 
 **keywords** | **string**| Comma delimited Keyword/Tags | [optional] 
 **metadata** | **string**| JSON Format MetaData stored on the NEM Txn Message | [optional] 

### Return type

[**BinaryTransactionEncryptedMessage**](BinaryTransactionEncryptedMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatehashandexposefiletonetworkusingpost"></a>
# **GenerateHashAndExposeFileToNetworkUsingPOST**
> BinaryTransactionEncryptedMessage GenerateHashAndExposeFileToNetworkUsingPOST (System.IO.Stream file, string keywords = null, string metadata = null)

Generates the encrypted datahash and uploads the file in the process.

This endpoint can be used to generates the encrypted datahash and uploads the file in the process.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GenerateHashAndExposeFileToNetworkUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DataHashApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The Multipart File that will be stored on the P2P Storage Network
            var keywords = keywords_example;  // string | Comma delimited Keyword/Tags (optional) 
            var metadata = metadata_example;  // string | JSON Format MetaData stored on the NEM Txn Message (optional) 

            try
            {
                // Generates the encrypted datahash and uploads the file in the process.
                BinaryTransactionEncryptedMessage result = apiInstance.GenerateHashAndExposeFileToNetworkUsingPOST(file, keywords, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataHashApi.GenerateHashAndExposeFileToNetworkUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The Multipart File that will be stored on the P2P Storage Network | 
 **keywords** | **string**| Comma delimited Keyword/Tags | [optional] 
 **metadata** | **string**| JSON Format MetaData stored on the NEM Txn Message | [optional] 

### Return type

[**BinaryTransactionEncryptedMessage**](BinaryTransactionEncryptedMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatehashexposebytearraytonetworkbuildandsignusingpost"></a>
# **GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOST**
> RequestAnnounceDataSignature GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOST (string xPvkey = null, string xPubkey = null, string messageType = null, string data = null, string keywords = null, string metadata = null)

This endpoint can be used to generate the transaction along with the data hash with the private key signature.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DataHashApi();
            var xPvkey = xPvkey_example;  // string | Sender Private Key (optional) 
            var xPubkey = xPubkey_example;  // string | Receiver Public Key (optional) 
            var messageType = messageType_example;  // string | Message Type ( PLAIN or SECURE ) (optional) 
            var data = data_example;  // string | Free form string data that will be stored on the P2P Network (optional) 
            var keywords = keywords_example;  // string | Comma delimited Keyword/Tags (optional) 
            var metadata = metadata_example;  // string | Json Format Data Structure (optional) 

            try
            {
                // This endpoint can be used to generate the transaction along with the data hash with the private key signature.
                RequestAnnounceDataSignature result = apiInstance.GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOST(xPvkey, xPubkey, messageType, data, keywords, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataHashApi.GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOST: " + e.Message );
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
 **data** | **string**| Free form string data that will be stored on the P2P Network | [optional] 
 **keywords** | **string**| Comma delimited Keyword/Tags | [optional] 
 **metadata** | **string**| Json Format Data Structure | [optional] 

### Return type

[**RequestAnnounceDataSignature**](RequestAnnounceDataSignature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatehashexposefiletonetworkbuildandsignusingpost"></a>
# **GenerateHashExposeFileToNetworkBuildAndSignUsingPOST**
> RequestAnnounceDataSignature GenerateHashExposeFileToNetworkBuildAndSignUsingPOST (string xPvkey = null, string xPubkey = null, string messageType = null, System.IO.Stream file = null, string keywords = null, string metadata = null)

This endpoint can be used to generate the transaction along with the data hash with the private key signature.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class GenerateHashExposeFileToNetworkBuildAndSignUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DataHashApi();
            var xPvkey = xPvkey_example;  // string | Sender Private Key (optional) 
            var xPubkey = xPubkey_example;  // string | Receiver Public Key (optional) 
            var messageType = messageType_example;  // string | Message Type ( PLAIN or SECURE ) (optional) 
            var file = new System.IO.Stream(); // System.IO.Stream | The Multipart File (optional) 
            var keywords = keywords_example;  // string | Comma delimited Keyword/Tags (optional) 
            var metadata = metadata_example;  // string | Json Format Data Structure (optional) 

            try
            {
                // This endpoint can be used to generate the transaction along with the data hash with the private key signature.
                RequestAnnounceDataSignature result = apiInstance.GenerateHashExposeFileToNetworkBuildAndSignUsingPOST(xPvkey, xPubkey, messageType, file, keywords, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataHashApi.GenerateHashExposeFileToNetworkBuildAndSignUsingPOST: " + e.Message );
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

[**RequestAnnounceDataSignature**](RequestAnnounceDataSignature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatehashfordataonlyusingpost"></a>
# **GenerateHashForDataOnlyUsingPOST**
> BinaryTransactionEncryptedMessage GenerateHashForDataOnlyUsingPOST (string data = null, string keywords = null, string metadata = null)

Generates the datahash but doesn't upload the entire file.

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
            var data = data_example;  // string | Free form string data that will be stored on the P2P Network (optional) 
            var keywords = keywords_example;  // string | Comma delimited Keyword/Tags (optional) 
            var metadata = metadata_example;  // string | JSON Format MetaData stored on the NEM Txn Message (optional) 

            try
            {
                // Generates the datahash but doesn't upload the entire file.
                BinaryTransactionEncryptedMessage result = apiInstance.GenerateHashForDataOnlyUsingPOST(data, keywords, metadata);
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
 **data** | **string**| Free form string data that will be stored on the P2P Network | [optional] 
 **keywords** | **string**| Comma delimited Keyword/Tags | [optional] 
 **metadata** | **string**| JSON Format MetaData stored on the NEM Txn Message | [optional] 

### Return type

[**BinaryTransactionEncryptedMessage**](BinaryTransactionEncryptedMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatehashforfileonlyusingpost"></a>
# **GenerateHashForFileOnlyUsingPOST**
> BinaryTransactionEncryptedMessage GenerateHashForFileOnlyUsingPOST (System.IO.Stream file, string keywords = null, string metadata = null)

Generates the datahash but doesn't upload the entire file.

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
    public class GenerateHashForFileOnlyUsingPOSTExample
    {
        public void main()
        {
            var apiInstance = new DataHashApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The Multipart File that will be stored on the P2P Storage Network
            var keywords = keywords_example;  // string | Comma delimited Keyword/Tags (optional) 
            var metadata = metadata_example;  // string | JSON Format MetaData stored on the NEM Txn Message (optional) 

            try
            {
                // Generates the datahash but doesn't upload the entire file.
                BinaryTransactionEncryptedMessage result = apiInstance.GenerateHashForFileOnlyUsingPOST(file, keywords, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataHashApi.GenerateHashForFileOnlyUsingPOST: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The Multipart File that will be stored on the P2P Storage Network | 
 **keywords** | **string**| Comma delimited Keyword/Tags | [optional] 
 **metadata** | **string**| JSON Format MetaData stored on the NEM Txn Message | [optional] 

### Return type

[**BinaryTransactionEncryptedMessage**](BinaryTransactionEncryptedMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

