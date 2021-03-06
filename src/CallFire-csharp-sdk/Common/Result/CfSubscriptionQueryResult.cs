﻿using CallFire_csharp_sdk.Common.DataManagement;

namespace CallFire_csharp_sdk.Common.Result
{
    public class CfSubscriptionQueryResult : CfQueryResult
    {
        public CfSubscriptionQueryResult(long totalResults, CfSubscription[] subscription)
            : base(totalResults)
        {
            Subscription = subscription;
        }

        /// <summary>
        /// List of Subscriptions
        /// </summary>
        public CfSubscription[] Subscription { get; set; }
    }
}
