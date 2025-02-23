/*
 * Echo Server API
 *
 * Echo Server API
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: team@openapitools.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing HeaderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HeaderApiTests : IDisposable
    {
        private HeaderApi instance;

        public HeaderApiTests()
        {
            instance = new HeaderApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HeaderApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' HeaderApi
            //Assert.IsType<HeaderApi>(instance);
        }

        /// <summary>
        /// Test TestHeaderIntegerBooleanStringEnums
        /// </summary>
        [Fact]
        public void TestHeaderIntegerBooleanStringEnumsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? integerHeader = null;
            //bool? booleanHeader = null;
            //string? stringHeader = null;
            //string? enumNonrefStringHeader = null;
            //StringEnumRef? enumRefStringHeader = null;
            //var response = instance.TestHeaderIntegerBooleanStringEnums(integerHeader, booleanHeader, stringHeader, enumNonrefStringHeader, enumRefStringHeader);
            //Assert.IsType<string>(response);
        }
    }
}
