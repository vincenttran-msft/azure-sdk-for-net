// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// A collection of information about the state of the connection between service consumer and provider.
    /// Serialized Name: PrivateLinkServiceConnectionState
    /// </summary>
    public partial class MachineLearningPrivateLinkServiceConnectionState
    {
        /// <summary> Initializes a new instance of MachineLearningPrivateLinkServiceConnectionState. </summary>
        public MachineLearningPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningPrivateLinkServiceConnectionState. </summary>
        /// <param name="status">
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// Serialized Name: PrivateLinkServiceConnectionState.status
        /// </param>
        /// <param name="description">
        /// The reason for approval/rejection of the connection.
        /// Serialized Name: PrivateLinkServiceConnectionState.description
        /// </param>
        /// <param name="actionsRequired">
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// Serialized Name: PrivateLinkServiceConnectionState.actionsRequired
        /// </param>
        internal MachineLearningPrivateLinkServiceConnectionState(MachineLearningPrivateEndpointServiceConnectionStatus? status, string description, string actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// Serialized Name: PrivateLinkServiceConnectionState.status
        /// </summary>
        public MachineLearningPrivateEndpointServiceConnectionStatus? Status { get; set; }
        /// <summary>
        /// The reason for approval/rejection of the connection.
        /// Serialized Name: PrivateLinkServiceConnectionState.description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// Serialized Name: PrivateLinkServiceConnectionState.actionsRequired
        /// </summary>
        public string ActionsRequired { get; set; }
    }
}
