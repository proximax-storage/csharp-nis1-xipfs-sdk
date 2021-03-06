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
    ///  Class for testing AccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountApiTests
    {
        private AccountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountApi
            //Assert.IsInstanceOfType(typeof(AccountApi), instance, "instance is a AccountApi");
        }

        
        /// <summary>
        /// Test GetAllIncomingNemAddressTransactionsUsingGET
        /// </summary>
        [Test]
        public void GetAllIncomingNemAddressTransactionsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicKey = null;
            //var response = instance.GetAllIncomingNemAddressTransactionsUsingGET(publicKey);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetAllNemAddressTransactionsUsingGET
        /// </summary>
        [Test]
        public void GetAllNemAddressTransactionsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicKey = null;
            //var response = instance.GetAllNemAddressTransactionsUsingGET(publicKey);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetAllNemAddressTransactionsWithPageSizeUsingGET
        /// </summary>
        [Test]
        public void GetAllNemAddressTransactionsWithPageSizeUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicKey = null;
            //string pageSize = null;
            //var response = instance.GetAllNemAddressTransactionsWithPageSizeUsingGET(publicKey, pageSize);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetAllOutgoingNemAddressTransactionsUsingGET
        /// </summary>
        [Test]
        public void GetAllOutgoingNemAddressTransactionsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicKey = null;
            //var response = instance.GetAllOutgoingNemAddressTransactionsUsingGET(publicKey);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetAllUnconfirmedNemAddressTransactionsUsingGET
        /// </summary>
        [Test]
        public void GetAllUnconfirmedNemAddressTransactionsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicKey = null;
            //var response = instance.GetAllUnconfirmedNemAddressTransactionsUsingGET(publicKey);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetNemAddressDetailsUsingGET
        /// </summary>
        [Test]
        public void GetNemAddressDetailsUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string publicKey = null;
            //var response = instance.GetNemAddressDetailsUsingGET(publicKey);
            //Assert.IsInstanceOf<AccountMetaDataPair> (response, "response is AccountMetaDataPair");
        }
        
    }

}
