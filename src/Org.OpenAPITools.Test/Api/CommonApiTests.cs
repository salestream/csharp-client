/* 
 * Salestream API
 *
 * Salestream API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing CommonApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CommonApiTests
    {
        private CommonApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CommonApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommonApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CommonApi
            //Assert.IsInstanceOfType(typeof(CommonApi), instance, "instance is a CommonApi");
        }

        
        /// <summary>
        /// Test EmailAddressesGet
        /// </summary>
        [Test]
        public void EmailAddressesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.EmailAddressesGet();
            //Assert.IsInstanceOf<SuccessResponse> (response, "response is SuccessResponse");
        }
        
        /// <summary>
        /// Test LeadStatusesGet
        /// </summary>
        [Test]
        public void LeadStatusesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.LeadStatusesGet();
            //Assert.IsInstanceOf<SuccessResponse> (response, "response is SuccessResponse");
        }
        
        /// <summary>
        /// Test OpportunityStatusesGet
        /// </summary>
        [Test]
        public void OpportunityStatusesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.OpportunityStatusesGet();
            //Assert.IsInstanceOf<SuccessResponse> (response, "response is SuccessResponse");
        }
        
        /// <summary>
        /// Test PhoneNumbersGet
        /// </summary>
        [Test]
        public void PhoneNumbersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PhoneNumbersGet();
            //Assert.IsInstanceOf<SuccessResponse> (response, "response is SuccessResponse");
        }
        
    }

}
