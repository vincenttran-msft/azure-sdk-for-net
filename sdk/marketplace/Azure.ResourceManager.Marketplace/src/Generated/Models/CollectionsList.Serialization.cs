// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    internal partial class CollectionsList
    {
        internal static CollectionsList DeserializeCollectionsList(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateStoreCollectionInfoData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PrivateStoreCollectionInfoData> array = new List<PrivateStoreCollectionInfoData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new CollectionsList(Optional.ToList(value), nextLink.Value);
        }
    }
}
