// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> Contains the analyze text PIIEntityRecognition LRO task. </summary>
    public partial class PiiOperationAction : AnalyzeTextOperationAction
    {
        /// <summary> Initializes a new instance of <see cref="PiiOperationAction"/>. </summary>
        public PiiOperationAction()
        {
            Kind = AnalyzeTextOperationActionKind.PiiEntityRecognition;
        }

        /// <summary> Initializes a new instance of <see cref="PiiOperationAction"/>. </summary>
        /// <param name="name"> task name. </param>
        /// <param name="kind"> The kind of task to perform. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="actionContent"> Pii task parameters. </param>
        internal PiiOperationAction(string name, AnalyzeTextOperationActionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, PiiActionContent actionContent) : base(name, kind, serializedAdditionalRawData)
        {
            ActionContent = actionContent;
        }

        /// <summary> Pii task parameters. </summary>
        public PiiActionContent ActionContent { get; set; }
    }
}
