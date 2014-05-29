﻿using CallFire_csharp_sdk.API.Rest.Clients;
using CallFire_csharp_sdk.API.Soap;

namespace CallFire_csharp_sdk.API
{
    public class CallfireClient : ICallfireClient
    {
        private readonly string _username;
        private readonly string _password;
        private readonly CallfireClients _client;
        private IBroadcastClient _broadcastClient;
        private ISubscriptionClient _subscriptionClient;
        private ITextClient _textClient;
        private ICallClient _callClient;

        public CallfireClient(string username, string password, CallfireClients client)
        {
            _username = username;
            _password = password;
            _client = client;
        }

        public IBroadcastClient Broadcasts
        {
            get
            {
                if (_broadcastClient != null)
                {
                    return _broadcastClient;
                }
                return _client == CallfireClients.Rest ?
                    (_broadcastClient = new RestBroadcastClient(_username, _password)) :
                    (_broadcastClient = new SoapBroadcastClient(_username, _password));
            }
        }

        public ISubscriptionClient Subscription
        {
            get
            {
                if (_subscriptionClient != null)
                {
                    return _subscriptionClient;
                }
                return _client == CallfireClients.Rest ?
                    (_subscriptionClient = new RestSubscriptionClient(_username, _password)) :
                    (_subscriptionClient = new SoapSubscriptionClient(_username, _password));
            }
        }

        public ITextClient Text
        {
            get
            {
                if (_textClient != null)
                {
                    return _textClient;
                }
                return _client == CallfireClients.Rest ?
                    (_textClient = new RestTextClient(_username, _password)) :
                    (_textClient = new SoapTextClient(_username, _password));
            }
        }

        public ICallClient Call
        {
            get
            {
                if (_callClient != null)
                {
                    return _callClient;
                }
                return _client == CallfireClients.Rest ?
                    (_callClient = new RestCallClient(_username, _password)) :
                    (_callClient = new SoapCallClient(_username, _password));
            }
        }
    }
}
