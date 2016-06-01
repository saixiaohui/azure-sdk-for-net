// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Regenerate key parameters.
    /// </summary>
    public partial class RegenerateKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateKeyParameters class.
        /// </summary>
        public RegenerateKeyParameters() { }

        /// <summary>
        /// Initializes a new instance of the RegenerateKeyParameters class.
        /// </summary>
        public RegenerateKeyParameters(KeyName? keyName = default(KeyName?))
        {
            KeyName = keyName;
        }

        /// <summary>
        /// key name to generate (Key1|Key2). Possible values include: 'Key1',
        /// 'Key2'
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public KeyName? KeyName { get; set; }

    }
}
