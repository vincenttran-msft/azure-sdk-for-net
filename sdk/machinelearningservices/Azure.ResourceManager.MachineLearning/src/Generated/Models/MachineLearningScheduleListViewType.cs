// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningScheduleListViewType.
    /// Serialized Name: ScheduleListViewType
    /// </summary>
    public readonly partial struct MachineLearningScheduleListViewType : IEquatable<MachineLearningScheduleListViewType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningScheduleListViewType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningScheduleListViewType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledOnlyValue = "EnabledOnly";
        private const string DisabledOnlyValue = "DisabledOnly";
        private const string AllValue = "All";

        /// <summary>
        /// EnabledOnly
        /// Serialized Name: ScheduleListViewType.EnabledOnly
        /// </summary>
        public static MachineLearningScheduleListViewType EnabledOnly { get; } = new MachineLearningScheduleListViewType(EnabledOnlyValue);
        /// <summary>
        /// DisabledOnly
        /// Serialized Name: ScheduleListViewType.DisabledOnly
        /// </summary>
        public static MachineLearningScheduleListViewType DisabledOnly { get; } = new MachineLearningScheduleListViewType(DisabledOnlyValue);
        /// <summary>
        /// All
        /// Serialized Name: ScheduleListViewType.All
        /// </summary>
        public static MachineLearningScheduleListViewType All { get; } = new MachineLearningScheduleListViewType(AllValue);
        /// <summary> Determines if two <see cref="MachineLearningScheduleListViewType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningScheduleListViewType left, MachineLearningScheduleListViewType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningScheduleListViewType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningScheduleListViewType left, MachineLearningScheduleListViewType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningScheduleListViewType"/>. </summary>
        public static implicit operator MachineLearningScheduleListViewType(string value) => new MachineLearningScheduleListViewType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningScheduleListViewType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningScheduleListViewType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
