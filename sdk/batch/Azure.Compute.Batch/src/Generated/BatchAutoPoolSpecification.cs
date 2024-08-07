// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// Specifies characteristics for a temporary 'auto pool'. The Batch service will
    /// create this auto Pool when the Job is submitted.
    /// </summary>
    public partial class BatchAutoPoolSpecification
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchAutoPoolSpecification"/>. </summary>
        /// <param name="poolLifetimeOption"> The minimum lifetime of created auto Pools, and how multiple Jobs on a schedule are assigned to Pools. </param>
        public BatchAutoPoolSpecification(BatchPoolLifetimeOption poolLifetimeOption)
        {
            PoolLifetimeOption = poolLifetimeOption;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAutoPoolSpecification"/>. </summary>
        /// <param name="autoPoolIdPrefix"> A prefix to be added to the unique identifier when a Pool is automatically created. The Batch service assigns each auto Pool a unique identifier on creation. To distinguish between Pools created for different purposes, you can specify this element to add a prefix to the ID that is assigned. The prefix can be up to 20 characters long. </param>
        /// <param name="poolLifetimeOption"> The minimum lifetime of created auto Pools, and how multiple Jobs on a schedule are assigned to Pools. </param>
        /// <param name="keepAlive"> Whether to keep an auto Pool alive after its lifetime expires. If false, the Batch service deletes the Pool once its lifetime (as determined by the poolLifetimeOption setting) expires; that is, when the Job or Job Schedule completes. If true, the Batch service does not delete the Pool automatically. It is up to the user to delete auto Pools created with this option. </param>
        /// <param name="pool"> The Pool specification for the auto Pool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchAutoPoolSpecification(string autoPoolIdPrefix, BatchPoolLifetimeOption poolLifetimeOption, bool? keepAlive, BatchPoolSpecification pool, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AutoPoolIdPrefix = autoPoolIdPrefix;
            PoolLifetimeOption = poolLifetimeOption;
            KeepAlive = keepAlive;
            Pool = pool;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAutoPoolSpecification"/> for deserialization. </summary>
        internal BatchAutoPoolSpecification()
        {
        }

        /// <summary> A prefix to be added to the unique identifier when a Pool is automatically created. The Batch service assigns each auto Pool a unique identifier on creation. To distinguish between Pools created for different purposes, you can specify this element to add a prefix to the ID that is assigned. The prefix can be up to 20 characters long. </summary>
        public string AutoPoolIdPrefix { get; set; }
        /// <summary> The minimum lifetime of created auto Pools, and how multiple Jobs on a schedule are assigned to Pools. </summary>
        public BatchPoolLifetimeOption PoolLifetimeOption { get; set; }
        /// <summary> Whether to keep an auto Pool alive after its lifetime expires. If false, the Batch service deletes the Pool once its lifetime (as determined by the poolLifetimeOption setting) expires; that is, when the Job or Job Schedule completes. If true, the Batch service does not delete the Pool automatically. It is up to the user to delete auto Pools created with this option. </summary>
        public bool? KeepAlive { get; set; }
        /// <summary> The Pool specification for the auto Pool. </summary>
        public BatchPoolSpecification Pool { get; set; }
    }
}
