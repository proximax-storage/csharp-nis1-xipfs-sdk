# Io.Xpx.Api.DirectoryLoadApi

All URIs are relative to *http://localhost:8881*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LoadDirectoryUsingGET**](DirectoryLoadApi.md#loaddirectoryusingget) | **GET** /directory/load/{nemHash}/** | Loads a Static Content.


<a name="loaddirectoryusingget"></a>
# **LoadDirectoryUsingGET**
> Object LoadDirectoryUsingGET (string nemHash)

Loads a Static Content.

Loads a Static Content.

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class LoadDirectoryUsingGETExample
    {
        public void main()
        {
            var apiInstance = new DirectoryLoadApi();
            var nemHash = nemHash_example;  // string | NEM Txn (Public) linked to the directory

            try
            {
                // Loads a Static Content.
                Object result = apiInstance.LoadDirectoryUsingGET(nemHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DirectoryLoadApi.LoadDirectoryUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nemHash** | **string**| NEM Txn (Public) linked to the directory | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

