﻿// Copyright (c) Drew Noakes and contributors. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace MetadataExtractor.Formats.Iso14496.Boxes
{
    internal sealed class DataReferenceBox : FullBox
    {
        public IList<Box> Boxes { get; }
        public uint BoxCount { get; }

        public DataReferenceBox(BoxLocation location, SequentialReader reader)
            : base(location, reader)
        {
            BoxCount = reader.GetUInt32();
            Boxes = BoxReader.ReadBoxes(reader, location);
        }

        public override IEnumerable<Box> Children() => Boxes;
    }
}
