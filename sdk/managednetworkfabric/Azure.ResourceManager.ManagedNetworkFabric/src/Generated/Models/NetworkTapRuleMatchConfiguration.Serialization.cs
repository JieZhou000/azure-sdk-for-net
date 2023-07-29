// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkTapRuleMatchConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MatchConfigurationName))
            {
                writer.WritePropertyName("matchConfigurationName"u8);
                writer.WriteStringValue(MatchConfigurationName);
            }
            if (Optional.IsDefined(SequenceNumber))
            {
                writer.WritePropertyName("sequenceNumber"u8);
                writer.WriteNumberValue(SequenceNumber.Value);
            }
            if (Optional.IsDefined(IPAddressType))
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(MatchConditions))
            {
                writer.WritePropertyName("matchConditions"u8);
                writer.WriteStartArray();
                foreach (var item in MatchConditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NetworkTapRuleMatchConfiguration DeserializeNetworkTapRuleMatchConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> matchConfigurationName = default;
            Optional<long> sequenceNumber = default;
            Optional<NetworkFabricIPAddressType> ipAddressType = default;
            Optional<IList<NetworkTapRuleMatchCondition>> matchConditions = default;
            Optional<IList<NetworkTapRuleAction>> actions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchConfigurationName"u8))
                {
                    matchConfigurationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("ipAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddressType = new NetworkFabricIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("matchConditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkTapRuleMatchCondition> array = new List<NetworkTapRuleMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkTapRuleMatchCondition.DeserializeNetworkTapRuleMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkTapRuleAction> array = new List<NetworkTapRuleAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkTapRuleAction.DeserializeNetworkTapRuleAction(item));
                    }
                    actions = array;
                    continue;
                }
            }
            return new NetworkTapRuleMatchConfiguration(matchConfigurationName.Value, Optional.ToNullable(sequenceNumber), Optional.ToNullable(ipAddressType), Optional.ToList(matchConditions), Optional.ToList(actions));
        }
    }
}
