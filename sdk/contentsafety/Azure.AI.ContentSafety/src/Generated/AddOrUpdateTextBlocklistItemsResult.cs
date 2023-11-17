// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    /// <summary> The response of adding blocklistItems to the text blocklist. </summary>
    public partial class AddOrUpdateTextBlocklistItemsResult
    {
        /// <summary> Initializes a new instance of AddOrUpdateTextBlocklistItemsResult. </summary>
        /// <param name="blocklistItems"> Array of blocklistItems have been added. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blocklistItems"/> is null. </exception>
        internal AddOrUpdateTextBlocklistItemsResult(IEnumerable<TextBlocklistItem> blocklistItems)
        {
            Argument.AssertNotNull(blocklistItems, nameof(blocklistItems));

            BlocklistItems = blocklistItems.ToList();
        }

        /// <summary> Initializes a new instance of AddOrUpdateTextBlocklistItemsResult. </summary>
        /// <param name="blocklistItems"> Array of blocklistItems have been added. </param>
        internal AddOrUpdateTextBlocklistItemsResult(IReadOnlyList<TextBlocklistItem> blocklistItems)
        {
            BlocklistItems = blocklistItems;
        }

        /// <summary> Array of blocklistItems have been added. </summary>
        public IReadOnlyList<TextBlocklistItem> BlocklistItems { get; }
    }
}
