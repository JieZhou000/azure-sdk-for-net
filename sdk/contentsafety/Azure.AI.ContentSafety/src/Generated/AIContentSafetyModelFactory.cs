// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.ContentSafety
{
    /// <summary> Model factory for models. </summary>
    public static partial class AIContentSafetyModelFactory
    {
        /// <summary> Initializes a new instance of AnalyzeTextResult. </summary>
        /// <param name="blocklistsMatch"> The blocklist match details. </param>
        /// <param name="categoriesAnalysis"> Analysis result for categories. </param>
        /// <returns> A new <see cref="ContentSafety.AnalyzeTextResult"/> instance for mocking. </returns>
        public static AnalyzeTextResult AnalyzeTextResult(IEnumerable<TextBlocklistMatch> blocklistsMatch = null, IEnumerable<TextCategoriesAnalysis> categoriesAnalysis = null)
        {
            blocklistsMatch ??= new List<TextBlocklistMatch>();
            categoriesAnalysis ??= new List<TextCategoriesAnalysis>();

            return new AnalyzeTextResult(blocklistsMatch?.ToList(), categoriesAnalysis?.ToList());
        }

        /// <summary> Initializes a new instance of TextBlocklistMatch. </summary>
        /// <param name="blocklistName"> The name of the matched blocklist. </param>
        /// <param name="blocklistItemId"> The ID of the matched item. </param>
        /// <param name="blocklistItemText"> The content of the matched item. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blocklistName"/>, <paramref name="blocklistItemId"/> or <paramref name="blocklistItemText"/> is null. </exception>
        /// <returns> A new <see cref="ContentSafety.TextBlocklistMatch"/> instance for mocking. </returns>
        public static TextBlocklistMatch TextBlocklistMatch(string blocklistName = null, string blocklistItemId = null, string blocklistItemText = null)
        {
            if (blocklistName == null)
            {
                throw new ArgumentNullException(nameof(blocklistName));
            }
            if (blocklistItemId == null)
            {
                throw new ArgumentNullException(nameof(blocklistItemId));
            }
            if (blocklistItemText == null)
            {
                throw new ArgumentNullException(nameof(blocklistItemText));
            }

            return new TextBlocklistMatch(blocklistName, blocklistItemId, blocklistItemText);
        }

        /// <summary> Initializes a new instance of TextCategoriesAnalysis. </summary>
        /// <param name="category"> The text analysis category. </param>
        /// <param name="severity"> The value increases with the severity of the input content. The value of this field is determined by the output type specified in the request. The output type could be ‘FourSeverityLevels’ or ‘EightSeverity Levels’, and the output value can be 0, 2, 4, 6 or 0, 1, 2, 3, 4, 5, 6, or 7. </param>
        /// <returns> A new <see cref="ContentSafety.TextCategoriesAnalysis"/> instance for mocking. </returns>
        public static TextCategoriesAnalysis TextCategoriesAnalysis(TextCategory category = default, int? severity = null)
        {
            return new TextCategoriesAnalysis(category, severity);
        }

        /// <summary> Initializes a new instance of AnalyzeImageResult. </summary>
        /// <param name="categoriesAnalysis"> Analysis result for categories. </param>
        /// <returns> A new <see cref="ContentSafety.AnalyzeImageResult"/> instance for mocking. </returns>
        public static AnalyzeImageResult AnalyzeImageResult(IEnumerable<ImageCategoriesAnalysis> categoriesAnalysis = null)
        {
            categoriesAnalysis ??= new List<ImageCategoriesAnalysis>();

            return new AnalyzeImageResult(categoriesAnalysis?.ToList());
        }

        /// <summary> Initializes a new instance of ImageCategoriesAnalysis. </summary>
        /// <param name="category"> The image analysis category. </param>
        /// <param name="severity"> The value increases with the severity of the input content. The value of this field is determined by the output type specified in the request. The output type could be ‘FourSeverityLevels’, and the output value can be 0, 2, 4, 6. </param>
        /// <returns> A new <see cref="ContentSafety.ImageCategoriesAnalysis"/> instance for mocking. </returns>
        public static ImageCategoriesAnalysis ImageCategoriesAnalysis(ImageCategory category = default, int? severity = null)
        {
            return new ImageCategoriesAnalysis(category, severity);
        }

        /// <summary> Initializes a new instance of TextBlocklistItem. </summary>
        /// <param name="blocklistItemId"> The service will generate a BlocklistItemId, which will be a UUID. </param>
        /// <param name="description"> BlocklistItem description. </param>
        /// <param name="text"> BlocklistItem content. </param>
        /// <returns> A new <see cref="ContentSafety.TextBlocklistItem"/> instance for mocking. </returns>
        public static TextBlocklistItem TextBlocklistItem(string blocklistItemId = null, string description = null, string text = null)
        {
            return new TextBlocklistItem(blocklistItemId, description, text);
        }

        /// <summary> Initializes a new instance of AddOrUpdateTextBlocklistItemsResult. </summary>
        /// <param name="blocklistItems"> Array of blocklistItems have been added. </param>
        /// <returns> A new <see cref="ContentSafety.AddOrUpdateTextBlocklistItemsResult"/> instance for mocking. </returns>
        public static AddOrUpdateTextBlocklistItemsResult AddOrUpdateTextBlocklistItemsResult(IEnumerable<TextBlocklistItem> blocklistItems = null)
        {
            blocklistItems ??= new List<TextBlocklistItem>();

            return new AddOrUpdateTextBlocklistItemsResult(blocklistItems?.ToList());
        }

        /// <summary> Initializes a new instance of TextBlocklist. </summary>
        /// <param name="name"> Text blocklist name. </param>
        /// <param name="description"> Text blocklist description. </param>
        /// <returns> A new <see cref="ContentSafety.TextBlocklist"/> instance for mocking. </returns>
        public static TextBlocklist TextBlocklist(string name = null, string description = null)
        {
            return new TextBlocklist(name, description);
        }
    }
}
