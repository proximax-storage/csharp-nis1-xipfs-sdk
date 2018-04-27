/* 
 * Proximax P2P Storage REST API
 *
 * Proximax P2P Storage REST API
 *
 * OpenAPI spec version: v0.0.1
 * Contact: proximax.storage@proximax.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Io.Xpx.Client;
using Io.Xpx.Model;

namespace Io.Xpx.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionAndAnnounceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Announce the DataHash to NEM/P2P Storage and P2P Database
        /// </summary>
        /// <remarks>
        /// Endpoint that can be use to announce the data hash transaction. This will grab the signed BinaryTransaferTransaction and create the P2P Database Entry for the specific data hash / transaction.
        /// </remarks>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestAnnounceDataSignature">The Request Announce Data Signature Json Format (optional)</param>
        /// <returns>string</returns>
        string AnnounceRequestPublishDataSignatureUsingPOST (RequestAnnounceDataSignature requestAnnounceDataSignature = null);

        /// <summary>
        /// Announce the DataHash to NEM/P2P Storage and P2P Database
        /// </summary>
        /// <remarks>
        /// Endpoint that can be use to announce the data hash transaction. This will grab the signed BinaryTransaferTransaction and create the P2P Database Entry for the specific data hash / transaction.
        /// </remarks>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestAnnounceDataSignature">The Request Announce Data Signature Json Format (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AnnounceRequestPublishDataSignatureUsingPOSTWithHttpInfo (RequestAnnounceDataSignature requestAnnounceDataSignature = null);
        /// <summary>
        /// Get the XPX Transaction Hash
        /// </summary>
        /// <remarks>
        /// Endpoint can be used to get XPX Transaction.
        /// </remarks>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nemHash">XPX Transaction Hash</param>
        /// <returns>string</returns>
        string GetXPXTransactionUsingGET (string nemHash);

        /// <summary>
        /// Get the XPX Transaction Hash
        /// </summary>
        /// <remarks>
        /// Endpoint can be used to get XPX Transaction.
        /// </remarks>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nemHash">XPX Transaction Hash</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetXPXTransactionUsingGETWithHttpInfo (string nemHash);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Announce the DataHash to NEM/P2P Storage and P2P Database
        /// </summary>
        /// <remarks>
        /// Endpoint that can be use to announce the data hash transaction. This will grab the signed BinaryTransaferTransaction and create the P2P Database Entry for the specific data hash / transaction.
        /// </remarks>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestAnnounceDataSignature">The Request Announce Data Signature Json Format (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AnnounceRequestPublishDataSignatureUsingPOSTAsync (RequestAnnounceDataSignature requestAnnounceDataSignature = null);

        /// <summary>
        /// Announce the DataHash to NEM/P2P Storage and P2P Database
        /// </summary>
        /// <remarks>
        /// Endpoint that can be use to announce the data hash transaction. This will grab the signed BinaryTransaferTransaction and create the P2P Database Entry for the specific data hash / transaction.
        /// </remarks>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestAnnounceDataSignature">The Request Announce Data Signature Json Format (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AnnounceRequestPublishDataSignatureUsingPOSTAsyncWithHttpInfo (RequestAnnounceDataSignature requestAnnounceDataSignature = null);
        /// <summary>
        /// Get the XPX Transaction Hash
        /// </summary>
        /// <remarks>
        /// Endpoint can be used to get XPX Transaction.
        /// </remarks>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nemHash">XPX Transaction Hash</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetXPXTransactionUsingGETAsync (string nemHash);

        /// <summary>
        /// Get the XPX Transaction Hash
        /// </summary>
        /// <remarks>
        /// Endpoint can be used to get XPX Transaction.
        /// </remarks>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nemHash">XPX Transaction Hash</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetXPXTransactionUsingGETAsyncWithHttpInfo (string nemHash);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionAndAnnounceApi : ITransactionAndAnnounceApi
    {
        private Io.Xpx.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAndAnnounceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionAndAnnounceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Io.Xpx.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAndAnnounceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionAndAnnounceApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Io.Xpx.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Io.Xpx.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Announce the DataHash to NEM/P2P Storage and P2P Database Endpoint that can be use to announce the data hash transaction. This will grab the signed BinaryTransaferTransaction and create the P2P Database Entry for the specific data hash / transaction.
        /// </summary>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestAnnounceDataSignature">The Request Announce Data Signature Json Format (optional)</param>
        /// <returns>string</returns>
        public string AnnounceRequestPublishDataSignatureUsingPOST (RequestAnnounceDataSignature requestAnnounceDataSignature = null)
        {
             ApiResponse<string> localVarResponse = AnnounceRequestPublishDataSignatureUsingPOSTWithHttpInfo(requestAnnounceDataSignature);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Announce the DataHash to NEM/P2P Storage and P2P Database Endpoint that can be use to announce the data hash transaction. This will grab the signed BinaryTransaferTransaction and create the P2P Database Entry for the specific data hash / transaction.
        /// </summary>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestAnnounceDataSignature">The Request Announce Data Signature Json Format (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AnnounceRequestPublishDataSignatureUsingPOSTWithHttpInfo (RequestAnnounceDataSignature requestAnnounceDataSignature = null)
        {

            var localVarPath = "/transaction/announce";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestAnnounceDataSignature != null && requestAnnounceDataSignature.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(requestAnnounceDataSignature); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestAnnounceDataSignature; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AnnounceRequestPublishDataSignatureUsingPOST", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Announce the DataHash to NEM/P2P Storage and P2P Database Endpoint that can be use to announce the data hash transaction. This will grab the signed BinaryTransaferTransaction and create the P2P Database Entry for the specific data hash / transaction.
        /// </summary>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestAnnounceDataSignature">The Request Announce Data Signature Json Format (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AnnounceRequestPublishDataSignatureUsingPOSTAsync (RequestAnnounceDataSignature requestAnnounceDataSignature = null)
        {
             ApiResponse<string> localVarResponse = await AnnounceRequestPublishDataSignatureUsingPOSTAsyncWithHttpInfo(requestAnnounceDataSignature);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Announce the DataHash to NEM/P2P Storage and P2P Database Endpoint that can be use to announce the data hash transaction. This will grab the signed BinaryTransaferTransaction and create the P2P Database Entry for the specific data hash / transaction.
        /// </summary>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestAnnounceDataSignature">The Request Announce Data Signature Json Format (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AnnounceRequestPublishDataSignatureUsingPOSTAsyncWithHttpInfo (RequestAnnounceDataSignature requestAnnounceDataSignature = null)
        {

            var localVarPath = "/transaction/announce";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestAnnounceDataSignature != null && requestAnnounceDataSignature.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(requestAnnounceDataSignature); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestAnnounceDataSignature; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AnnounceRequestPublishDataSignatureUsingPOST", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Get the XPX Transaction Hash Endpoint can be used to get XPX Transaction.
        /// </summary>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nemHash">XPX Transaction Hash</param>
        /// <returns>string</returns>
        public string GetXPXTransactionUsingGET (string nemHash)
        {
             ApiResponse<string> localVarResponse = GetXPXTransactionUsingGETWithHttpInfo(nemHash);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the XPX Transaction Hash Endpoint can be used to get XPX Transaction.
        /// </summary>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nemHash">XPX Transaction Hash</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GetXPXTransactionUsingGETWithHttpInfo (string nemHash)
        {
            // verify the required parameter 'nemHash' is set
            if (nemHash == null)
                throw new ApiException(400, "Missing required parameter 'nemHash' when calling TransactionAndAnnounceApi->GetXPXTransactionUsingGET");

            var localVarPath = "/transaction/get/{nemHash}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (nemHash != null) localVarPathParams.Add("nemHash", Configuration.ApiClient.ParameterToString(nemHash)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetXPXTransactionUsingGET", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Get the XPX Transaction Hash Endpoint can be used to get XPX Transaction.
        /// </summary>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nemHash">XPX Transaction Hash</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetXPXTransactionUsingGETAsync (string nemHash)
        {
             ApiResponse<string> localVarResponse = await GetXPXTransactionUsingGETAsyncWithHttpInfo(nemHash);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the XPX Transaction Hash Endpoint can be used to get XPX Transaction.
        /// </summary>
        /// <exception cref="Io.Xpx.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nemHash">XPX Transaction Hash</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GetXPXTransactionUsingGETAsyncWithHttpInfo (string nemHash)
        {
            // verify the required parameter 'nemHash' is set
            if (nemHash == null)
                throw new ApiException(400, "Missing required parameter 'nemHash' when calling TransactionAndAnnounceApi->GetXPXTransactionUsingGET");

            var localVarPath = "/transaction/get/{nemHash}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (nemHash != null) localVarPathParams.Add("nemHash", Configuration.ApiClient.ParameterToString(nemHash)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetXPXTransactionUsingGET", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}
