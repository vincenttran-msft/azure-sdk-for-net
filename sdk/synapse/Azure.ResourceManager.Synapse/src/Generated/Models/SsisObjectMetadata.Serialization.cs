// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SsisObjectMetadata
    {
        internal static SsisObjectMetadata DeserializeSsisObjectMetadata(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Environment": return SsisEnvironment.DeserializeSsisEnvironment(element);
                    case "Folder": return SsisFolder.DeserializeSsisFolder(element);
                    case "Package": return SsisPackage.DeserializeSsisPackage(element);
                    case "Project": return SsisProject.DeserializeSsisProject(element);
                }
            }
            return UnknownSsisObjectMetadata.DeserializeUnknownSsisObjectMetadata(element);
        }
    }
}
