/* 
 * Proximax P2P Storage REST API
 *
 * Proximax P2P Storage REST API
 *
 * OpenAPI spec version: v0.0.1
 * Contact: alvin.reyes@botmill.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Io.Xpx.Client;
using Io.Xpx.Api;
using Io.Xpx.Model;

namespace Io.Xpx.Test
{
    /// <summary>
    ///  Class for testing DataHashApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DataHashApiTests
    {
        private DataHashApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataHashApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataHashApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataHashApi
            //Assert.IsInstanceOfType(typeof(DataHashApi), instance, "instance is a DataHashApi");
        }

        
        /// <summary>
        /// Test CleanupPinnedContentUsingPOST
        /// </summary>
        [Test]
        public void CleanupPinnedContentUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string multihash = null;
            //var response = instance.CleanupPinnedContentUsingPOST(multihash);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GenerateHashAndExposeDataToNetworkUsingPOST
        /// </summary>
        [Test]
        public void GenerateHashAndExposeDataToNetworkUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string data = null;
            //string name = null;
            //string keywords = null;
            //string metadata = null;
            //var response = instance.GenerateHashAndExposeDataToNetworkUsingPOST(data, name, keywords, metadata);
            //Assert.IsInstanceOf<BinaryTransactionEncryptedMessage> (response, "response is BinaryTransactionEncryptedMessage");
        }
        
        /// <summary>
        /// Test GenerateHashAndExposeFileToNetworkUsingPOST
        /// </summary>
        [Test]
        public void GenerateHashAndExposeFileToNetworkUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //string keywords = null;
            //string metadata = null;
            //var response = instance.GenerateHashAndExposeFileToNetworkUsingPOST(file, keywords, metadata);
            //Assert.IsInstanceOf<BinaryTransactionEncryptedMessage> (response, "response is BinaryTransactionEncryptedMessage");
        }
        
        /// <summary>
        /// Test GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOST
        /// </summary>
        [Test]
        public void GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xPvkey = null;
            //string xPubkey = null;
            //string messageType = null;
            //string data = null;
            //string keywords = null;
            //string metadata = null;
            //var response = instance.GenerateHashExposeByteArrayToNetworkBuildAndSignUsingPOST(xPvkey, xPubkey, messageType, data, keywords, metadata);
            //Assert.IsInstanceOf<RequestAnnounceDataSignature> (response, "response is RequestAnnounceDataSignature");
        }
        
        /// <summary>
        /// Test GenerateHashExposeFileToNetworkBuildAndSignUsingPOST
        /// </summary>
        [Test]
        public void GenerateHashExposeFileToNetworkBuildAndSignUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xPvkey = null;
            //string xPubkey = null;
            //string messageType = null;
            //System.IO.Stream file = null;
            //string keywords = null;
            //string metadata = null;
            //var response = instance.GenerateHashExposeFileToNetworkBuildAndSignUsingPOST(xPvkey, xPubkey, messageType, file, keywords, metadata);
            //Assert.IsInstanceOf<RequestAnnounceDataSignature> (response, "response is RequestAnnounceDataSignature");
        }
        
        /// <summary>
        /// Test GenerateHashForDataOnlyUsingPOST
        /// </summary>
        [Test]
        public void GenerateHashForDataOnlyUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string data = null;
            //string keywords = null;
            //string metadata = null;
            //var response = instance.GenerateHashForDataOnlyUsingPOST(data, keywords, metadata);
            //Assert.IsInstanceOf<BinaryTransactionEncryptedMessage> (response, "response is BinaryTransactionEncryptedMessage");
        }
        
        /// <summary>
        /// Test GenerateHashForFileOnlyUsingPOST
        /// </summary>
        [Test]
        public void GenerateHashForFileOnlyUsingPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //string keywords = null;
            //string metadata = null;
            //var response = instance.GenerateHashForFileOnlyUsingPOST(file, keywords, metadata);
            //Assert.IsInstanceOf<BinaryTransactionEncryptedMessage> (response, "response is BinaryTransactionEncryptedMessage");
        }
        
    }

}