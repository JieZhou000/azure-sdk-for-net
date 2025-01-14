// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> An object representing a figure in the document. </summary>
    public partial class DocumentFigure
    {
        /// <summary> Initializes a new instance of DocumentFigure. </summary>
        /// <param name="spans"> Location of the figure in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="spans"/> is null. </exception>
        internal DocumentFigure(IEnumerable<DocumentSpan> spans)
        {
            Argument.AssertNotNull(spans, nameof(spans));

            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
            Elements = new ChangeTrackingList<string>();
            Footnotes = new ChangeTrackingList<DocumentFootnote>();
        }

        /// <summary> Initializes a new instance of DocumentFigure. </summary>
        /// <param name="boundingRegions"> Bounding regions covering the figure. </param>
        /// <param name="spans"> Location of the figure in the reading order concatenated content. </param>
        /// <param name="elements"> Child elements of the figure, excluding any caption or footnotes. </param>
        /// <param name="caption"> Caption associated with the figure. </param>
        /// <param name="footnotes"> List of footnotes associated with the figure. </param>
        internal DocumentFigure(IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, IReadOnlyList<string> elements, DocumentCaption caption, IReadOnlyList<DocumentFootnote> footnotes)
        {
            BoundingRegions = boundingRegions;
            Spans = spans;
            Elements = elements;
            Caption = caption;
            Footnotes = footnotes;
        }

        /// <summary> Bounding regions covering the figure. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the figure in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Child elements of the figure, excluding any caption or footnotes. </summary>
        public IReadOnlyList<string> Elements { get; }
        /// <summary> Caption associated with the figure. </summary>
        public DocumentCaption Caption { get; }
        /// <summary> List of footnotes associated with the figure. </summary>
        public IReadOnlyList<DocumentFootnote> Footnotes { get; }
    }
}
