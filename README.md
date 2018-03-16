# Io.Xpx - the C# library for the Proximax P2P Storage REST API

Proximax P2P Storage REST API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v0.0.1
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/alvin-reyes](https://github.com/alvin-reyes)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Io.Xpx.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Io.Xpx.Api;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost:8881*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**GetAllIncomingNemAddressTransactionsUsingGET**](docs/AccountApi.md#getallincomingnemaddresstransactionsusingget) | **GET** /account/get/all-incoming-transactions/{publicKey} | getAllIncomingNemAddressTransactions
*AccountApi* | [**GetAllNemAddressTransactionsUsingGET**](docs/AccountApi.md#getallnemaddresstransactionsusingget) | **GET** /account/get/all-transactions/{publicKey} | getAllNemAddressTransactions
*AccountApi* | [**GetAllNemAddressTransactionsWithPageSizeUsingGET**](docs/AccountApi.md#getallnemaddresstransactionswithpagesizeusingget) | **GET** /account/get/all-transactions/{publicKey}/{pageSize} | getAllNemAddressTransactionsWithPageSize
*AccountApi* | [**GetAllOutgoingNemAddressTransactionsUsingGET**](docs/AccountApi.md#getalloutgoingnemaddresstransactionsusingget) | **GET** /account/get/all-outgoing-transactions/{publicKey} | getAllOutgoingNemAddressTransactions
*AccountApi* | [**GetAllUnconfirmedNemAddressTransactionsUsingGET**](docs/AccountApi.md#getallunconfirmednemaddresstransactionsusingget) | **GET** /account/get/all-unconfirmed-transactions/{publicKey} | getAllUnconfirmedNemAddressTransactions
*AccountApi* | [**GetNemAddressDetailsUsingGET**](docs/AccountApi.md#getnemaddressdetailsusingget) | **GET** /account/get/info/{publicKey} | Get the NEM Address Details
*DataHashApi* | [**CleanupPinnedContentUsingPOST**](docs/DataHashApi.md#cleanuppinnedcontentusingpost) | **POST** /datahash/cleanup | Calls the garbage clean up and tries to unpin the given hash
*DataHashApi* | [**GenerateHashAndExposeDataToNetworkUsingPOST**](docs/DataHashApi.md#generatehashandexposedatatonetworkusingpost) | **POST** /datahash/upload/data/generate | Generates the encrypted datahash and uploads the JSON Format String data to the P2P Storage Network.
*DataHashApi* | [**GenerateHashAndExposeFileToNetworkUsingPOST**](docs/DataHashApi.md#generatehashandexposefiletonetworkusingpost) | **POST** /datahash/upload/generate | Generates the encrypted datahash and uploads the file in the process.
*DataHashApi* | [**GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOST**](docs/DataHashApi.md#generatehashexposebytearraytonetworkbuildandsignusingpost) | **POST** /datahash/upload/data/generate-sign | This endpoint can be used to generate the transaction along with the data hash with the private key signature.
*DataHashApi* | [**GenerateHashExposeFileToNetworkBuildAndSignUsingPOST**](docs/DataHashApi.md#generatehashexposefiletonetworkbuildandsignusingpost) | **POST** /datahash/upload/generate-sign | This endpoint can be used to generate the transaction along with the data hash with the private key signature.
*DataHashApi* | [**GenerateHashForDataOnlyUsingPOST**](docs/DataHashApi.md#generatehashfordataonlyusingpost) | **POST** /datahash/generate/data/hashonly | Generates the datahash but doesn't upload the entire file.
*DataHashApi* | [**GenerateHashForFileOnlyUsingPOST**](docs/DataHashApi.md#generatehashforfileonlyusingpost) | **POST** /datahash/generate/hashonly | Generates the datahash but doesn't upload the entire file.
*DownloadApi* | [**DownloadPlainMessageFileUsingNemHashUsingGET**](docs/DownloadApi.md#downloadplainmessagefileusingnemhashusingget) | **GET** /download/data/plain/{nemhash} | Download resource/file using NEM Transaction Hash
*DownloadApi* | [**DownloadRawBytesPlainMessageFileUsingNemHashUsingGET**](docs/DownloadApi.md#downloadrawbytesplainmessagefileusingnemhashusingget) | **GET** /download/data/plain/rawbytes/{nemhash} | Download plain resource/file using NEM Transaction Hash
*DownloadApi* | [**DownloadRawBytesSecureMessageFileUsingNemHashUsingGET**](docs/DownloadApi.md#downloadrawbytessecuremessagefileusingnemhashusingget) | **GET** /download/data/secure/rawbytes/{nemhash} | Download secured resource/file using NEM Transaction Hash
*DownloadApi* | [**DownloadRawBytesUsingHashUsingPOST**](docs/DownloadApi.md#downloadrawbytesusinghashusingpost) | **POST** /download/data/rawbytes | Download secured encrypted resource/file using Data Hash
*DownloadApi* | [**DownloadSecureMessageFileUsingNemHashUsingGET**](docs/DownloadApi.md#downloadsecuremessagefileusingnemhashusingget) | **GET** /download/data/secure/{nemhash} | Download resource/file using NEM Transaction Hash
*DownloadApi* | [**DownloadStreamPlainMessageFileUsingNemHashUsingGET**](docs/DownloadApi.md#downloadstreamplainmessagefileusingnemhashusingget) | **GET** /download/data/plain/stream/{nemhash} | Download plain resource/file using NEM Transaction Hash
*DownloadApi* | [**DownloadStreamSecureMessageFileUsingNemHashUsingGET**](docs/DownloadApi.md#downloadstreamsecuremessagefileusingnemhashusingget) | **GET** /download/data/secure/stream/{nemhash} | Download secured resource/file using NEM Transaction Hash
*DownloadApi* | [**DownloadStreamUsingHashUsingPOST**](docs/DownloadApi.md#downloadstreamusinghashusingpost) | **POST** /download/data/stream | Download secured encrypted resource/file using Data Hash
*NodeApi* | [**CheckNodeUsingGET**](docs/NodeApi.md#checknodeusingget) | **GET** /node/check | Check if the Storage Node is up and running.
*NodeApi* | [**GetNodeInfoUsingGET**](docs/NodeApi.md#getnodeinfousingget) | **GET** /node/info | Get Storage Node Information
*NodeApi* | [**SetBlockchainNodeConnectionUsingPOST**](docs/NodeApi.md#setblockchainnodeconnectionusingpost) | **POST** /node/set/blockchain/connection | Get Storage Node Information
*PublishAndAnnounceApi* | [**AnnounceRequestPublishDataSignatureUsingPOST**](docs/PublishAndAnnounceApi.md#announcerequestpublishdatasignatureusingpost) | **POST** /publish/announce | Announce the DataHash to NEM/P2P Storage and P2P Database
*PublishAndAnnounceApi* | [**PublishAndSendSingleFileToAddressUsingPOST**](docs/PublishAndAnnounceApi.md#publishandsendsinglefiletoaddressusingpost) | **POST** /publish/single/to/{address} | Store a single file that can only be access by the given address
*PublishAndAnnounceApi* | [**PublishAndSendSingleFileToAddressesUsingPOST**](docs/PublishAndAnnounceApi.md#publishandsendsinglefiletoaddressesusingpost) | **POST** /publish/single/to/addresses | Store a single file that can only be access by the given addresses
*SearchApi* | [**SearchContentUsingAllNemHashUsingGET**](docs/SearchApi.md#searchcontentusingallnemhashusingget) | **GET** /search/all/content/hash/{nemHash} | Search through all the owner's documents to find a content that matches the text specified.
*SearchApi* | [**SearchContentUsingPublicNemHashUsingGET**](docs/SearchApi.md#searchcontentusingpublicnemhashusingget) | **GET** /search/public/content/hash/{nemHash} | Search through all the owner's documents to find a content that matches the text specified.
*SearchApi* | [**SearchContentUsingTextUsingGET**](docs/SearchApi.md#searchcontentusingtextusingget) | **GET** /search/public/content/{text} | Search through all the owner's documents to find a content that matches the text specified.
*SearchApi* | [**SearchDataHashUsingPublicNemHashUsingGET**](docs/SearchApi.md#searchdatahashusingpublicnemhashusingget) | **GET** /search/public/content/hashonly/{nemHash} | Search through all the owner's documents to find the data hash that matches the nemhash specified.
*SearchApi* | [**SearchTransactionPvKeyWithKeywordUsingGET**](docs/SearchApi.md#searchtransactionpvkeywithkeywordusingget) | **GET** /search/all/content/keyword/{keywords} | Search through all the owners documents to find a content that matches the text specified.
*SearchApi* | [**SearchTransactionWithKeywordUsingGET**](docs/SearchApi.md#searchtransactionwithkeywordusingget) | **GET** /search/public/content/keyword/{keywords} | Search through all the owners documents to find a content that matches the text specified.
*SearchApi* | [**SearchTransactionWithMetadataUsingGET**](docs/SearchApi.md#searchtransactionwithmetadatausingget) | **GET** /search/public/content/metadata/{text} | Search through all the owners documents to find a key that matches the specified parameter key


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountInfo](docs/AccountInfo.md)
 - [Model.AccountMetaData](docs/AccountMetaData.md)
 - [Model.AccountMetaDataPair](docs/AccountMetaDataPair.md)
 - [Model.Address](docs/Address.md)
 - [Model.Amount](docs/Amount.md)
 - [Model.BinaryTransactionEncryptedMessage](docs/BinaryTransactionEncryptedMessage.md)
 - [Model.BlockAmount](docs/BlockAmount.md)
 - [Model.File](docs/File.md)
 - [Model.GenericResponseMessage](docs/GenericResponseMessage.md)
 - [Model.InputStream](docs/InputStream.md)
 - [Model.KeyPair](docs/KeyPair.md)
 - [Model.MultisigInfo](docs/MultisigInfo.md)
 - [Model.NodeInfo](docs/NodeInfo.md)
 - [Model.PrivateKey](docs/PrivateKey.md)
 - [Model.PublicKey](docs/PublicKey.md)
 - [Model.RequestAnnounceDataSignature](docs/RequestAnnounceDataSignature.md)
 - [Model.Resource](docs/Resource.md)
 - [Model.ResponseEntity](docs/ResponseEntity.md)
 - [Model.StackTraceElement](docs/StackTraceElement.md)
 - [Model.Throwable](docs/Throwable.md)
 - [Model.URI](docs/URI.md)
 - [Model.URL](docs/URL.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
