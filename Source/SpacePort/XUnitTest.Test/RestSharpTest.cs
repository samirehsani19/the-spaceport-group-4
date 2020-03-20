﻿using RestSharp;
using SpacePort;
using System;
using System.Collections.Generic;
using Xunit;
using Newtonsoft.Json;
using System.Linq;

namespace XUnitTest.Test
{
    public class RestSharpTest
    {
        [Fact]
        public void TestSimpleGet()
        {
            var client = new RestClient("https://swapi.co/api/");
            var request = new RestRequest("people/", Method.GET);

            var content = client.Execute(request).Content;           
        }

        [Fact]
        public void createApiClass()
        {
            StarWarsApi api = new StarWarsApi();
            api.ShowData("people");

            Assert.NotNull(api);
        }

        [Fact]
        public void CreateApifields()
        {
            StarWarsApi api = new StarWarsApi();
            string path = api.Path;
            RestClient client = api.Client;

            Assert.NotNull(api);
        }

        [Fact]
        public void TestPath()
        {
            StarWarsApi api = new StarWarsApi();
            Assert.Equal("https://swapi.co/api/", api.Path);
        }

        [Fact]
        public void TestShowData()
        {
            StarWarsApi api = new StarWarsApi();

            var data = api.ShowData("people");

            Assert.IsType<Newtonsoft.Json.Linq.JObject>(data);
        }

        [Fact]
        public void AddShowShipMethod()
        {
            StarWarsApi api = new StarWarsApi();
            int startIndex = api.StartIndex;
            int endIndex = api.EndIndex;
            api.ShipData();
        }
    }
}
