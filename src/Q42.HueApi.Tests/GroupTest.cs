﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Q42.HueApi.Interfaces;

namespace Q42.HueApi.Tests
{
  [TestClass]
  public class GroupTest
  {
    private IHueClient _client;

    [TestInitialize]
    public void Initialize()
    {
      string ip = ConfigurationManager.AppSettings["ip"].ToString();
      string key = ConfigurationManager.AppSettings["key"].ToString();

      _client = new HueClient(ip, key);
    }

    [TestMethod]
    public async Task CreateGroup()
    {
      List<string> lights = new List<string>() {"1", "2" };

      try
      {
        string groupId = await _client.CreateGroup(lights);
      }
      catch (Exception e)
      {
      }
    }

    [TestMethod]
    public async Task DeleteGroup()
    {
      string groupId = "16";

      try
      {
        await _client.DeleteGroup(groupId);
      }
      catch (Exception e)
      {
      }
    }
  }
}
