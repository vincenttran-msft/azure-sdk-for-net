// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MixedReality.Models
{
    internal static partial class SerialExtensions
    {
        public static Serial ToSerial(this int value)
        {
            if (value == 1) return Serial.Primary;
            if (value == 2) return Serial.Secondary;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Serial value.");
        }
    }
}
