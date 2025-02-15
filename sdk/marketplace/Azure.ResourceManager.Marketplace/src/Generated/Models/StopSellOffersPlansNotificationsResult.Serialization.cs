// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class StopSellOffersPlansNotificationsResult
    {
        internal static StopSellOffersPlansNotificationsResult DeserializeStopSellOffersPlansNotificationsResult(JsonElement element)
        {
            Optional<string> offerId = default;
            Optional<string> displayName = default;
            Optional<bool> isEntire = default;
            Optional<long> messageCode = default;
            Optional<Uri> icon = default;
            Optional<IReadOnlyList<PlanNotificationDetails>> plans = default;
            Optional<bool> publicContext = default;
            Optional<IReadOnlyList<string>> subscriptionsIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerId"))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEntire"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isEntire = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("messageCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    messageCode = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("icon"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        icon = null;
                        continue;
                    }
                    icon = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("plans"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PlanNotificationDetails> array = new List<PlanNotificationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PlanNotificationDetails.DeserializePlanNotificationDetails(item));
                    }
                    plans = array;
                    continue;
                }
                if (property.NameEquals("publicContext"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    publicContext = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subscriptionsIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subscriptionsIds = array;
                    continue;
                }
            }
            return new StopSellOffersPlansNotificationsResult(offerId.Value, displayName.Value, Optional.ToNullable(isEntire), Optional.ToNullable(messageCode), icon.Value, Optional.ToList(plans), Optional.ToNullable(publicContext), Optional.ToList(subscriptionsIds));
        }
    }
}
