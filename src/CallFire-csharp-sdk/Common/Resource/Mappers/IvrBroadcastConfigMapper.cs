﻿using CallFire_csharp_sdk.API.Soap;
using CallFire_csharp_sdk.Common.DataManagement;

namespace CallFire_csharp_sdk.Common.Resource.Mappers
{
    class IvrBroadcastConfigMapper
    {
        internal static CfIvrBroadcastConfig FromSoapIvrBroadcastConfig(IvrBroadcastConfig source)
        {
            if (source == null)
            {
                return null;
            }
            var localTimeZoneRestriction =
                LocalTimeZoneRestrictionMapper.FromSoapLocalTimeZoneRestriction(source.LocalTimeZoneRestriction);
            var retryConfig = BroadcastConfigRetryConfigMapper.FromBroadcastConfigRetryConfig(source.RetryConfig);
            return new CfIvrBroadcastConfig(source.id, source.Created, source.FromNumber, localTimeZoneRestriction, retryConfig, source.DialplanXml);
        }

        internal static IvrBroadcastConfig ToSoapIvrBroadcastConfig(CfIvrBroadcastConfig source)
        {
            if (source == null)
            {
                return null;
            }
            var localTimeZoneRestriction =
                LocalTimeZoneRestrictionMapper.ToSoapLocalTimeZoneRestriction(source.LocalTimeZoneRestriction);
            var retryConfig = BroadcastConfigRetryConfigMapper.ToBroadcastConfigRetryConfig(source.RetryConfig);
            return new IvrBroadcastConfig(source.Id, source.Created, source.FromNumber, localTimeZoneRestriction, retryConfig, source.DialplanXml);
        }
    }
}
