// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace MgmtTypeSpec.Models
{
    /// <summary> The response of a Foo list operation. </summary>
    public partial class FooListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal FooListResult(IEnumerable<FooData> value)
        {
            Value = value.ToList();
        }

        internal FooListResult(IList<FooData> value, Uri nextLink, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Value = value;
            NextLink = nextLink;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The Foo items on this page. </summary>
        public IList<FooData> Value { get; }

        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
