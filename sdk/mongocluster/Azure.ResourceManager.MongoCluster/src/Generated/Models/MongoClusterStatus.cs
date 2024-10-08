// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> The status of the Mongo cluster resource. </summary>
    public readonly partial struct MongoClusterStatus : IEquatable<MongoClusterStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoClusterStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoClusterStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadyValue = "Ready";
        private const string ProvisioningValue = "Provisioning";
        private const string UpdatingValue = "Updating";
        private const string StartingValue = "Starting";
        private const string StoppingValue = "Stopping";
        private const string StoppedValue = "Stopped";
        private const string DroppingValue = "Dropping";

        /// <summary> The mongo cluster resource is ready for use. </summary>
        public static MongoClusterStatus Ready { get; } = new MongoClusterStatus(ReadyValue);
        /// <summary> The mongo cluster resource is being provisioned. </summary>
        public static MongoClusterStatus Provisioning { get; } = new MongoClusterStatus(ProvisioningValue);
        /// <summary> The mongo cluster resource is being updated. </summary>
        public static MongoClusterStatus Updating { get; } = new MongoClusterStatus(UpdatingValue);
        /// <summary> The mongo cluster resource is being started. </summary>
        public static MongoClusterStatus Starting { get; } = new MongoClusterStatus(StartingValue);
        /// <summary> The mongo cluster resource is being stopped. </summary>
        public static MongoClusterStatus Stopping { get; } = new MongoClusterStatus(StoppingValue);
        /// <summary> The mongo cluster resource is stopped. </summary>
        public static MongoClusterStatus Stopped { get; } = new MongoClusterStatus(StoppedValue);
        /// <summary> The mongo cluster resource is being dropped. </summary>
        public static MongoClusterStatus Dropping { get; } = new MongoClusterStatus(DroppingValue);
        /// <summary> Determines if two <see cref="MongoClusterStatus"/> values are the same. </summary>
        public static bool operator ==(MongoClusterStatus left, MongoClusterStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoClusterStatus"/> values are not the same. </summary>
        public static bool operator !=(MongoClusterStatus left, MongoClusterStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MongoClusterStatus"/>. </summary>
        public static implicit operator MongoClusterStatus(string value) => new MongoClusterStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoClusterStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoClusterStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
