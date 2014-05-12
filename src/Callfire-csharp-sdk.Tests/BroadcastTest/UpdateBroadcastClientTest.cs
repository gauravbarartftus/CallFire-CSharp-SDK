﻿using System;
using CallFire_csharp_sdk.API;
using CallFire_csharp_sdk.Common.DataManagement;
using NUnit.Framework;

namespace Callfire_csharp_sdk.Tests.BroadcastTest
{
    [TestFixture]
    public abstract class UpdateBroadcastClientTest
    {
        protected IBroadcastClient Client;

        protected long BroadcastId;
        protected string BroadcastName;
        protected DateTime BroadcastLastModified;

        [Test]
        public void Test_UpdateBroadcast()
        {
            var broadcast = new CfBroadcast(BroadcastId, BroadcastName, CfBroadcastStatus.Running, DateTime.Now, CfBroadcastType.Text, null);
            Client.UpdateBroadcast(broadcast);
        }
    }
}
