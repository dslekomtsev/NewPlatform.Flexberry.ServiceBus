﻿namespace NewPlatform.Flexberry.ServiceBus.IntegratedTests.Components
{
    using System;
    using System.Linq;
    using Flexberry.ServiceBus.Components;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    using Xunit;

    public class DefaultSubscriptionsManagerTest : BaseServiceBusIntegratedTest
    {
        public DefaultSubscriptionsManagerTest()
            : base("SubsTests")
        {
        }

        /// <summary>
        /// Testing client deletion.
        /// </summary>
        [Fact]
        public void TestDeleteClient()
        {
            foreach (var dataService in DataServices)
            {
                // Arrange.
                const string client1Id = "FDF33DF1-5DCA-41F9-A2E4-3B5C7E103452";
                const string client2Id = "31D12F7D-2D0E-43FB-8092-E6D34A9AB87D";
                const string messageType1Id = "EB6EC229-5E93-4B76-9993-5A1589787421";
                const string messageType2Id = "C8802C67-AC1B-497C-A707-5FF4191E0083";
                const string messageType3Id = "BC3F54C6-4E2F-43DA-B124-A0771F8F200C";
                var service = new DefaultSubscriptionsManager(dataService, GetMockStatisticsService());
                var clientLcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Client), Client.Views.ListView);
                var messageLcs = LoadingCustomizationStruct.GetSimpleStruct(typeof(Message), Message.Views.MessageLightView);
                service.CreateClient(client1Id, "TestClient1");
                service.CreateClient(client2Id, "TestClient2");
                service.CreateMessageType(new ServiceBusMessageType
                {
                    Id = messageType1Id,
                    Name = "TestMessageType1",
                    Description = "ForTest"
                });
                service.CreateMessageType(new ServiceBusMessageType
                {
                    Id = messageType2Id,
                    Name = "TestMessageType2",
                    Description = "ForTest"
                });
                service.CreateMessageType(new ServiceBusMessageType
                {
                    Id = messageType3Id,
                    Name = "TestMessageType3",
                    Description = "ForTest"
                });
                service.Prepare();
                service.SubscribeOrUpdate(client1Id, messageType1Id, true, TransportType.WCF);
                service.SubscribeOrUpdate(client1Id, messageType3Id, true, TransportType.WCF);
                service.SubscribeOrUpdate(client1Id, messageType2Id, true, TransportType.WCF);
                service.SubscribeOrUpdate(client2Id, messageType2Id, true, TransportType.WCF);
                Guid client1Pk = ServiceHelper.ConvertClientIdToPrimaryKey(client1Id, dataService, GetMockStatisticsService());
                Guid messageType1Pk = ServiceHelper.ConvertMessageTypeIdToPrimaryKey(messageType1Id, dataService, GetMockStatisticsService());
                var client = new Client();
                client.SetExistObjectPrimaryKey(client1Pk);
                var messageType = new MessageType();
                messageType.SetExistObjectPrimaryKey(messageType1Pk);
                DataObject message = new Message()
                {
                    Recipient = client, MessageType = messageType, ReceivingTime = DateTime.Now
                };
                dataService.UpdateObject(message);

                // Act && Assert.
                var clients = dataService.LoadObjects(clientLcs);
                Assert.Equal(clients.Length, 2);
                var messages = dataService.LoadObjects(messageLcs);
                Assert.Equal(messages.Length, 1);
                var subs = service.GetSubscriptions(false);
                Assert.Equal(subs.Count(), 4);

                service.DeleteClient(client1Id);
                clients = dataService.LoadObjects(clientLcs);
                Assert.Equal(clients.Length, 1);
                Assert.True(clients.Cast<Client>().All(cl => Guid.Parse(cl.ID) == Guid.Parse(client2Id) || Guid.Parse(cl.__PrimaryKey.ToString()) == Guid.Parse(client2Id)));
                messages = dataService.LoadObjects(messageLcs);
                Assert.Equal(messages.Length, 0);
                subs = service.GetSubscriptions(false);
                Assert.Equal(subs.Count(), 1);
                Assert.True(subs.All(sub => Guid.Parse(sub.Client.ID) == Guid.Parse(client2Id) || Guid.Parse(sub.Client.__PrimaryKey.ToString()) == Guid.Parse(client2Id)));
                Assert.True(subs.All(sub => Guid.Parse(sub.MessageType.ID) == Guid.Parse(messageType2Id) || Guid.Parse(sub.MessageType.__PrimaryKey.ToString()) == Guid.Parse(messageType2Id)));
            }
        }

        /// <summary>
        /// Testing subscriptions load.
        /// </summary>
        [Fact]
        public void TestSubscriptionsLoading()
        {
            foreach (var dataService in DataServices)
            {
                // Arrange.
                const string client1Id = "FDF33DF1-5DCA-41F9-A2E4-3B5C7E103452";
                const string client2Id = "31D12F7D-2D0E-43FB-8092-E6D34A9AB87D";
                const string messageType1Id = "EB6EC229-5E93-4B76-9993-5A1589787421";
                const string messageType2Id = "C8802C67-AC1B-497C-A707-5FF4191E0083";
                const string messageType3Id = "BC3F54C6-4E2F-43DA-B124-A0771F8F200C";
                var service = new DefaultSubscriptionsManager(dataService, GetMockStatisticsService());
                service.CreateClient(client1Id, "TestClient1");
                service.CreateClient(client2Id, "TestClient2");
                service.CreateMessageType(new ServiceBusMessageType
                {
                    Id = messageType1Id,
                    Name = "TestMessageType1",
                    Description = "ForTest"
                });
                service.CreateMessageType(new ServiceBusMessageType
                {
                    Id = messageType2Id,
                    Name = "TestMessageType2",
                    Description = "ForTest"
                });
                service.CreateMessageType(new ServiceBusMessageType
                {
                    Id = messageType3Id,
                    Name = "TestMessageType3",
                    Description = "ForTest"
                });
                service.SubscribeOrUpdate(client1Id, messageType1Id, true, TransportType.WCF, DateTime.Now.AddDays(1));
                service.SubscribeOrUpdate(client1Id, messageType3Id, true, TransportType.WCF, DateTime.Now.AddDays(-1));
                service.SubscribeOrUpdate(client1Id, messageType2Id, false, null, DateTime.Now.AddDays(1));
                service.SubscribeOrUpdate(client2Id, messageType2Id, false, null, DateTime.Now.AddDays(1));

                // Act && Assert.
                var subs = service.GetSubscriptions();
                Assert.Equal(subs.Count(), 3);

                subs = service.GetSubscriptions(false);
                Assert.Equal(subs.Count(), 4);

                subs = service.GetSubscriptions(client2Id);
                Assert.Equal(subs.Count(), 1);
                Assert.True(subs.All(sub => Guid.Parse(sub.Client.ID) == Guid.Parse(client2Id) || Guid.Parse(sub.Client.__PrimaryKey.ToString()) == Guid.Parse(client2Id)));

                subs = service.GetSubscriptions(client2Id, false);
                Assert.Equal(subs.Count(), 1);
                Assert.True(subs.All(sub => Guid.Parse(sub.Client.ID) == Guid.Parse(client2Id) || Guid.Parse(sub.Client.__PrimaryKey.ToString()) == Guid.Parse(client2Id)));

                subs = service.GetCallbackSubscriptions();
                Assert.Equal(subs.Count(), 1);
                Assert.True(subs.All(sub => sub.IsCallback));

                subs = service.GetCallbackSubscriptions(false);
                Assert.Equal(subs.Count(), 2);
                Assert.True(subs.All(sub => sub.IsCallback));

                subs = service.GetSubscriptionsForMsgType(messageType2Id, client2Id);
                Assert.Equal(subs.Count(), 1);
                Assert.True(subs.All(sub => Guid.Parse(sub.MessageType.ID) == Guid.Parse(messageType2Id) || Guid.Parse(sub.MessageType.__PrimaryKey.ToString()) == Guid.Parse(messageType2Id)));

                subs = service.GetSubscriptionsForMsgType(messageType2Id);
                Assert.Equal(subs.Count(), 2);
                Assert.True(subs.All(sub => Guid.Parse(sub.MessageType.ID) == Guid.Parse(messageType2Id) || Guid.Parse(sub.MessageType.__PrimaryKey.ToString()) == Guid.Parse(messageType2Id)));
            }
        }

        /// <summary>
        /// Testing subscribtions creation and update.
        /// </summary>
        [Fact]
        public void TestSubscribtionCreate()
        {
            foreach (var dataService in DataServices)
            {
                // Arrange.
                const string clientId = "FDF33DF1-5DCA-41F9-A2E4-3B5C7E103452";
                const string messageType1Id = "EB6EC229-5E93-4B76-9993-5A1589787421";
                const string messageType2Id = "C8802C67-AC1B-497C-A707-5FF4191E0083";
                const string messageType3Id = "BC3F54C6-4E2F-43DA-B124-A0771F8F200C";
                var service = new DefaultSubscriptionsManager(dataService, GetMockStatisticsService());
                service.CreateClient(clientId, "TestClient1");
                service.CreateMessageType(new ServiceBusMessageType
                {
                    Id = messageType1Id,
                    Name = "TestMessageType1",
                    Description = "ForTest"
                });
                service.CreateMessageType(new ServiceBusMessageType
                {
                    Id = messageType2Id,
                    Name = "TestMessageType2",
                    Description = "ForTest"
                });
                service.CreateMessageType(new ServiceBusMessageType
                {
                    Id = messageType3Id,
                    Name = "TestMessageType3",
                    Description = "ForTest"
                });

                // Act && Assert.
                // Creation.
                service.SubscribeOrUpdate(clientId, messageType1Id, false, null);
                service.SubscribeOrUpdate(clientId, messageType2Id, true, TransportType.HTTP);
                Assert.Throws<ArgumentException>(() => service.SubscribeOrUpdate(clientId, messageType3Id, true, null));
                var subs = service.GetSubscriptions();
                Assert.Equal(subs.Count(), 2);
                Assert.True(subs.All(sub => Guid.Parse(sub.Client.ID) == Guid.Parse(clientId) || Guid.Parse(sub.Client.__PrimaryKey.ToString()) == Guid.Parse(clientId)));
                var sub1 =
                    subs.FirstOrDefault(sub => Guid.Parse(sub.MessageType.ID) == Guid.Parse(messageType1Id) ||
                            Guid.Parse(sub.MessageType.__PrimaryKey.ToString()) == Guid.Parse(messageType1Id));
                var sub2 =
                    subs.FirstOrDefault(sub => Guid.Parse(sub.MessageType.ID) == Guid.Parse(messageType2Id) ||
                            Guid.Parse(sub.MessageType.__PrimaryKey.ToString()) == Guid.Parse(messageType2Id));
                Assert.True(!sub1.IsCallback && sub1.TransportType == TransportType.WCF && DateTime.Now < sub1.ExpiryDate);
                Assert.True(sub2.IsCallback && sub2.TransportType == TransportType.HTTP && DateTime.Now < sub2.ExpiryDate);

                // Updating.
                service.SubscribeOrUpdate(clientId, messageType1Id, true, TransportType.HTTP, DateTime.Now.AddDays(-1));
                service.SubscribeOrUpdate(clientId, messageType2Id, false, null, DateTime.Now.AddDays(-1));
                subs = service.GetSubscriptions(false);
                Assert.Equal(subs.Count(), 2);
                Assert.True(subs.All(sub => Guid.Parse(sub.Client.ID) == Guid.Parse(clientId) || Guid.Parse(sub.Client.__PrimaryKey.ToString()) == Guid.Parse(clientId)));
                sub1 =
                    subs.FirstOrDefault(sub => Guid.Parse(sub.MessageType.ID) == Guid.Parse(messageType1Id) ||
                            Guid.Parse(sub.MessageType.__PrimaryKey.ToString()) == Guid.Parse(messageType1Id));
                sub2 =
                    subs.FirstOrDefault(sub => Guid.Parse(sub.MessageType.ID) == Guid.Parse(messageType2Id) ||
                            Guid.Parse(sub.MessageType.__PrimaryKey.ToString()) == Guid.Parse(messageType2Id));
                Assert.True(sub1.IsCallback && sub1.TransportType == TransportType.HTTP && DateTime.Now > sub1.ExpiryDate);
                Assert.True(!sub2.IsCallback && sub2.TransportType == TransportType.HTTP && DateTime.Now > sub2.ExpiryDate);

                // Update all.
                service.UpdateAllSubscriptions(clientId);
                subs = service.GetSubscriptions();
                Assert.Equal(subs.Count(), 2);
                Assert.True(subs.All(sub => sub.ExpiryDate > DateTime.Now));
            }
        }
    }
}
