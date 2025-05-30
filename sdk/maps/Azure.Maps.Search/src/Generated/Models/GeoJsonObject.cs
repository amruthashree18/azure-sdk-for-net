// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    /// <summary>
    /// A valid `GeoJSON` object. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3) for details.
    /// Please note <see cref="GeoJsonObject"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="GeoJsonFeature"/>, <see cref="GeoJsonFeatureCollection"/>, <see cref="GeoJsonGeometry"/>, <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
    /// </summary>
    internal abstract partial class GeoJsonObject
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonObject"/>. </summary>
        protected GeoJsonObject()
        {
            BoundingBox = new ChangeTrackingList<double>();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonObject"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="boundingBox"> Bounding box. Projection used - EPSG:3857. Please refer to [RFC 7946](https://datatracker.ietf.org/doc/html/rfc7946#section-5) for details. </param>
        internal GeoJsonObject(GeoJsonObjectType type, IReadOnlyList<double> boundingBox)
        {
            Type = type;
            BoundingBox = boundingBox;
        }

        /// <summary> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </summary>
        internal GeoJsonObjectType Type { get; set; }
        /// <summary> Bounding box. Projection used - EPSG:3857. Please refer to [RFC 7946](https://datatracker.ietf.org/doc/html/rfc7946#section-5) for details. </summary>
        public IReadOnlyList<double> BoundingBox { get; }
    }
}
