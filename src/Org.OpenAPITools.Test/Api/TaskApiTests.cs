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
    ///  Class for testing TaskApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TaskApiTests
    {
        private TaskApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TaskApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaskApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TaskApi
            //Assert.IsInstanceOfType(typeof(TaskApi), instance, "instance is a TaskApi");
        }

        
        /// <summary>
        /// Test LeadIdTaskPost
        /// </summary>
        [Test]
        public void LeadIdTaskPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? date = null;
            //string userId = null;
            //string desc = null;
            //var response = instance.LeadIdTaskPost(id, date, userId, desc);
            //Assert.IsInstanceOf<SuccessResponse> (response, "response is SuccessResponse");
        }
        
        /// <summary>
        /// Test LeadIdTaskTaskIdDelete
        /// </summary>
        [Test]
        public void LeadIdTaskTaskIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string taskId = null;
            //var response = instance.LeadIdTaskTaskIdDelete(id, taskId);
            //Assert.IsInstanceOf<SuccessResponse> (response, "response is SuccessResponse");
        }
        
        /// <summary>
        /// Test LeadIdTaskTaskIdPut
        /// </summary>
        [Test]
        public void LeadIdTaskTaskIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string taskId = null;
            //int? date = null;
            //string userId = null;
            //string desc = null;
            //var response = instance.LeadIdTaskTaskIdPut(id, taskId, date, userId, desc);
            //Assert.IsInstanceOf<SuccessResponse> (response, "response is SuccessResponse");
        }
        
    }

}
